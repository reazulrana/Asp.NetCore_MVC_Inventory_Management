using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Sales;
using Microsoft.AspNetCore.Mvc.Rendering;
using BussinessAccessLayer.Model;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.ViewModels.Purchase;
using System.Data.SqlClient;
namespace InevntoryManagement.Controllers
{
    public class SaleController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SaleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            //SqlConnection
        }
        
        public IActionResult Index()
        {

            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            SaleCreateViewModel model = new SaleCreateViewModel();
            model.BranchList = BranchList(model);
            model.SaleTypeList = SaleTypes(model);

            model.SaleFromList = SaleFroms(model);
            model.PaymentTypeList = PaymentTypeList(model);


            //int maxno = unitOfWork.Purchases.Get().Select(X=>X.PurchaseNo).Max(x => int.Parse(x.PurchaseNo.Substring(x.PurchaseNo.Length-(x.PurchaseNo.IndexOf("-")-1))));
            List<int> s = unitOfWork.Sales.Get().Select(x => int.Parse(x.Invoice.Substring((x.Invoice.IndexOf("-") + 1)))).ToList();

            //List<int> sb= s as List<int>;

            string maxno = s.Count > 0 ? (s.Max() + 1).ToString() : "1";

            string day = DateTime.Today.Day.ToString().Length == 1 ? "0" + DateTime.Today.Day.ToString() : DateTime.Today.Day.ToString();
            string month = DateTime.Today.Month.ToString().Length == 1 ? "0" + DateTime.Today.Month.ToString() : DateTime.Today.Month.ToString(); ;
            string year = DateTime.Today.Year.ToString().Length >= 4 ? DateTime.Today.Year.ToString().Substring(2, 2) : DateTime.Today.Year.ToString();
            string fulldate = day + "/" + month + "/" + year.ToString();

            fulldate = fulldate + "-" + maxno;
            model.Invoice = fulldate;
            return View(model);
        }


        [HttpPost]
        public IActionResult Create(SaleCreateViewModel model, string btnSave)
        {


            model.BranchList = BranchList(model);
            model.SaleTypeList = SaleTypes(model);

            model.SaleFromList = SaleFroms(model);
            model.PaymentTypeList = PaymentTypeList(model);
            model.PurchaseProductInfos = GetProductTableList(model);

            if (ModelState.IsValid)
            {
                if (model.ProductIds == null || model.ProductIds.Count <= 0)
                {
                    Global_Functions.SetMessage("Prodcut List Is Empty", "danger");
                    return View(model);
                }

                try
                {
                    unitOfWork.BeginTransaction();
                    //customer section
                    Customer customer = new Customer()
                    {
                        CustName = model.CustName,
                        Address = model.Address,
                        Contact = model.Contact
                    };
                    unitOfWork.Customers.Insert(customer);


                    //sale sectioon
                    Sale sale = new Sale()
                    {
                        Invoice = model.Invoice,
                        TrDate = model.TrDate,
                        CustomerID = customer.ID,
                        UserID = 1,
                        Remarks = model.Remarks,
                        BranchId = model.BranchId,
                        //OrderNo=model.order
                        PaymentTypeId = model.PaymentTypeId,
                        SaleType = model.SaleType,
                        SaleFrom = model.SaleFrom,
                        //OrderNo=model.order
                    };


                    unitOfWork.Sales.Insert(sale);


                    Amount amount = new Amount()
                    {
                        TrID = sale.SaleID,
                        Discount = model.Discount,
                        Dues = model.Dues,
                        GrossAmount = model.GrossAmount,
                        NetAmount = model.NetAmount,
                        Others = model.Others,
                        PaymentOnCash = model.PaymentOnCash,
                        PaymentTypeId = model.PaymentTypeId,
                        TotalAmount = model.TotalAmount,
                        Transport = model.Transport,
                        TrType = 2
                    };
                    unitOfWork.Amounts.Insert(amount);

                    List<MasterDetail> masterDetailslist = new List<MasterDetail>();
                    for (int i = 0; i <= model.ProductIds.Count - 1; i++)
                    {
                        MasterDetail masterDetail = new MasterDetail()
                        {
                            AmountId = amount.Id,
                            ProductId = model.ProductIds[i],
                            Price = model.Prices[i],
                            Qty = model.Qtys[i],
                        };
                        masterDetailslist.Add(masterDetail);

                    }
                    unitOfWork.MasterDetails.Insert(masterDetailslist);

                    unitOfWork.CommitTransaction();
                    Global_Functions.SetMessage("Sale Invoice Saved Successfully", "success");

                    if (btnSave.ToLower() == "saveprint")
                    {
                        return RedirectToAction("Print", "Report",new { saleid= sale.SaleID });
                    }
                    return View(model);

               

                }
                catch
                {
                    unitOfWork.RollbackTransaction();

                }



            }






            return View(model);
        }


        List<PurchaseProductInfo> GetProductTableList(SaleCreateViewModel model)
        {
            if (model.ProductIds.Count > 0)
            {
                for (int i = 0; i < model.ProductIds.Count; i++)
                {
                    PurchaseProductInfo pi = new PurchaseProductInfo()
                    {
                        ProdId = model.ProductIds[i],
                        code = model.Codes[i],
                        color = model.Colors[i],
                        description = model.Descriptions[i],
                        model = model.Models[i],
                        photopath = model.Images[i],
                        price = model.Prices[i],
                        qty = model.Qtys[i],
                        size = model.Sizes[i]

                    };

                    model.PurchaseProductInfos.Add(pi);
                }

            }


            return model.PurchaseProductInfos;
        }




        //Get All Branch From Database
        private List<SelectListItem> BranchList(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitOfWork.Branchs.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Name,
                          Value = obj.Id.ToString(),
                          Selected = model.BranchId != 0 ? obj.Id == model.BranchId : obj.IsSelected
                      }).ToList();

            return output;
        }



        //Get All SaleType From Database
        private List<SelectListItem> SaleTypes(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitOfWork.SellingTypes.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Types!=null? obj.Types:null,
                          Value = obj.Id!=0? obj.Id.ToString():null,
                          Selected = model.SaleType!=null ? obj.Types.ToLower() == model.SaleType.ToLower() :  obj.IsSelected
                      }).ToList();

            return output;
        }




        //Get All SaleFrom From Database
        private List<SelectListItem> SaleFroms(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitOfWork.SellFroms.Get()
                      select new SelectListItem()
                      {
                          Text = obj.SaleFrom != null ? obj.SaleFrom : null,
                          Value = obj.Id != 0 ? obj.Id.ToString() : null,
                          Selected = model.SaleFrom != null ? obj.SaleFrom.ToLower() == model.SaleFrom.ToLower() :  obj.IsSelected
                      }).ToList();

            return output;
        }




        //Get All PaymentTypes From Database
        private List<SelectListItem> PaymentTypeList(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitOfWork.PaymentTypes.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Payments != null ? obj.Payments : null,
                          Value = obj.Id != 0 ? obj.Id.ToString() : null,
                          Selected = model.PaymentTypeId != 0 ? obj.Id == model.PaymentTypeId : obj.IsSelected
                      }).ToList();

            return output;
        }


        //Clear All IsSelected Field in Sellfrom Table From Database
        private void clear_IsSelected_SaleFrom()
        {
            List<SellFrom> sellFroms = unitOfWork.SellFroms.Get().ToList();

            foreach (var sellfrom in sellFroms)
            {
                var _sellfrom = unitOfWork.SellFroms.GetByID(sellfrom.Id);
                _sellfrom.IsSelected = false;
                unitOfWork.SellFroms.Update(_sellfrom);
            }

        }


        //Clear All IsSelected Field in SellType Table From Database
        private void clear_IsSelected_SellType()
        {
            List<SellingType> sellingTypes = unitOfWork.SellingTypes.Get().ToList();

            foreach (var sellingType in sellingTypes)
            {
                var _sellingType = unitOfWork.SellingTypes.GetByID(sellingType.Id);
                _sellingType.IsSelected = false;
                unitOfWork.SellingTypes.Update(_sellingType);
            }

        }

        // Call from Sale form with ajax btnSaveSaleFrom

        [HttpPost]
        public JsonResult Create_SaleFrom_With_Ajax(string SaleFrom,bool isselected)
        {
            string msg = "";

            bool success = false;
            SellFrom output = new SellFrom();
            try
            {

                var _salefrom = unitOfWork.SellFroms.Get().Where(x => x.SaleFrom.ToLower() == SaleFrom.ToLower()).FirstOrDefault();

                if(isselected)
                {
                    //Clear All IsSelected Field in Branch Table From Database
                    clear_IsSelected_SaleFrom();
                }
                //Category Exist
                if (_salefrom != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Sale From");

                }
                else
                {
                    output.SaleFrom = SaleFrom.ToUpper();
                    output.IsSelected = isselected;
                    unitOfWork.SellFroms.Insert(output);

                    success = true;
                    msg = Global_Functions.SaveMessage("Sale From");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Sale From");
            }
            return new JsonResult(new { output, success, msg });


        }



        // Call from Sale form with ajax btnSaveSaleFrom

        [HttpPost]
        public JsonResult Create_SaleType_With_Ajax(string SaleType,bool isselected)
        {
            string msg = "";

            bool success = false;
            SellingType output = new SellingType();
            try
            {
                if (isselected)
                {
                    //Clear All IsSelected Field in Branch Table From Database
                    clear_IsSelected_SaleFrom();
                }

                var _saletype = unitOfWork.SellingTypes.Get().Where(x => x.Types.ToLower() == SaleType.ToLower()).FirstOrDefault();

                //SaleType Is Exist
                if (_saletype != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Sale Type");

                }
                else
                {
                    output.Types = SaleType.ToUpper();
                    output.IsSelected = isselected;
                    unitOfWork.SellingTypes.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Sale Type");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Sale Type");
            }
            return new JsonResult(new { output, success, msg });
        }




        


    }
}
