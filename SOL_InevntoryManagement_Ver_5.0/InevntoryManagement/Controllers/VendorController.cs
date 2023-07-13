using System;
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
        public IActionResult VendorList()
        {
            List<VendorListViewModel> _VendorListViewModel = (from obj in unitOfWork.Vendors.Get()
                                                              select new VendorListViewModel()
                                                              {
                                                                  VendorId = obj.Id,
                                                                  VendorName = obj.VendorName,
                                                                  Address = obj.Address == null ? "No Address Available" : obj.Address,
                                                                  Contact = obj.Contact == null ? "No Contact Available" : obj.Contact
                                                              }).ToList();

            return View(_VendorListViewModel);
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

                Vendor _vendor = new Vendor()
                {
                    VendorName = model.VendorName.ToUpper(),
                    Address = model.Address,
                    Contact = model.Contact

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
                Contact = vendor.Contact
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



                vendor.VendorName = model.VendorName.ToUpper();
                    vendor.Address = model.Address;
                vendor.Contact = model.Contact;
                unitOfWork.Vendors.Update(vendor);
                Global_Functions.SetMessage($"Vendor Update Successfully Previous Name {oldVendrName} to Current Name {vendor.VendorName}", "success");
                return RedirectToAction("VendorList","Vendor");

            }

                                    return View();

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
        public JsonResult Create_Vendor_With_Ajax(string vendor, string vendoraddress, string vendorcontact)
        {
            string msg = "";

            bool success = false;
            Vendor output = new Vendor();
            try
            {

                var _vendor = unitOfWork.Vendors.Get().Where(x => x.VendorName.ToLower() == vendor.ToLower()).FirstOrDefault();

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
