using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;

using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Category;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.Models;

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
            if (ModelState.IsValid)
            {
                Category category = new Category()
                {
                    CType = model.Ctype.ToUpper()
                };

                if (model.Brands.Any())
                {
                    foreach (string brand in model.Brands)
                    {

                        category.Brands.Add(new Brand() { BrandName = brand });
                    }
                }

                unitOfWork.Categories.Insert(category);
                Global_Functions.SetMessage($"Category {model.Ctype} Is Created Successfully", "danger");
                  return View();
            }
            else
            {
                Global_Functions.SetMessage($"Category {model.Ctype} Is Not Created Successfully", "danger");

            }

            return View();
        }


        // Call From Jquery Ajax
        [HttpPost]
        public JsonResult Create_Category_With_Ajax(string ctype)
        {
            string msg = "";

            bool success = false;
            Category output = new Category();
            try
            {

                var category = unitOfWork.Categories.Get().Where(x => x.CType.ToLower() == ctype.ToLower()).FirstOrDefault();

                //Category Exist
                if (category != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Category");

                }
                else { 
                output.CType = ctype.ToUpper();

                unitOfWork.Categories.Insert(output);
                success = true;
                msg = Global_Functions.SaveMessage("Category");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Category");
            }
            return new JsonResult(new { output, success,msg });


        }




        [HttpGet]
        //public IActionResult CategoryList(int? pageno, int? pagesize)

        public IActionResult CategoryList(BasePaginate _model)
        {


          
            CategoryListViewModel model = new CategoryListViewModel();
            model.categories = (from cat in unitOfWork.Categories.Get()
                              orderby cat.CType
                                
                                select new CategoryListModel()
                              {
                                    
                                   Id=cat.Id,
                                   CType=cat.CType
                              }
                              ).ToList();


            //search data from databse to filter
            
            //store searching data from search text  to search into database and filter from table
            string searchdata = _model.SearchText;
            if (searchdata != null)
            {
                model.categories = model.categories.Where(x => x.CType.ToLower().StartsWith(searchdata)).ToList();
            }
            
            model.categories = model.categories.OrderByDescending(x => x.CType).ToList();

            model.TotalRow = model.categories.Count();
            model.PageSize = model.DefaultPageSize(_model.PageSize);
            model.PageIndex = model.DefaultPageIndex(_model.PageIndex);
            model.SearchText = _model.SearchText;


            //export data
            if (_model.Extension != fileextensions.none)
            {
                string filename = "CategoryList";
                ExportData ed = new ExportData(filename, _model.Extension);
                ed.exportData<CategoryListModel>(model.categories);
            }


            //model.PageSize = model.DefaultPageSize(pagesize);
            //model.PageIndex = model.DefaultPageIndex(pageno);

            model.categories = model.categories.Skip(model.SkipRow).Take(model.PageSize).OrderBy(x => x.CType).ToList();

            return View(model);
        }




        [HttpGet]
        //public IActionResult EditCategoryList(int? pageno, int? pagesize)

        public IActionResult EditCategoryList(BasePaginate _model)
        {

            CategoryListViewModel model = new CategoryListViewModel();
            model.categories = (from cat in unitOfWork.Categories.Get()
                                                orderby cat.CType
                                                select new CategoryListModel()
                                                {
                                                    Id = cat.Id,
                                                    CType = cat.CType
                                                }
                              ).OrderByDescending(x => x.CType).ToList();

            //search data from databse to filter

            //store searching data from search text  to search into database and filter from table
            string searchdata = _model.SearchText;
            if (searchdata != null)
            {
                model.categories = model.categories.Where(x => x.CType.ToLower().StartsWith(searchdata)).ToList();
            }

            model.categories = model.categories.OrderByDescending(x => x.CType).ToList();

            model.TotalRow = model.categories.Count();
            model.PageSize = model.DefaultPageSize(_model.PageSize);
            model.PageIndex = model.DefaultPageIndex(_model.EndPageNo);

            //model.PageSize = model.DefaultPageSize(pagesize);
            //model.PageIndex = model.DefaultPageIndex(pageno);


            //export data
            if (_model.Extension != fileextensions.none)
            {
                string filename = "CategoryList";
                ExportData ed = new ExportData(filename, _model.Extension);
                ed.exportData<CategoryListModel>(model.categories);
            }

            model.categories = model.categories.Skip(model.SkipRow).Take(model.PageSize).OrderBy(x => x.CType).ToList();

            return View(model);
        }


        [AcceptVerbs("Get", "Post")]
        public IActionResult Search_Category_Duplicate(string ctype)
        {
            if (!string.IsNullOrEmpty(ctype))
            {
                var result = unitOfWork.Categories.Get().Where(x => x.CType.ToLower() == ctype.ToLower()).FirstOrDefault();

                if (result == null)
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
            if (ModelState.IsValid)
            {

                var result = unitOfWork.Categories.GetByID(model.ID);

                if (result != null)
                {
                    result.CType = model.Ctype;
                    unitOfWork.Categories.Update(result);
                    Global_Functions.SetMessage($"Category {model.Ctype} Is Updated Succesfully", "success");
                    return RedirectToAction("CategoryList", "Category");
                }

                ViewBag.ErrorTitle = "Not Found";
                ViewBag.ErrorMessage = $"The Id ({model.ID}) is not found";
                return RedirectToAction("NotFound");



            }
            Global_Functions.SetMessage($"Category {model.Ctype} Is Not Updated Succesfully", "danger");
            return View();
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                var result = unitOfWork.Categories.GetByID(id);

                if (result == null)
                {
                    ViewBag.ErrorTitle = "Not Found";
                    ViewBag.ErrorMessage = ($"The Category Id {id} You Enterd id not Found ");
                    return View("NotFound");
                }
                else
                {
                    try
                    {

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
                        return RedirectToAction("CategoryList", "Category");
                    }
                    catch (Exception ex)
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
