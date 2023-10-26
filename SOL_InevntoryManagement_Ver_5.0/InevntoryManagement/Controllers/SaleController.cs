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
//using InevntoryManagement.ViewModels.Purchase;
using System.Data.SqlClient;
using DataAccessLayer.Dapper;
using BussinessAccessLayer.ExtendModel;
using Dapper;
using System.Data;
using InevntoryManagement.Models;

namespace InevntoryManagement.Controllers
{
    public class SaleController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IDapperService dapperService;
        private readonly IRawQueryService rawQueryService;

        public SaleController(IUnitOfWork unitOfWork, IDapperService dapperService)
        {
            this.unitOfWork = unitOfWork;
            this.dapperService = dapperService;
            this.rawQueryService = new RawQueryService();
            //SqlConnection
        }

        public IActionResult Index()
        {

            return View();
        }


        #region create part

        //get customer list

        List<SelectListItem> GetCustomerList(List<SelectListItem> customerlist)
        {
            customerlist = (from customer in unitOfWork.Customers.Get()
                            select new SelectListItem()
                            {
                                Text = customer.Contact != null ? "Name: " + customer.CustName + " ; Contact " + customer.Contact : "Name: " + customer.CustName + " ; Contact " + "Contact Not Available",
                                Value = customer.ID.ToString()
                            }).ToList();

            return customerlist;
        }



