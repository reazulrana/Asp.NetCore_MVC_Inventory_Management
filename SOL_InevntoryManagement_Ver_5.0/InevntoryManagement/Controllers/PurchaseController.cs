using DataAccessLayer.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.ViewModels.Purchase;
using Microsoft.AspNetCore.Mvc.Rendering;

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
