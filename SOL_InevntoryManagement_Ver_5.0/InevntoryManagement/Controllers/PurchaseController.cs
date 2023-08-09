using DataAccessLayer.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.ViewModels.Purchase;
using Microsoft.AspNetCore.Mvc.Rendering;
using InevntoryManagement.GlobalFuntion;
using BussinessAccessLayer.Model;

namespace InevntoryManagement.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public PurchaseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            PurchaseCreateViewModel model = new PurchaseCreateViewModel();
            model = LoadMultySelectList(model);

            return View(model);
        }


        [HttpPost]
        public IActionResult Create(PurchaseCreateViewModel model)
        {

            model = LoadMultySelectList(model);


            if (ModelState.IsValid)
            {
                if (model.ProductId == null || model.ProductId.Count == 0)
                {

                    Global_Functions.SetMessage($"Product List is Empty ", "danger");
                    return View(model);
                }

                try {
                    unitOfWork.BeginTransaction();


                    Purchase _purchase = new Purchase()
                    {
                        PurchaseNo = model.Invoice,
                        ReceiveDate = model.ReceiveDate,
                        Remarks = model.Remarks,
                        SourceId = model.SourceId,
                        TrDate = model.TrDate,
                        VendorId = model.VendorId,
                        ReceivedByID = 1,
                        BranchId = model.BranchId,

                    };

                    unitOfWork.Purchases.Insert(_purchase);

                    Amount _amount = new Amount()
                    {
                        Discount = model.Discount,
                        Dues = model.Dues,
                        GrossAmount = model.GrossAmount,
                        NetAmount = model.NetAmount,
                        Others = model.Others,
                        PaymentTypeId = model.PaymentTypeId,
                        TotalAmount = model.TotalAmount,
                        TrType = 1,
                        TrID = _purchase.PurchaseID,
                        Transport = model.Transport,
                        PaymentOnCash = model.PaymentOnCash,


                    };
                    unitOfWork.Amounts.Insert(_amount);

                    List<MasterDetail> masterDetailslist = new List<MasterDetail>();
                    for (int i = 0; i <= model.ProductId.Count - 1; i++)
                    {
                        MasterDetail masterDetail = new MasterDetail()
                        {
                            AmountId = _amount.Id,
                            ProductId = model.ProductId[i],
                            Price = model.Price[i],
                            Qty = model.Qty[i],
                        };
                        masterDetailslist.Add(masterDetail);

                    }
                    unitOfWork.CommitTransaction();

                    unitOfWork.MasterDetails.Insert(masterDetailslist);
                    Global_Functions.SetMessage($"Purchase Create Purchase ID( {_purchase.PurchaseID.ToString()} )", "success");
                    return RedirectToAction("Create", "Purchase");
                }
                catch (Exception ex)
                {
                    unitOfWork.RollbackTransaction();
                }





            }


            return View(model);
        }



        public IActionResult PurchaseList()
        {

            List<PurchaseListViewModel> model = (from p in unitOfWork.Purchases.Get()
                                                 join b in unitOfWork.Branchs.Get()
                                                 on p.BranchId equals b.Id
                                                 join a in unitOfWork.Amounts.Get()
                                                 on p.PurchaseID equals a.TrID
                                                 join v in unitOfWork.Vendors.Get()
                                                 on p.VendorId equals v.Id
                                                 join s in unitOfWork.Sources.Get()
                                                 on p.SourceId equals s.Id
                                                 join pa in unitOfWork.PaymentTypes.Get()
                                                 on a.PaymentTypeId equals pa.Id
                                                 select new PurchaseListViewModel()
                                                 {
                                                     Branch = b.Name,
                                                     Discount = a.Discount,
                                                     Dues = a.Dues,
                                                     id = p.PurchaseID,
                                                     GrossAmount = a.GrossAmount,
                                                     NetAmount = a.NetAmount,
                                                     Others = a.Others,
                                                     PaymentOnCash = a.PaymentOnCash,
                                                     PaymentType = pa.Payments,
                                                     ReceiveDate = p.ReceiveDate,
                                                     ReceivedByID = p.ReceivedByID,
                                                     Remarks = p.Remarks,
                                                     Source = s.SourceName,
                                                     Transport = a.Transport,
                                                     TrDate = p.TrDate,
                                                     PurchaseNo = p.PurchaseNo,
                                                     Vendor = v.VendorName,
                                                     TotalAmount = a.TotalAmount // Total Product Cost



                                                 }).ToList();


            //model=  LoadMultySelectList(model) as PurchaseEditViewModel;

            return View(model);
        }


        //edit section

        [HttpGet]
        public IActionResult EditPurchaseList()
        {


            List<PurchaseListViewModel> model = (from p in unitOfWork.Purchases.Get()
                                                 join b in unitOfWork.Branchs.Get()
                                                 on p.BranchId equals b.Id
                                                 join a in unitOfWork.Amounts.Get()
                                                 on p.PurchaseID equals a.TrID
                                                 join v in unitOfWork.Vendors.Get()
                                                 on p.VendorId equals v.Id
                                                 join s in unitOfWork.Sources.Get()
                                                 on p.SourceId equals s.Id
                                                 join pa in unitOfWork.PaymentTypes.Get()
                                                 on a.PaymentTypeId equals pa.Id
                                                 select new PurchaseListViewModel()
                                                 {
                                                     Branch = b.Name,
                                                     Discount = a.Discount,
                                                     Dues = a.Dues,
                                                     id = p.PurchaseID,
                                                     GrossAmount = a.GrossAmount,
                                                     NetAmount = a.NetAmount,
                                                     Others = a.Others,
                                                     PaymentOnCash = a.PaymentOnCash,
                                                     PaymentType = pa.Payments,
                                                     ReceiveDate = p.ReceiveDate,
                                                     ReceivedByID = p.ReceivedByID,
                                                     Remarks = p.Remarks,
                                                     Source = s.SourceName,
                                                     Transport = a.Transport,
                                                     TrDate = p.TrDate,
                                                     PurchaseNo = p.PurchaseNo,
                                                     Vendor = v.VendorName,
                                                     TotalAmount = a.TotalAmount // Total Product Cost



                                                 }).ToList();


            //model=  LoadMultySelectList(model) as PurchaseEditViewModel;

            return View(model);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {

            PurchaseEditViewModel output = new PurchaseEditViewModel();
            Purchase p = unitOfWork.Purchases.GetByID(id);
            if (p == null)
            {
                ViewBag.ErrorTitle = "Page Not Found 404";
                ViewBag.ErrorMessage = $"The Id { id } you Finding is not exist in database";
                return View("NotFound");

            }


            p.Branch = unitOfWork.Branchs.GetByID(p.BranchId);
            p.Vendor = unitOfWork.Vendors.GetByID(p.VendorId);
            p.Source = unitOfWork.Sources.GetByID(p.SourceId);
            Amount a = unitOfWork.Amounts.Get().Where(x => x.TrID == id && x.TrType == 1).FirstOrDefault();
            List<MasterDetail> masterdetails = unitOfWork.MasterDetails.Get().Where(x => x.AmountId == a.Id).ToList();


            if (masterdetails.Count > 0)
            {

                foreach (var m in masterdetails)
                {
                    m.Product = unitOfWork.Products.GetByID(m.ProductId);
                    Model model = unitOfWork.Models.GetByID(m.Product.ModelId);
                    Brand brand = unitOfWork.Brands.GetByID(model.BrandId);
                    Category category = unitOfWork.Categories.GetByID(brand.CategoryId);

                    PurchaseProductInfo purchaseProductInfo = new PurchaseProductInfo()
                    {
                        category = category.CType,
                        code = m.Product.Code,
                        color = m.Product.Color,
                        description = m.Product.Description,
                        model = model.ModelName,
                        photopath = m.Product.PhotoPath,
                        price = m.Price,
                        ProdId = m.Product.Id,
                        purchaseid = p.PurchaseID,
                        qty = m.Qty,
                        size = m.Product.Size
                    };
                    output.PurchaseProductInfos.Add(purchaseProductInfo);
                }
            }


            PaymentType pa = unitOfWork.PaymentTypes.GetByID(a.PaymentTypeId);
            if (p != null)
            {
                output.id = p.PurchaseID;
                output.Invoice = p.PurchaseNo;
                output.TrDate = p.TrDate;
                output.ReceiveDate = p.ReceiveDate;
                output.BranchId = p.Branch != null ? p.Branch.Id : 0;
                output.SourceId = p.Source != null ? p.Source.Id : 1;
                output.VendorId = p.Vendor != null ? p.Vendor.Id : 0;
                output.Remarks = p.Remarks;
            };

            //Cost amount Details
            if (a != null) //a == Amount Class
            {
                output.TotalAmount = a.TotalAmount;
                output.PaymentOnCash = a.PaymentOnCash;
                output.Dues = a.Dues;
                output.Transport = a.Transport;
                output.Others = a.Others;
                output.GrossAmount = a.GrossAmount;
                output.Discount = a.Discount;
                output.NetAmount = a.NetAmount;

            };

            //payment type
            if (pa != null)
            {
                output.PaymentTypeId = pa.Id;
            };



            output = LoadMultySelectList(output) as PurchaseEditViewModel;

            

            return View(output);

        }


        //load data from database by id for edit view
        List<PurchaseProductInfo> getoutput(int id)
        {
            PurchaseEditViewModel output = new PurchaseEditViewModel();

            Purchase p = unitOfWork.Purchases.GetByID(id);
            p.Branch = unitOfWork.Branchs.GetByID(p.BranchId);
            p.Vendor = unitOfWork.Vendors.GetByID(p.VendorId);
            p.Source = unitOfWork.Sources.GetByID(p.SourceId);
            Amount a = unitOfWork.Amounts.Get().Where(x => x.TrID == id && x.TrType == 1).FirstOrDefault();
            List<MasterDetail> masterdetails = unitOfWork.MasterDetails.Get().Where(x => x.AmountId == a.Id).ToList();


            if (masterdetails.Count > 0)
            {

                foreach (var m in masterdetails)
                {
                    m.Product = unitOfWork.Products.GetByID(m.ProductId);
                    Model model = unitOfWork.Models.GetByID(m.Product.ModelId);
                    Brand brand = unitOfWork.Brands.GetByID(model.BrandId);
                    Category category = unitOfWork.Categories.GetByID(brand.CategoryId);

                    PurchaseProductInfo purchaseProductInfo = new PurchaseProductInfo()
                    {
                        category = category.CType,
                        code = m.Product.Code,
                        color = m.Product.Color,
                        description = m.Product.Description,
                        model = model.ModelName,
                        photopath = m.Product.PhotoPath,
                        price = m.Price,
                        ProdId = m.Product.Id,
                        purchaseid = p.PurchaseID,
                        qty = m.Qty,
                        size = m.Product.Size
                    };
                    output.PurchaseProductInfos.Add(purchaseProductInfo);
                }
            }

            return output.PurchaseProductInfos;
        } 

        [HttpPost]
        public IActionResult Edit(PurchaseEditViewModel model)
        {

            if(ModelState.IsValid)
            {
                Purchase _p = unitOfWork.Purchases.Get().Where(x=>x.PurchaseNo.ToLower()== model.Invoice.ToLower()).FirstOrDefault();
                if(_p != null)
                {
                    if(_p.PurchaseID!=model.id && _p.PurchaseNo.ToLower()==model.Invoice.ToLower())
                    {
                        Global_Functions.SetMessage($"Purchase No You Enterd Is Already Exist Into Database", "danger");
                        model.PurchaseProductInfos = getoutput(model.id);
                        model = LoadMultySelectList(model) as PurchaseEditViewModel;
                        return View(model);
                    }

                    try { 
                    unitOfWork.BeginTransaction();
                        Purchase p = unitOfWork.Purchases.GetByID(model.id);

                        p.PurchaseID = model.id;
                        p.PurchaseNo = model.Invoice;
                        p.ReceiveDate = model.ReceiveDate;
                        p.TrDate = model.TrDate;
                        p.BranchId = model.BranchId;
                        p.VendorId = model.VendorId;
                        p.SourceId = model.SourceId;
                        
                        unitOfWork.Purchases.Update(p);

                        Amount amount = unitOfWork.Amounts.Get().Where(x => x.TrID == model.id && x.TrType == 1).FirstOrDefault();
                        amount.TotalAmount = model.TotalAmount;
                        amount.PaymentOnCash = model.PaymentOnCash;
                        amount.Dues = model.Dues;
                        amount.Transport = model.Transport;
                        amount.Others = model.Others;
                        amount.GrossAmount = model.GrossAmount;
                        amount.Discount = model.Discount;
                        amount.NetAmount = model.NetAmount;
                        amount.PaymentTypeId = model.PaymentTypeId;
                        unitOfWork.Amounts.Update(amount);
                        List<MasterDetail> masterdetails = unitOfWork.MasterDetails.Get().Where(x => x.AmountId==amount.Id ).ToList();

                        if (masterdetails.Count > 0)
                        {
                            foreach(MasterDetail m in masterdetails)
                            {
                                MasterDetail ms = unitOfWork.MasterDetails.Get().Where(x => x.DID == m.DID).FirstOrDefault();
                          

                                unitOfWork.MasterDetails.Delete(ms);
                            }
                            
                        }
                        if(model.ProductId.Count>0)
                        {
                            List<MasterDetail> masterDetailslist = new List<MasterDetail>();
                            for(int i=0;i<model.ProductId.Count;i++)
                            {
                                MasterDetail _ms = new MasterDetail()
                                {
                                    AmountId = amount.Id,
                                    ProductId = model.ProductId[i],
                                    Price = model.Price[i],
                                    Qty = model.Qty[i],

                                };
                                masterDetailslist.Add(_ms);
                            }

                            unitOfWork.MasterDetails.Insert(masterDetailslist);

                        }

                        unitOfWork.CommitTransaction();
                        Global_Functions.SetMessage("Purchase Update Successfully","success");
                        model = LoadMultySelectList(model) as PurchaseEditViewModel;

                        return View(model);
                    }
                    catch
                    {
                        unitOfWork.RollbackTransaction();
                    }

                }
            }
            model.PurchaseProductInfos = getoutput(model.id);
            model = LoadMultySelectList(model) as PurchaseEditViewModel;



            return View(model);
        }


        //Load Branch, Vendor, Source List from database to SelectedItemList
        private PurchaseCreateViewModel LoadMultySelectList(PurchaseCreateViewModel model)
        {
            model.BranchList = (from obj in unitOfWork.Branchs.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.Name,
                                    Value = obj.Id.ToString(),
                                    Selected=model.BranchId !=0?true :false
                                }).ToList();

            model.VendorList = (from obj in unitOfWork.Vendors.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.VendorName,
                                    Value = obj.Id.ToString(),
                                    Selected = model.VendorId != 0 ? true : false
                                }).ToList();
            model.SourceList = (from obj in unitOfWork.Sources.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.SourceName,
                                    Value = obj.Id.ToString(),
                                    Selected = model.SourceId != 0 ? true : false

                                }).ToList();

            model.PaymentTypeList = (from obj in unitOfWork.PaymentTypes.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.Payments,
                                    Value = obj.Id.ToString(),
                                    Selected = model.PaymentTypeId != 0 ? true : false

                                }).ToList();

            return model;
        }

        //call from prodcutlist View by ajax
        [HttpPost]
        public JsonResult ShowPurchaseDetails(int id)
        {


            PurchaseDetailsInfo output = new PurchaseDetailsInfo();

            Purchase p = unitOfWork.Purchases.GetByID(id);

        
            p.Branch = unitOfWork.Branchs.GetByID(p.BranchId);
            p.Vendor = unitOfWork.Vendors.GetByID(p.VendorId);
            p.Source = unitOfWork.Sources.GetByID(p.SourceId);
            Amount a = unitOfWork.Amounts.Get().Where(x => x.TrID == id && x.TrType == 1).FirstOrDefault();
            List<MasterDetail> masterdetails = unitOfWork.MasterDetails.Get().Where(x => x.AmountId == a.Id).ToList();


            if (masterdetails.Count > 0)
            {

                foreach (var m in masterdetails)
                {
                    m.Product = unitOfWork.Products.GetByID(m.ProductId);
                    Model model = unitOfWork.Models.GetByID(m.Product.ModelId);
                    Brand brand = unitOfWork.Brands.GetByID(model.BrandId);
                    Category category = unitOfWork.Categories.GetByID(brand.CategoryId);

                    PurchaseProductInfo purchaseProductInfo = new PurchaseProductInfo()
                    {
                        category = category.CType,
                        code = m.Product.Code,
                        color = m.Product.Color,
                        description = m.Product.Description,
                        model = model.ModelName,
                        photopath = m.Product.PhotoPath,
                        price = m.Price,
                        ProdId = m.Product.Id,
                        purchaseid = p.PurchaseID,
                        qty = m.Qty,
                        size = m.Product.Size
                    };
                    output.PurchaseProductInfos.Add(purchaseProductInfo);
                }
            }


            PaymentType pa = unitOfWork.PaymentTypes.GetByID(a.PaymentTypeId);
            if (p != null)
            {
                output.Purchaseno = p.PurchaseNo;
                output.TrDate = p.TrDate.ToShortDateString();
                output.ReceiveDate = p.ReceiveDate.ToShortDateString();
                output.Branch = p.Branch != null ? p.Branch.Name : "";
                output.Source = p.Source != null ? p.Source.SourceName : "";
                output.Vendor = p.Vendor != null ? p.Vendor.VendorName : "";
                output.Remarks = p.Remarks;
            };

            //Cost amount Details
            if (a != null) //a == Amount Class
            {
                output.TotalAmount = a.TotalAmount.ToString("#,##0");
                output.PaymentOnCash = a.PaymentOnCash.ToString("#,##0");
                output.Dues = a.Dues.ToString("#,##0");
                output.Transport = a.Transport.ToString("#,##0");
                output.Others = a.Others.ToString("#,##0");
                output.GrossAmount = a.GrossAmount.ToString("#,##0");
                output.Discount = a.Discount.ToString("#,##0");
                output.NetAmount = a.NetAmount.ToString("#,##0");

            };

            //payment type
            if (pa != null)
            {
                output.PaymentType = pa.Payments;
            };




            return new JsonResult(new { output});
        }
    }
}
