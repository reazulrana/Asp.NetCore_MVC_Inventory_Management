using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels;
using BussinessAccessLayer.Model;

namespace InevntoryManagement.Controllers
{
    public class ManufactureController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ManufactureController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult ListManufactures()
        {
            var list = unitOfWork.Manufacture.Get();

            return View(list);
        }



        [HttpGet]
        public JsonResult LoadList()
        {
            var list = unitOfWork.Manufacture.Get();

            return Json(list);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ManufactureCreateViewModel model)
        {
        
            if(ModelState.IsValid)
            {
                Manufacture manufacture = new Manufacture()
                {
                    ManufactureName = model.ManufactureName
                };
                unitOfWork.Manufacture.Insert(manufacture);
                return RedirectToAction("ListManufactures","Manufacture");
            }
            



            return View();
        }




        //check for duplication Manufacture

        [AcceptVerbs("GET","POST")]
        public IActionResult IsManufactureExist(string ManufactureName)
        {
            if(!string.IsNullOrEmpty(ManufactureName))
            { 
            var result = unitOfWork.Manufacture.Get()
                        .Where(x =>   x.ManufactureName.ToLower() == ManufactureName.ToLower()).FirstOrDefault();
            if(result==null)
            {
               return Json(true);
            }
            else
            {
                return Json($" The Manufacture You Enter Is Duplicate{ManufactureName}");
            }
            }
            return Json(true);
        }



        [HttpGet]
        public IActionResult Edit()
        {



            var list = unitOfWork.Manufacture.Get();

            return View(list);

        }



        [HttpPost]
        public IActionResult Edit(ManufactureEditViewModel model)
        {



            if (ModelState.IsValid) 
            { 
            var manufacture = unitOfWork.Manufacture.GetByID(model.id);

                if(manufacture==null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = $"The Id {model.id} is not exist";
                    return View("NotFound");
                    //return Json(new { success = false });

                }


                manufacture.ManufactureName = model.ManufactureName;
                unitOfWork.Manufacture.Update(manufacture);
                return RedirectToAction("Edit");
                //return Json(new { success = true });


            }

            return View();




        }


        [HttpPost]
        public IActionResult Delete(ManufactureDeleteViewModel model)
        {

            if(ModelState.IsValid)
            {

                var deleteModel = unitOfWork.Manufacture.GetByID(model.id);

                if(deleteModel==null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = $"The Id {model.id} is not exist";
                    return View("NotFound");

                }

                unitOfWork.Manufacture.Delete(deleteModel);
                return RedirectToAction("Edit", "Manufacture");

            }
            return View();
        }

    }
}