        [HttpGet]
        public IActionResult Create()
        {
            SaleCreateViewModel model = new SaleCreateViewModel();
            model.BranchList = BranchList(model);
            model.SaleTypeList = SaleTypes(model);

            model.SaleFromList = SaleFroms(model);
            model.PaymentTypeList = PaymentTypeList(model);
            model.CustomerList = GetCustomerList(model.CustomerList);

            //int maxno = unitOfWork.Purchases.Get().Select(X=>X.PurchaseNo).Max(x => int.Parse(x.PurchaseNo.Substring(x.PurchaseNo.Length-(x.PurchaseNo.IndexOf("-")-1))));
            List<int> s = unitOfWork.Sales.Get().Select(x => int.Parse(x.Invoice.Substring((x.Invoice.IndexOf("-") + 1)))).ToList();

            //List<int> sb= s as List<int>;

            string maxno = s.Count > 0 ? (s.Max() + 1).ToString() : "1"; // Increment 1 with last Invoice No 

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
            model.ProductInfos = GetProductTableList(model);
            model.CustomerList = GetCustomerList(model.CustomerList);

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

                    Customer customer = null;
                    if (model.customer.ID != 0)
                    {
                        customer = unitOfWork.Customers.GetByID(model.customer.ID);
                    }
                    else
                    {
                        //customer section
                        customer = new Customer()
                        {
                            CustName = model.customer.CustName,
                            Address = model.customer.Address,
                            Contact = model.customer.Contact
                        };
                        unitOfWork.Customers.Insert(customer);
                    }


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
                        return RedirectToAction("PrintSaleInvoice", "Report", new { saleid = sale.SaleID });
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
        #endregion













        #region Edit Section
        [HttpGet]
        //public IActionResult GetSaleEditList(int? pageno,int? pagesize, string SearchText, fileextensions? Extension)
        public IActionResult GetSaleEditList(BasePaginate _model)
        {
            try
            {
                SaleDetailsViewModel model = new SaleDetailsViewModel();

                string strqry = "";
                DynamicParameters p = new DynamicParameters();
                if (_model.SearchText != null)
                {

                    strqry = " and ( s.Invoice like @invoice or b.Name like @name or p.Payments like @paymenttype) "; //" and s.TrDate between @fromdate and @todate"; //" and ( s.Invoice like @invoice or b.Name like @name or p.Payments like @paymenttype) and s.TrDate between @fromdate and @todate";
                    p.Add("@invoice", "%" + _model.SearchText + "%", dbType: DbType.String);
                    p.Add("@name", "%" + _model.SearchText + "%", dbType: DbType.String);
                    p.Add("@paymenttype", "%" + _model.SearchText + "%", dbType: DbType.String);
                    model.SearchText = _model.SearchText;

                }



                if (strqry == "")
                {
                    p = null;
                }




                model.saleDetailsViewModels = dapperService.GetDynamicTableList<SaleDetailsViewModels>(rawQueryService.GetSaletListQuery, null, CommandType.Text).OrderByDescending(x => x.Invoice).ToList();


                model.PageSize = model.DefaultPageSize(_model.PageSize);
                //model.PageSize = model.DefaultPageSize(pagesize);

                model.TotalRow = model.saleDetailsViewModels.Count();

                model.PageIndex = model.DefaultPageIndex(_model.PageIndex);
                //model.PageIndex = model.DefaultPageSize(pageno);

                if (_model.Extension != fileextensions.none)
                {
                    string exportfilename = "ExportSaleDetailsInfo";
                    ExportData ed = new ExportData(exportfilename, _model.Extension);
                    ed.exportData<SaleDetailsViewModels>(model.saleDetailsViewModels);
                }


                model.saleDetailsViewModels = model.saleDetailsViewModels.SkipLast(model.SkipRow).TakeLast(model.PageSize).OrderBy(x => x.Invoice).ToList();



                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorTitle = "Resource NotFound";
                ViewBag.ErrorMessage = "Check Is Your Internet Connection Is Ok.";
                return View("NotFound");
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {


            Sale sale = unitOfWork.Sales.GetByID(id);
            if (sale == null)
            {
                ViewBag.ErrorTitle = "Sale Data Not Found";
                ViewBag.ErrorMessage = $"The Id {id} You are Finding is not exist in database";
                return View("NotFound");
            }


            try
            {

                Customer customer = unitOfWork.Customers.GetByID(sale.CustomerID);
                Amount amount = unitOfWork.Amounts.Get(a => a.TrID == sale.SaleID && a.TrType == 2).FirstOrDefault();
                SaleEditViewModel model = new SaleEditViewModel();
                //sales information
                model.saleid = sale.SaleID;
                model.Invoice = sale.Invoice;
                model.TrDate = sale.TrDate;
                model.BranchId = sale.BranchId;
                model.SaleType = sale.SaleType;
                model.SaleFrom = sale.SaleFrom;
                model.PaymentTypeId = sale.PaymentTypeId;
                model.Remarks = sale.Remarks;

                //Customer information
                model.customer.ID = customer.ID;

                model.customer.CustName = customer.CustName;
                model.customer.Address = customer.Address;
                model.customer.Contact = customer.Contact;

                //Amounts information
                model.TotalAmount = amount.TotalAmount;
                model.PaymentOnCash = amount.PaymentOnCash;
                model.Dues = amount.Dues;
                model.Transport = amount.Transport;
                model.Others = amount.Others;
                model.GrossAmount = amount.GrossAmount;
                model.Discount = amount.Discount;
                model.NetAmount = amount.NetAmount;
                model.TotalAmount = amount.TotalAmount;

                //lists Part
                model.BranchList = BranchList(model);
                model.SaleTypeList = SaleTypes(model);
                model.SaleFromList = SaleFroms(model);
                model.PaymentTypeList = PaymentTypeList(model);
                model.ProductInfos = dapperService.GetSaleProductInfoById(model.saleid);
                model.CustomerList = GetCustomerList(model.CustomerList);
                return View(model);
            }

            catch (Exception ex)
            {
                ViewBag.ErrorTitle = "Sale Data Not Found";
                ViewBag.ErrorMessage = ex.Message;
                return View("NotFound");
            }


        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(SaleEditViewModel model, string btnSave)
        {
            model.BranchList = BranchList(model);
            model.SaleTypeList = SaleTypes(model);

            model.SaleFromList = SaleFroms(model);
            model.PaymentTypeList = PaymentTypeList(model);
            model.ProductInfos = dapperService.GetSaleProductInfoById(model.saleid);
            model.CustomerList = GetCustomerList(model.CustomerList);

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


                    //sale sectioon
                    Sale _sale = unitOfWork.Sales.GetByID(model.saleid);




                    //Invoice = model.Invoice,
                    _sale.TrDate = model.TrDate;
                    _sale.CustomerID = model.customer.ID;
                    _sale.UserID = 1;
                    _sale.Remarks = model.Remarks;
                    _sale.BranchId = model.BranchId;
                    //OrderNo=model.order
                    _sale.PaymentTypeId = model.PaymentTypeId;
                    _sale.SaleType = model.SaleType;
                    _sale.SaleFrom = model.SaleFrom;
                    //OrderNo=model.order



                    unitOfWork.Sales.Update(_sale);


                    //customer section

                    Customer _customer = unitOfWork.Customers.GetByID(_sale.CustomerID);
                    _customer.CustName = model.customer.CustName;
                    _customer.Address = model.customer.Address;
                    _customer.Contact = model.customer.Contact;

                    unitOfWork.Customers.Update(_customer);




                    Amount _amount = unitOfWork.Amounts.Get(a => a.TrID == _sale.SaleID && a.TrType == 2).FirstOrDefault();

                    _amount.TrID = _sale.SaleID;
                    _amount.Discount = model.Discount;
                    _amount.Dues = model.Dues;
                    _amount.GrossAmount = model.GrossAmount;
                    _amount.NetAmount = model.NetAmount;
                    _amount.Others = model.Others;
                    _amount.PaymentOnCash = model.PaymentOnCash;
                    _amount.PaymentTypeId = model.PaymentTypeId;
                    _amount.TotalAmount = model.TotalAmount;
                    _amount.Transport = model.Transport;
                    _amount.TrType = 2;

                    unitOfWork.Amounts.Update(_amount);
                    //delete masterdetails according to amountid and then reinsert product list into masterdetails
                    List<MasterDetail> _masterdetails = unitOfWork.MasterDetails.Get(ms => ms.AmountId == _amount.Id).ToList();
                    unitOfWork.MasterDetails.Delete(_masterdetails);

                    //add into list to insert in masterdetails table
                    List<MasterDetail> masterDetailslist = new List<MasterDetail>();
                    for (int i = 0; i <= model.ProductIds.Count - 1; i++)
                    {
                        MasterDetail masterDetail = new MasterDetail()
                        {
                            AmountId = _amount.Id,
                            ProductId = model.ProductIds[i],
                            Price = model.Prices[i],
                            Qty = model.Qtys[i],
                        };
                        masterDetailslist.Add(masterDetail);

                    }
                    unitOfWork.MasterDetails.Insert(masterDetailslist);
                    model.ProductInfos = dapperService.GetSaleProductInfoById(model.saleid);

                    unitOfWork.CommitTransaction();
                    Global_Functions.SetMessage("Sale Invoice Update Successfully", "success");

                    if (btnSave.ToLower() == "saveprint")
                    {
                        return RedirectToAction("PrintSaleInvoice", "Report", new { saleid = _sale.SaleID });
                    }
                    return RedirectToAction("edit", new { id = _sale.SaleID });



                }
                catch (Exception ex)
                {
                    model.customer = unitOfWork.Customers.GetByID(model.customer.ID);
                    Global_Functions.SetMessage(ex.Message, "danger");
                    unitOfWork.RollbackTransaction();

                }

            }


            return View(model);
        }




        #endregion



        #region Delete Section
        [HttpPost]
        public IActionResult Delete(int id)
        {


            try
            {

                unitOfWork.BeginTransaction();


                Sale sale = unitOfWork.Sales.GetByID(id);

                if (sale == null)
                {
                    ViewBag.ErrorTitle = "Sale Data Not Found";
                    ViewBag.ErrorMessage = $"The Id {id} You are Finding is not exist in database";
                    return View("NotFound");
                }
                Amount amount = unitOfWork.Amounts.Get(a => a.TrID == id && a.TrType == 2).FirstOrDefault();

                List<MasterDetail> masterDetails = unitOfWork.MasterDetails.Get(ms => ms.AmountId == amount.Id).ToList();
                unitOfWork.MasterDetails.Delete(masterDetails);
                unitOfWork.Amounts.Delete(amount);
                unitOfWork.Sales.Delete(sale);

                unitOfWork.CommitTransaction();
                Global_Functions.SetMessage($"Invoice No { sale.Invoice } id Deleted Successfully", "success");

                return RedirectToAction("GetSaleEditList");
            }
            catch (Exception ex)
            {
                unitOfWork.RollbackTransaction();
                ViewBag.ErrorTitle = ex.Message;
                ViewBag.ErrorMessage = ex.StackTrace;
                return View("NotFound");

            }


        }

        #endregion






        #region Private Method and Properties



        //Get All Branch From Database
        private List<SelectListItem> BranchList(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            List<Branch> brancs = unitOfWork.Branchs.Get().ToList();
            foreach (Branch b in brancs)
            {
                SelectListItem _output = new SelectListItem
                {
                    Text = b.Name,
                    Value = b.Id.ToString(),
                    Selected = model.BranchId != 0 ? b.Id == model.BranchId : b.IsSelected

                };
                output.Add(_output);

            }

            //output = (from obj in unitOfWork.Branchs.Get()
            //          select new SelectListItem()
            //          {
            //              Text = obj.Name,
            //              Value = obj.Id.ToString(),
            //              Selected = model.BranchId != 0 ? obj.Id == model.BranchId : obj.IsSelected
            //          }).ToList();

            return output;
        }


        List<ProductInfo> GetProductTableList(SaleCreateViewModel model)
        {
            if (model.ProductIds.Count > 0)
            {
                for (int i = 0; i < model.ProductIds.Count; i++)
                {
                    ProductInfo pi = new ProductInfo()
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

                    model.ProductInfos.Add(pi);
                }

            }


            return model.ProductInfos;
        }





        //Get All SaleType From Database
        private List<SelectListItem> SaleTypes(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitOfWork.SellingTypes.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Types != null ? obj.Types : null,
                          Value = obj.Id != 0 ? obj.Id.ToString() : null,
                          Selected = model.SaleType != 0 ? obj.Id == model.SaleType : obj.IsSelected
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
                          Selected = model.SaleFrom != 0 ? obj.Id == model.SaleFrom : obj.IsSelected
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
        #endregion

        #region Ajax Part
        // Call from Sale form with ajax btnSaveSaleFrom

        [HttpPost]
        public JsonResult Create_SaleFrom_With_Ajax(string SaleFrom, bool isselected)
        {
            string msg = "";

            bool success = false;
            SellFrom output = new SellFrom();
            try
            {

                var _salefrom = unitOfWork.SellFroms.Get().Where(x => x.SaleFrom.ToLower() == SaleFrom.ToLower()).FirstOrDefault();

                if (isselected)
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


        //Sale List
        [HttpGet]

        //public IActionResult GetSaleList(int? pageno, int? PageSize, string SearchText, fileextensions? Extension)

        public IActionResult GetSaleList(BasePaginate _model)
        {
            try
            {



                DynamicParameters p = new DynamicParameters();
                SaleListViewModel model = new SaleListViewModel();
                string strqry = "";
                if (_model.SearchText != null)
                {

                    strqry = " and ( s.Invoice like @invoice or b.Name like @name or p.Payments like @paymenttype) "; //" and s.TrDate between @fromdate and @todate"; //" and ( s.Invoice like @invoice or b.Name like @name or p.Payments like @paymenttype) and s.TrDate between @fromdate and @todate";
                    p.Add("@invoice", "%" + _model.SearchText + "%", dbType: DbType.String);
                    p.Add("@name", "%" + _model.SearchText + "%", dbType: DbType.String);
                    p.Add("@paymenttype", "%" + _model.SearchText + "%", dbType: DbType.String);
                    model.SearchText = _model.SearchText;

                }



                if (strqry == "")
                {
                    p = null;
                }



                model.saleDetailsViewModels = dapperService.GetDynamicTableList<SaleDetailsViewModels>(rawQueryService.GetSaletListQuery + strqry, p, CommandType.Text).OrderByDescending(x => x.TrDate).OrderByDescending(x => x.Invoice).ToList();

                //file name
                if (_model.Extension != fileextensions.none)
                {

                    string filename = "SaveSaleDetails";
                    ExportData ed = new ExportData(filename, _model.Extension);

                    ed.exportData<SaleDetailsViewModels>(model.saleDetailsViewModels);


                    Global_Functions.SetMessage(ExportData.GetDefault_Download_FilePath() + filename + "." + _model.Extension, "success");

                }



                model.PageSize = model.DefaultPageSize(_model.PageSize);
                //model.PageSize = model.DefaultPageSize(PageSize);
                model.TotalRow = model.saleDetailsViewModels.Count();

                model.PageIndex = model.DefaultPageIndex(_model.PageIndex);
                //model.PageIndex = model.DefaultPageIndex(pageno);
                model.SearchText = _model.SearchText;

                model.saleDetailsViewModels = model.saleDetailsViewModels.SkipLast(model.SkipRow).TakeLast(model.PageSize).OrderBy(x => x.TrDate).OrderBy(x => x.Invoice).ToList();


                //ExportData.ExceltoPDF<SaleDetailsViewModels>(saleDetailsViewModel.saleDetailsViewModels, "SaleDetailsList");

                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorTitle = "Resource Not Found Error";
                ViewBag.ErrorMessage = ex.Message;
                return View("NotFound");
            }

        }



        // Call from Sale form with ajax btnSaveSaleFrom

        [HttpPost]
        public JsonResult Create_SaleType_With_Ajax(string SaleType, bool isselected)
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



        // Call from Sale form with ajax btnaddproduct

        [HttpPost]
        public JsonResult checkBalance(int productid)
        {

            bool success = false;
            int prdBalance = 0; //ProductBalance

            ProductBalance pb = dapperService.GetProductBalanceById(productid);
            if (pb != null)
            {
                success = true;
                prdBalance = pb.Balance;
            }





            return new JsonResult(new { success, prdBalance });
        }



        #endregion




        //call from getSaleEditfrom form
        [HttpGet]
        public JsonResult GetInvoiceDetails_Ajax(int id)
        {

            bool blnflag = false;
            try
            {



                string query = " select sal.Invoice as invoiceno, convert(nvarchar(15), sal.TrDate,103) as InvoiceDate, Branchs.Name as Branch, ";
                query = query + " pm.Payments as InvoiceType,sal.remarks, sf.SaleFrom as SellingFrom, salt.Types as SellingType, ";
                query = query + " a.TotalAmount, a.Dues,a.Transport Transport, a.Others, a.GrossAmount, a.Discount, a.NetAmount,a.PaymentOnCash,";
                query = query + " Customers.CustName,Customers.Address,Customers.Contact from sales as sal";
                query = query + " inner join Branchs on sal.BranchId = Branchs.Id";
                query = query + " inner join Amounts a on sal.SaleID = a.TrID";
                query = query + " inner join PaymentTypes pm on sal.PaymentTypeId = pm.Id";
                query = query + " inner join SellFroms sf on sal.SaleFrom = sf.Id";
                query = query + " inner join SellingTypes salt on sal.SaleType = salt.Id";
                query = query + " inner join Customers on sal.CustomerID = Customers.ID";
                query = query + " where a.TrType = 2 and sal.SaleID = @saleid";


                DynamicParameters param = new DynamicParameters();
                param.Add("@saleid", id, dbType: DbType.Int32);
                SaleInvoiceDetailsModel model = dapperService.GetDynamicTableList<SaleInvoiceDetailsModel>(query, param, CommandType.Text).FirstOrDefault();

                string queryp = "Select sal.SaleID, p.Id as ProdId,p.Code,p.Description,cat.CType";
                queryp = queryp + " , m.ModelName,p.Size,p.Color,p.PhotoPath, ms.Qty,ms.Price,(ms.Qty * ms.Price) as TotalAmount  from Sales sal";
                queryp = queryp + " inner join Amounts a on sal.SaleID = a.TrID inner";
                queryp = queryp + " join MasterDetail ms on a.Id = ms.AmountId";
                queryp = queryp + " inner join Products p on ms.ProductId = p.Id";
                queryp = queryp + " inner join Models m on p.ModelId = m.Id";
                queryp = queryp + " inner join Brands br on m.BrandId = br.Id";
                queryp = queryp + " inner join Categories cat on br.CategoryId = cat.Id where a.TrType = 2 and sal.saleid=@saleid";

                DynamicParameters p = new DynamicParameters();

                p.Add("@saleid", id, dbType: DbType.Int32);

                model.saleInvoiceProductDetails = dapperService.GetDynamicTableList<SaleInvoiceProductDetails>(queryp, p, CommandType.Text);


                blnflag = true;
                return new JsonResult(new { model, blnflag });

            }
            catch (Exception ex)
            {

                return new JsonResult(new { ex.Message, blnflag });

            }
        }


        //call from sale create and edit form js file salesCustomerInformation.js

        [HttpGet]
        public JsonResult FindCustomer_Ajax(int id)
        {

            bool blnmessage = false;
            Customer output = unitOfWork.Customers.GetByID(id);

            blnmessage = output != null ? true : false;


            return new JsonResult(new { blnmessage, output });
        }





    }
}
