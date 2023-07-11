﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;

using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Category;
using InevntoryManagement.GlobalFuntion;

namespace InevntoryManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(CategoryCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                Category category = new Category()
                {
                    CType = model.Ctype.ToUpper()
                };

                if (model.Brands.Any()) 
                { 
                foreach(string brand in model.Brands)
                    {

                        category.Brands.Add(new Brand() { BrandName = brand });
                    }
                }

                unitOfWork.Categories.Insert(category);

                }
            return View();
        }



        [HttpPost]
        public JsonResult Create_With_Ajax(string ctype)
        {

            bool success = false;
            Category output = new Category();
            try {
                output.CType = ctype.ToUpper();
                
                unitOfWork.Categories.Insert(output);
                success = true;
            }
            catch
            {
                success = false;
            }
            return new JsonResult(new { output, success });


        }




        [HttpGet]
        public IActionResult CategoryList()
        {

            var categories = unitOfWork.Categories.Get();


            return View(categories);
        }


        [AcceptVerbs("Get","Post")]
        public IActionResult Search_Category_Duplicate(string ctype)
        {
            if(!string.IsNullOrEmpty(ctype))
            {
                var result= unitOfWork.Categories.Get().Where(x => x.CType.ToLower() == ctype.ToLower()).FirstOrDefault();

                if(result==null)
                {
                    return Json(true);

                }
                else
                {
                    return Json($" The Category You Enter Is Duplicate '{ctype}'");


                }

            }

            return View();
        }



        [HttpPost]
        public IActionResult Edit(CategoryEditViewModel model)
        {
            if(ModelState.IsValid)
            {

                var result= unitOfWork.Categories.GetByID(model.ID);

                if (result != null)
                {
                    result.CType = model.Ctype;
                    unitOfWork.Categories.Update(result);
                    return RedirectToAction("CategoryList", "Category");
                }

                ViewBag.ErrorTitle = "Not Found";
                ViewBag.ErrorMessage = $"The Id ({model.ID}) is not found";
                return RedirectToAction("NotFound");



            }

            return View();
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {

            if(ModelState.IsValid)
            {
                var result = unitOfWork.Categories.GetByID(id);

                if(result==null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = ($"The Category Id {id} You Enterd id not Found ");
                    return View("NotFound");
                }
                else
                {
                    try { 

                        //if(model.DeleteBrand==true)
                        //{
                        //    var brands = unitOfWork.Brands.Get().Where(x => x.Id == model.ID).ToList();

                        //    //foreach(var brand in result.Brands)
                        //    //{
                        //      //  Brand b = unitOfWork.Brands.Get().Where(x => x.brdid == brand.brdid).FirstOrDefault();

                        //        unitOfWork.Brands.Delete(brands);

                        //    //};

                        //}

                    unitOfWork.Categories.Delete(result);
                        Global_Functions.SetMessage($"Category Deleted Succefully '{result.CType.ToUpper()}'", "success");
                    return RedirectToAction("CategoryList","Category");
                    }
                    catch(Exception ex)
                    {

                        

                        ViewBag.ErrorTitle = ($"{ex.HResult}");
                        ViewBag.ErrorMessage = ($"{ex.Message}");
                        return View("NotFound");
                    }



                }



            }


            return View();
        }

    }
}
