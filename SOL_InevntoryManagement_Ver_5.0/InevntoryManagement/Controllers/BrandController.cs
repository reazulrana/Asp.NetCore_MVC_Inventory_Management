﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.ViewModels.Brands;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using BussinessAccessLayer.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.Models;
//using System.Web.WebPages.Html;
//using System.Web.Mvc;

namespace InevntoryManagement.Controllers
{
    public class BrandController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public BrandController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult Create()
        {


            var cat = unitOfWork.Categories.Get();
            var catList = (from obj in unitOfWork.Categories.Get()
                           select new SelectListItem()
                           {
                               Value = obj.Id.ToString(),
                               Text = obj.CType

                           }).ToList();
            BrandCreateViewModel model = new BrandCreateViewModel();
            model.Categories = catList;

            return View(model);
        }


        [HttpPost]
        public IActionResult Create(BrandCreateViewModel model)
        {

            var catList = (from obj in unitOfWork.Categories.Get()
                           select new SelectListItem()
                           {
                               Value = obj.Id.ToString(),
                               Text = obj.CType

                           }).ToList();

            model.Categories = catList;



            if (ModelState.IsValid)
            {

                if (model.cateid == -1)
                {
                    ModelState.AddModelError("", "Category Not Selected");
                    return View(model);
                }

                if (model.Brands.Count > 0)
                {

                    var brands = new List<Brand>();
                    foreach (string b in model.Brands)
                    {
                        var checkDupBrand = unitOfWork.Brands.Get().Where(x => x.CategoryId == model.cateid && x.BrandName.ToLower() == b.ToLower()).FirstOrDefault();
                        if (checkDupBrand == null)
                        {
                            var brand = new Brand()
                            {
                                CategoryId = (int)model.cateid,
                                BrandName = b.ToUpper()
                            };

                            brands.Add(brand);
                        }
                    }
                    unitOfWork.Brands.Insert(brands);
                    Global_Functions.SetMessage($"Brands List Created Successfully", "success");
                    return View(model);

                }

            }



      


            return View(model);
        }



        [HttpGet]
        //public IActionResult GetBrandList(int? pageno, int? pagesize)

        public IActionResult GetBrandList(BasePaginate _model)
        {
            BrandListViewModel output = new BrandListViewModel();
            output.brandLists = (from obj in unitOfWork.Categories.Get()
                          join obj2 in unitOfWork.Brands.Get()
                          on obj.Id equals obj2.CategoryId //into egroups
                         //from obj2 in egroups
                          orderby obj2.BrandName
                          //orderby obj.CType
                          select new BrandList
                          {

                              brandId = obj2.Id,
                              brandName = obj2.BrandName,
                              Ctype = obj.CType,
                              CategoryId = obj.Id

                          }).ToList();

            
            // Search Data from database and filter data
            if (_model.SearchText!=null)
            {
                string searchData = _model.SearchText.ToLower();
                output.brandLists = output.brandLists.Where(x => x.Ctype.ToLower().StartsWith(searchData) || x.brandName.ToLower().StartsWith(searchData)).ToList();
            }

            output.brandLists = output.brandLists.OrderByDescending(x =>  x.brandName).OrderByDescending(x=> x.Ctype).ToList();

            if (_model.Extension != fileextensions.none)
            {
                ExportData ed = new ExportData("BrandList", _model.Extension);
                ed.exportData<BrandList>(output.brandLists);
            }


            output.TotalRow = output.brandLists.Count;
            output.PageSize = output.DefaultPageSize(_model.PageSize);
            output.PageIndex = output.DefaultPageIndex(_model.PageIndex);
            output.SearchText = _model.SearchText;
            //output.PageSize = output.DefaultPageSize(pagesize);
            //output.PageIndex = output.DefaultPageIndex(pageno);

            output.brandLists = output.brandLists.Skip(output.SkipRow).Take(output.PageSize).OrderBy(x => x.brandName).OrderBy(x=>x.Ctype).ToList();


            return View(output);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var brand = (from c in unitOfWork.Categories.Get()
                         join b in unitOfWork.Brands.Get()
                         on c.Id equals b.CategoryId into cGropus
                         from b in cGropus     //cGropus.DefaultIfEmpty()
                         select new BrandEditViewModel
                         {
                             brandId = b.Id,
                             brandName = b.BrandName,
                             categoryId = b.CategoryId
                         }).ToList().Where(x => x.brandId == id).FirstOrDefault() as BrandEditViewModel;



            brand.Categories = (from obj in unitOfWork.Categories.Get()
                                select new SelectListItem()
                                {
                                    Text = obj.CType,
                                    Value = obj.Id.ToString(),
                                    Selected = obj.Id == brand.categoryId
                                }).ToList();


            return View(brand);

        }





        [HttpPost]
        public IActionResult Edit(BrandEditViewModel model)
        {



            if (ModelState.IsValid)
            {
                var updatebrand = unitOfWork.Brands.GetByID(model.brandId);

                if (updatebrand != null)
                {
                    updatebrand.CategoryId = model.categoryId;
                    updatebrand.BrandName = model.brandName.ToUpper();
                    unitOfWork.Brands.Update(updatebrand);
                    Global_Functions.SetMessage($"Brand Update { model.brandName } Successfully", "success");
                    return RedirectToAction("GetBrandList", "Brand");

                }
                else
                {
                    ViewBag.ErrorTitle = "Not Found Brand";
                    ViewBag.ErrorMessage = "The 'Brand' id you searched not exist in databases";
                    return View("NotFound");

                }



            }





            return View(model);

        }


        [HttpPost]
        public IActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                Brand deletebrand = unitOfWork.Brands.GetByID(id);
                if (deletebrand == null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = "Brand ID Now found in the database";
                    return View("NotFound");
                }
                else
                {
                    unitOfWork.Brands.Delete(deletebrand);
                    Global_Functions.SetMessage($"Brand Deleted { deletebrand.BrandName } Successfully", "success");

                    return RedirectToAction("GetBrandList", "Brand");
                }

            }

            return View();
        }




        public JsonResult findBrand(int id)
        {




            //var output = (from obj in unitOfWork.Categories.Get()
            //              select new Category
            //              {
            //                  CType = obj.CType,
            //                  Id = obj.Id,
            //                  Brands = unitOfWork.Brands.Get().Where(x => x.CategoryId == obj.Id).ToList()

            //              }).Where(c => c.Id == id).ToList();


            var output = unitOfWork.Brands.Get().Where(x => x.CategoryId == id).ToList();

            //string s = "Successfull";



            return new JsonResult(new { output });
        }

        //call Create Brand Method ffrom Jquery Ajax
        [HttpPost]
        public JsonResult Create_Brand_With_Ajax(int catid, string brandName)
        {

            bool success = true;
            string msg = "";
            Brand output = new Brand();
            if (catid != -1 && brandName != null)
            {
                try
                {
                    var result = unitOfWork.Brands.Get().Where(x => x.BrandName.ToLower() == brandName.ToLower() && x.CategoryId == catid).FirstOrDefault();

                    if (result != null)
                    {
                        success = false;
                        msg = Global_Functions.DuplicateErrorMessage("Brand");
                    }
                    else
                    {
                        output.BrandName = brandName.ToUpper();
                        output.CategoryId = catid;
                        unitOfWork.Brands.Insert(output);
                        msg = Global_Functions.SaveMessage("Brand");
                    };
                }
                catch
                {
                    msg = Global_Functions.SaveErrorMessage("Brand");
                    success = false;
                }

            }

            return new JsonResult(new { output, success, msg });
        }

    }
}
