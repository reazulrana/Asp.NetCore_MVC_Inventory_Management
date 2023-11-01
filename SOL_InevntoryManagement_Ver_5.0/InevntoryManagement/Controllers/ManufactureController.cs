using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels;
using BussinessAccessLayer.Model;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.ViewModels.Manufactures;
using InevntoryManagement.Models;

namespace InevntoryManagement.Controllers
{
    public class ManufactureController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public object ManufactureListViewModel { get; private set; }

        public ManufactureController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
//        public IActionResult ListManufactures(int? pageno, int? pagesize)
        public IActionResult ListManufactures(BasePaginate _model)

        {

            ManufactureListViewModel output = new ManufactureListViewModel();
            if (_model.SearchText != null)
            {
                string searchData = _model.SearchText.ToLower();
                output.manufactures = unitOfWork.Manufactures.Get().Where(x=>x.ManufactureName.ToLower()!=null && x.ManufactureName.ToLower().StartsWith(searchData)).OrderByDescending(x => x.ManufactureName).ToList();
            }
            else
            {
                output.manufactures = unitOfWork.Manufactures.Get().OrderByDescending(x => x.ManufactureName).ToList();

            }

            output.TotalRow = output.manufactures.Count;
            output.PageSize = output.DefaultPageSize(_model.PageSize);
            output.PageIndex = output.DefaultPageIndex(_model.PageIndex);
            output.SearchText = _model.SearchText;

            if (_model.Extension != fileextensions.none)
            {
                ExportData ed = new ExportData("ManufactureList", _model.Extension);
                ed.exportData<Manufacture>(output.manufactures);
            }


            output.manufactures = output.manufactures.Skip(output.SkipRow).Take(output.PageSize).OrderBy(x => x.ManufactureName).ToList();





            return View(output);
        }



        [HttpGet]
        public JsonResult LoadList()
        {
            var list = unitOfWork.Manufactures.Get();

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
                unitOfWork.Manufactures.Insert(manufacture);
                Global_Functions.SetMessage($"Manufacture { model.ManufactureName } Is Created Successfully", "success");

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
            var result = unitOfWork.Manufactures.Get()
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



            var list = unitOfWork.Manufactures.Get();

            return View(list);

        }



        [HttpPost]
        public IActionResult Edit(ManufactureEditViewModel model)
        {



            if (ModelState.IsValid) 
            { 
            var manufacture = unitOfWork.Manufactures.GetByID(model.id);

                if(manufacture==null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = $"The Id {model.id} is not exist";
                    return View("NotFound");
                    //return Json(new { success = false });

                }


                manufacture.ManufactureName = model.ManufactureName;
                unitOfWork.Manufactures.Update(manufacture);
                Global_Functions.SetMessage($"Manufacture { model.ManufactureName } Is Updated Successfully", "success");

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

                var deleteModel = unitOfWork.Manufactures.GetByID(model.id);

                if(deleteModel==null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = $"The Id {model.id} is not exist";
                    return View("NotFound");

                }

                unitOfWork.Manufactures.Delete(deleteModel);
                Global_Functions.SetMessage($"Manufacture { deleteModel.ManufactureName } Is Deleted Successfully", "success");

                return RedirectToAction("Edit", "Manufacture");

            }
            return View();
        }



        // Call from ajax 

        [HttpPost]
        public JsonResult Create_Manufacture_With_Ajax(string manufacturename)
        {
            string msg = "";

            bool success = false;
            Manufacture output = new Manufacture();
            try
            {

                var manufactures = unitOfWork.Manufactures.Get().Where(x => x.ManufactureName.ToLower() == manufacturename.ToLower()).FirstOrDefault();

                //Category Exist
                if (manufactures != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Manufactures");

                }
                else
                {
                    output.ManufactureName = manufacturename.ToUpper();
                    

                    unitOfWork.Manufactures.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Manufactures");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Manufactures");
            }
            return new JsonResult(new { output, success, msg });


        }



    }
}
