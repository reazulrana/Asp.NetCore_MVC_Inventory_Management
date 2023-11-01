using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using InevntoryManagement.GlobalFuntion;
using InevntoryManagement.Models;

namespace InevntoryManagement.Controllers
{
    public class ModelController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        

        public ModelController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }

        [HttpGet]
        //[ResponseCache(Duration =30,Location =ResponseCacheLocation.Any,NoStore =false)]
        //[ResponseCache(Duration = 300, VaryByQueryKeys = new string[] { "pageno", "pagesize" })]
        //public IActionResult GetModelList(int? pageno, int? pagesize)

        public IActionResult GetModelList(BasePaginate _model)
        {

            ModelListViewModel output = new ModelListViewModel();
            output.modelLists = (from obj in unitOfWork.Categories.Get()
                          join obj2 in unitOfWork.Brands.Get()

                          on obj.Id equals obj2.CategoryId
                          join obj3 in unitOfWork.Models.Get()
                          
                          on obj2.Id equals obj3.BrandId  into egroups
                          
                          from obj3 in egroups
                          orderby obj3.ModelName
                          orderby obj.CType ascending
                          orderby obj2.BrandName ascending
                          

                          select new ModelList
                          {
                              ModelId = obj3.Id,
                              CategoryName = obj.CType,
                              BrandName = obj2.BrandName,
                              ModelName =obj3.ModelName 
                          }).ToList();
            //ViewBag.message = TempData["message"];
            //ViewBag.msgcolor = TempData["msgcolor"];
            //.OrderByDescending(x=>x.ModelName)

            //Search Section
            if (_model.SearchText != null)
            {
                string searchData = _model.SearchText.ToLower();

                output.modelLists = output.modelLists.Where(x =>x.CategoryName !=null && x.CategoryName.ToLower().StartsWith(searchData) || x.BrandName !=null &&  x.BrandName.ToLower().StartsWith(searchData) || x.ModelName!=null && x.ModelName.ToLower().StartsWith(searchData)).ToList();
            }
            output.modelLists = output.modelLists.OrderByDescending(x => x.ModelName).ToList();

            output.TotalRow = output.modelLists.Count;
            output.PageSize = output.DefaultPageSize(_model.PageSize);
            output.PageIndex = output.DefaultPageIndex(_model.PageIndex);
            output.SearchText = _model.SearchText;

            if (_model.Extension != fileextensions.none)
            {
                ExportData ed = new ExportData("ModelList", _model.Extension);
                ed.exportData<ModelList>(output.modelLists);

            }
            output.modelLists = output.modelLists.Skip(output.SkipRow).Take(output.PageSize).OrderBy(x => x.ModelName).ToList();
            return View(output);
        }



        [HttpGet]
        public IActionResult Create()
        {

            ModelCreateViewModel model = new ModelCreateViewModel();

            model.Categories = (from obj in unitOfWork.Categories.Get()
                                select new SelectListItem
                                {
                                    Value = obj.Id.ToString(),
                                    Text = obj.CType


                                }).ToList();



            return View(model);
        }



        [HttpPost]
        public IActionResult Create(ModelCreateViewModel model)
        {



            model.Categories = (from obj in unitOfWork.Categories.Get()
                                select new SelectListItem
                                {
                                    Value = obj.Id.ToString(),
                                    Text = obj.CType


                                }).ToList();


            if (ModelState.IsValid)
            {

                if(model.Models!=null && model.Models.Count>0)
                {
                    int brandId = model.brandId;
                                      
                    List<Model> _models = new List<Model>();

                    foreach (string modelname in model.Models)
                {
                        
                        var _model = unitOfWork.Models.Get().Where(x => x.BrandId == brandId && x.ModelName.ToLower() == modelname.ToLower()).FirstOrDefault();

                        if(_model==null)
                        {
                            Model _addmodel = new Model()
                            {
                                BrandId = brandId,
                                ModelName = modelname
                            };
                            _models.Add(_addmodel);
                        }

      
                        }


                    if (_models.Count > 0) 
                    { 
                    unitOfWork.Models.Insert(_models);
                        Global_Functions.SetMessage("Model Created Successfully", "success");
                    return RedirectToAction("GetModelList", "Model");

                    }
               




                }

            }
        



            return View(model);

        }



        [HttpGet]
        public IActionResult Edit(int id)
        {


            
            
            
            ModelEditViewModel modelEditViewModel = new ModelEditViewModel();
             var model = unitOfWork.Models.GetByID(id);

            modelEditViewModel.ModelId = model.Id;
            modelEditViewModel.brandId = model.BrandId;
            modelEditViewModel.ModelName = model.ModelName;

            modelEditViewModel = (ModelEditViewModel)LoadCategoryBrand(modelEditViewModel);

            //var model = (from obj in unitOfWork.Categories.Get()
            //             join obj2 in unitOfWork.Brands.Get()
            //             on obj.Id equals obj2.CategoryId
            //             join obj3 in unitOfWork.Models.Get()
            //             on obj2.Id equals obj3.BrandId into egroup
            //             from obj3 in egroup
            //             select new ModelEditViewModel
            //             {
            //                 ModelId=obj3.Id,
            //                 ModelName=obj3.ModelName,
            //               ();  CategoryName=obj.CType,
            //                 BrandId=obj2.Id,
            //                 BrandName=obj2.BrandName

            //             }).ToList().Where(x=>x.ModelId==id).FirstOrDefault


            return View(modelEditViewModel);

        }



        private ModelCreateViewModel LoadCategoryBrand(ModelEditViewModel model)
        {

            var _model = unitOfWork.Models.GetByID(model.ModelId);
            var _brand = unitOfWork.Brands.GetByID(_model.BrandId);
            var _category = unitOfWork.Categories.GetByID(_brand.CategoryId);


            model.Categories = (from cat in unitOfWork.Categories.Get()
                                                orderby cat.CType
                                             select new SelectListItem()
                                             {
                                                 Text = cat.CType,
                                                 Value = cat.Id.ToString(),
                                                 Selected = _category.Id != 0 ? _category.Id == cat.Id : false
                                             }).ToList();

            model.Brands = (from brand in unitOfWork.Brands.Get().Where(x=>x.CategoryId==_category.Id)
                                            orderby brand.BrandName
                                         select new SelectListItem()
                                         {
                                             Text = brand.BrandName,
                                             Value = brand.Id.ToString(),
                                             Selected = _brand.Id != 0 ? _brand.Id == brand.Id : false
                                         }).ToList();

            model.categoryid = _category.Id;
            model.brandId = _brand.Id;

            return model;
        }



        [HttpPost]
        public IActionResult Edit(ModelEditViewModel model)
        {



            if(ModelState.IsValid)
            {

                Model _model = unitOfWork.Models.GetByID(model.ModelId);

                if (_model == null)
                {
                    
                    ViewBag.ErrorTitle = "Model Not Found";

                    ViewBag.ErrorMessage = ($"Model Id {model.ModelId} you enterd is not found");
                    return View("NotFound");
                }
                 else
                    {
                    //    //Check Update Model Name Is Matched with Old Model Name ?

                    if (_model.ModelName.ToLower()==model.ModelName.ToLower())
                    {
                        return RedirectToAction("GetModelList", "Model");             
                    }
                    var _checkModelExist = unitOfWork.Models.Get().Where(x => x.ModelName.ToLower() == model.ModelName.ToLower() && x.BrandId == model.brandId).FirstOrDefault();

                    if(_checkModelExist==null)
                    {

                        _model.ModelName = model.ModelName;
                        unitOfWork.Models.Update(_model);

                        Global_Functions.SetMessage($"Model Update Successfully", "success");
                        //HttpContext.Session.SetString("message", );
                        //HttpContext.Session.SetString("status", "success");

                        return RedirectToAction("GetModelList", "Model");
                    }
                    else
                    {

                        Global_Functions.SetMessage($"You Cannot Update Because This Model ( Name: {model.ModelName} ) Already Exist Into Database", "danger");
                        //HttpContext.Session.SetString("message", $"You Cannot Update Because This Model ( Name: {model.ModelName} ) Already Exist Into Database");
                        //HttpContext.Session.SetString("status", "danger");
                        return View(model);
                    }

                    }
                //else
                //{

                //    //Check Update Model Name Is Matched with Old Model Name ?
                //    if (model.ModelName.ToLower() != _checkModelExist.ModelName.ToLower())
                //    {
                //        ViewBag.Message = $"You Cannot Update Because This Model ( Name: {model.ModelName} ) Already Exist Into Database";
                //        return View(model);
                //    }
                //        return RedirectToAction("GetModelList", "Model");

                //}
            }
            return View(model);

        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = unitOfWork.Models.GetByID(id);

            if(model==null)
            {
                ViewBag.ErrorTitle = "Model Not Found";
                ViewBag.ErrorMessage = ($"The Id {id} You Want to Delete Is Invalid");
                return View("NotFound");

            }
            else
            {
                unitOfWork.Models.Delete(model);

                Global_Functions.SetMessage($"Record Is Delteed From Model (Id: {model.Id} name: {model.ModelName})", "status");
                //HttpContext.Session.SetString("message", $"Record Is Delteed From Model (Id: {model.Id} name: {model.ModelName})");
                //HttpContext.Session.SetString("tcolor", $"Record Is Delteed From Model (Id: {model.Id} name: {model.ModelName})");
                
                return RedirectToAction("GetModelList", "Model");
            }

        }



        //get Brand List by category id
        [HttpGet]
        public IActionResult LoadBrandByCategoryid(int id)
        {


            var output = unitOfWork.Brands.Get().Where(x => x.CategoryId == id).ToList();
            bool message = true;

            if (output == null)
            {
                message = false;
            }


            return Json(new { output, message });
        }



        //get Model List by Brand id
        [HttpGet]
        public IActionResult LoadModelByBrandid(int id)
        {


            var output = unitOfWork.Models.Get().Where(x => x.BrandId == id).ToList();
            bool message = true;

            if (output == null || output.Count<=0)
            {
                message = false;
            }


            return Json(new { output, message });
        }



        //call Create Model Method from Jquery Ajax
        [HttpPost]
        public JsonResult Create_Model_With_Ajax(int brandid, string modelName)
        {

            bool success = true;
            string msg = "";
            Model output = new Model();
            if (brandid != -1 && modelName != null)
            {
                try
                {
                    var result = unitOfWork.Models.Get().Where(x => x.ModelName.ToLower() == modelName.ToLower() && x.BrandId == brandid).FirstOrDefault();

                    if (result != null)
                    {
                        success = false;
                        msg = Global_Functions.DuplicateErrorMessage("Model");
                    }
                    else
                    {
                        output.ModelName = modelName.ToUpper();
                        output.BrandId = brandid;
                        unitOfWork.Models.Insert(output);
                        msg = Global_Functions.SaveMessage("Model");
                    };
                }
                catch
                {
                    msg = Global_Functions.SaveErrorMessage("Model");
                    success = false;
                }

            }

            return new JsonResult(new { output, success, msg });
        }


        //public IActionResult ErrorMessage()
        //{

        //    return PartialView("_ErrorMessage");
        //}

    }
}
