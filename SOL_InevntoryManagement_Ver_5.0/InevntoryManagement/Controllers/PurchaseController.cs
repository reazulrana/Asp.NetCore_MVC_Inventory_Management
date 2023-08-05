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

        public PurchaseController(IUnitOfWork unitOfWork )
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
                     BranchId=model.BranchId,
                     
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
                     Transport=model.Transport,
                      PaymentOnCash=model.PaymentOnCash,
                       
                      
                };
                unitOfWork.Amounts.Insert(_amount);

                List<MasterDetail> masterDetailslist = new List<MasterDetail>();
                for(int i = 0; i <= model.ProductId.Count - 1; i++)
                {
                    MasterDetail masterDetail = new MasterDetail()
                    {
                        AmountId = _amount.Id,
                        ProductId= model.ProductId[i],
                        Price =model.Price[i],
                        Qty = model.Qty[i],
                    };
                    masterDetailslist.Add(masterDetail);

                }
                unitOfWork.CommitTransaction();

                unitOfWork.MasterDetails.Insert(masterDetailslist);
                Global_Functions.SetMessage($"Purchase Create Purchase ID( {_purchase.PurchaseID.ToString()} )", "success");
                return RedirectToAction("Create","Purchase");
                }
                catch(Exception ex)
                {
                    unitOfWork.RollbackTransaction();
                }





            }


            return View(model);
        }




        //Load Branch, Vendor, Source List from database to SelectedItemList
        private PurchaseCreateViewModel LoadMultySelectList(PurchaseCreateViewModel model)
        {
            model.BranchList = (from obj in unitOfWork.Branchs.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.Name,
                                    Value = obj.Id.ToString()
                                }).ToList();

            model.VendorList = (from obj in unitOfWork.Vendors.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.VendorName,
                                    Value = obj.Id.ToString()
                                }).ToList();
            model.SourceList = (from obj in unitOfWork.Sources.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.SourceName,
                                    Value = obj.Id.ToString()
                                }).ToList();

            model.PaymentTypeList = (from obj in unitOfWork.PaymentTypes.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.Payments,
                                    Value = obj.Id.ToString()
                                }).ToList();

            return model;
        }

    }
}
