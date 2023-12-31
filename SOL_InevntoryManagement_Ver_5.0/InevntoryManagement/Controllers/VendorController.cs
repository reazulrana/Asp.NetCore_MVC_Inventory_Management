﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.ViewModels.Vendors;
namespace InevntoryManagement.Controllers
{
    public class VendorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public VendorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public IActionResult VendorPanel(string vendor)
        {


            return View();
        }
        public IActionResult VendorList(int?pageno,int?pagesize)
        {
            VendorListViewModel output = new VendorListViewModel();
            output.vendorListModels = (from obj in unitOfWork.Vendors.Get()
                                                              select new VendorListModel()
                                                              {
                                                                  VendorId = obj.Id,
                                                                  VendorName = obj.VendorName,
                                                                  Address = obj.Address == null ? "No Address Available" : obj.Address,
                                                                  Contact = obj.Contact == null ? "No Contact Available" : obj.Contact
                                                              }).OrderByDescending(x=>x.VendorName).ToList();
            output.TotalRow = output.vendorListModels.Count();
            output.PageSize = output.DefaultPageSize(pagesize);
            output.PageIndex = output.DefaultPageIndex(pageno);


            output.vendorListModels = output.vendorListModels.Skip(output.SkipRow).Take(output.PageSize).OrderBy(x => x.VendorName).ToList();

            return View(output);
        }


        //Create Section

        [HttpGet]
        public IActionResult Create()
        {



            return View();
        }




        [HttpPost]
        public IActionResult Create(VendorCreateViewModel model)
        {

            if(ModelState.IsValid)
            {
                if (model.IsSelected)
                {
                    clear_IsSelected_Vendor(); //Clear All IsSelected Field in Size Table From Database
                }

                Vendor _vendor = new Vendor()
                {
                    VendorName = model.VendorName.ToUpper(),
                    Address = model.Address,
                    Contact = model.Contact,
                     IsSelected=model.IsSelected

                };
                unitOfWork.Vendors.Insert(_vendor);

                Global_Functions.SetMessage($"Vendor {_vendor.VendorName } Is Created Successfully", "success");
                return View();



            }


            return View();
        }



        //Edit Section 
        [HttpGet]
        public IActionResult Edit(int id)
        {


                Vendor vendor = unitOfWork.Vendors.GetByID(id);
                if(vendor==null)
                {
                    ViewBag.ErrorTile = "Vendor Page Not Found";
                    ViewBag.ErrorMessage = $"Vendor Id {id} You Enterd Is Not Found Not Found";
                    return View("NotFound");
            }


            VendorEditViewModel _vendoreditmodel = new VendorEditViewModel()
            {
                VendorId = vendor.Id,
                VendorName = vendor.VendorName,
                Address = vendor.Address,
                Contact = vendor.Contact,
                 IsSelected=vendor.IsSelected
                 
            }; 
             

         

            return View(_vendoreditmodel);

        }



        //Edit Section 
        [HttpPost]
        public IActionResult Edit(VendorEditViewModel model)
        {


            if (ModelState.IsValid)
            {


                Vendor vendor = unitOfWork.Vendors.GetByID(model.VendorId);
                string oldVendrName = vendor.VendorName.ToUpper();
                if (vendor == null)
                {
                    ViewBag.ErrorTile = "Vendor Page Not Found";
                    ViewBag.ErrorMessage = $"Vendor Id {model.VendorId} You Enterd Is Not Found Not Found";
                    return View("NotFound");
                }

                if(model.IsSelected)
                {
                    clear_IsSelected_Vendor(); //Clear All IsSelected Field in Size Table From Database
                }


                vendor.VendorName = model.VendorName.ToUpper();
                    vendor.Address = model.Address;
                vendor.Contact = model.Contact;
                vendor.IsSelected = model.IsSelected;
                unitOfWork.Vendors.Update(vendor);
                Global_Functions.SetMessage($"Vendor Update Successfully Previous Name {oldVendrName} to Current Name {vendor.VendorName}", "success");
                return RedirectToAction("VendorList","Vendor");

            }

                                    return View();

        }



        //Clear All IsSelected Field in Vendor Table From Database
        private void clear_IsSelected_Vendor()
        {
            List<Size> sizes = unitOfWork.Sizes.Get().ToList();

            foreach (var size in sizes)
            {
                var _size = unitOfWork.Sizes.GetByID(size.Id);
                _size.IsSelected = false;
                unitOfWork.Sizes.Update(_size);
            }

        }



        //Edit Section 
        [HttpPost]
        public IActionResult Delete(int id)
        {


            if (ModelState.IsValid)
            {


                Vendor vendor = unitOfWork.Vendors.GetByID(id);
                string oldVendrName = vendor.VendorName.ToUpper();
                if (vendor == null)
                {
                    ViewBag.ErrorTile = "Vendor Page Not Found";
                    ViewBag.ErrorMessage = $"Vendor Id {id} You Enterd Is Not Found Not Found";
                    return View("NotFound");
                }


                unitOfWork.Vendors.Delete(vendor);
                Global_Functions.SetMessage($"Vendor Delete Successfully ( {vendor.VendorName} )", "success");
                return RedirectToAction("VendorList", "Vendor");

            }

            return View();

        }



        //find duplicate vendor
        [AcceptVerbs("Get", "Post")]
        public IActionResult FindVendor(string VendorName)
        {
            if (!string.IsNullOrEmpty(VendorName))
            {
                var result = unitOfWork.Vendors.Get().Where(x => x.VendorName.ToLower() == VendorName.ToLower()).FirstOrDefault();

                if (result == null)
                {
                    return Json(true);

                }
                else
                {
                    return Json($" The Vendor You Enter Is Duplicate{VendorName}");


                }

            }

            return View();
        }



        // Call from ajax 

        [HttpPost]
        public JsonResult Create_Vendor_With_Ajax(string vendor, string vendoraddress, string vendorcontact,bool isselected)
        {
            string msg = "";

            bool success = false;
            Vendor output = new Vendor();
            try
            {

                var _vendor = unitOfWork.Vendors.Get().Where(x => x.VendorName.ToLower() == vendor.ToLower()).FirstOrDefault();


                if(isselected)
                {
                    clear_IsSelected_Vendor(); //Clear All IsSelected Field in Vendor Table From Database
                }
                //Category Exist
                if (_vendor != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Vendor");

                }
                else
                {
                    output.VendorName = vendor.ToUpper();
                    output.Address = vendoraddress;
                    output.Contact = vendorcontact;
                    output.IsSelected = isselected;
                    unitOfWork.Vendors.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Vendor");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Vendor");
            }
            return new JsonResult(new { output, success, msg });


        }




    }
}
