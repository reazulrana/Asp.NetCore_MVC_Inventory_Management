using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Sources;
using InevntoryManagement.GlobalFuntion;
namespace InevntoryManagement.Controllers
{
    public class SourceController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SourceController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetSourceList(int? pageno,int?pagesize)
        {

            SourceListViewModel output = new SourceListViewModel();

            output.sourceListModels = (from obj in unitOfWork.Sources.Get()
                          select new SourceListModel()
                          {
                              SourceId = obj.Id,
                              SourceName = obj.SourceName,
                               IsSelected=obj.IsSelected

                          }
                          ).OrderByDescending(x=>x.SourceName).ToList();

            output.TotalRow = output.sourceListModels.Count;
            output.PageSize = output.DefaultPageSize(pagesize);
            output.PageIndex = output.DefaultPageIndex(pageno);

            output.sourceListModels = output.sourceListModels.Skip(output.SkipRow).Take(output.PageSize).OrderBy(x => x.SourceName).ToList();


            return View(output);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(SourceCreateViewModel model)
        {


            if(ModelState.IsValid)
            {
                if (model.IsSelected)
                {
                    clear_Islected_Source(); // All IsSelected Field Value in Database Will be 0

                }
                Source source = new Source()
                {
                    SourceName = model.SourceName,
                     IsSelected=model.IsSelected
                     
                };
                unitOfWork.Sources.Insert(source);
                Global_Functions.SetMessage($"Source Is Created Successfully ( {model.SourceName} )", "success");

                return View(model);



            }

            return View();
        }


        //Search for duplicate Source 
        [AcceptVerbs("Get", "Post")]
        public IActionResult FindSource(string SourceName)
        {
            if (SourceName != null)
            {
                var source = unitOfWork.Sources.Get().Where(x => x.SourceName.ToLower() == SourceName.ToLower()).FirstOrDefault();
                if (source == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json($"The Source You Enter Is Duplicate ( {SourceName} )");
                }

            }
            return View();
        }


                //edit section

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var source = unitOfWork.Sources.GetByID(id);

            if(source != null)
            {
                SourceEditViewModel model = new SourceEditViewModel()
                {
                    Id = source.Id,
                    SourceName = source.SourceName,
                     IsSelected=source.IsSelected
                };
                return View(model);

            }
            else
            {
                ViewBag.ErrorTitle = "Source Not Found";
                ViewBag.ErrorMessage = $"Source Id ( {id} ) your searching is not Exist";
                return View("NotFound");
            }
    

        }


        [HttpPost]
        public IActionResult Edit(SourceEditViewModel updatemodel)
        {

            string oldSourceName = "";
            if (ModelState.IsValid) 
            {
                var source = unitOfWork.Sources.GetByID(updatemodel.Id);

                if (source != null)
                {

                    oldSourceName = source.SourceName;
                    if (updatemodel.IsSelected)
                    {
                        clear_Islected_Source(); // All IsSelected Field Value in Database Will be 0

                    }
                    source.SourceName = updatemodel.SourceName.ToUpper();
                    source.IsSelected = updatemodel.IsSelected;
                    unitOfWork.Sources.Update(source);
                    Global_Functions.SetMessage(message:$"Source Update Successfully from {oldSourceName} to {source.SourceName}",status:"success");

                    return RedirectToAction("GetSourceList");

                }
                else
                {
                    ViewBag.ErrorTitle = "Source Not Found";
                    ViewBag.ErrorMessage = $"Source Id ( {updatemodel.Id} ) your searching is not Exist";
                    return View("NotFound");
                }
            }


            return View();

        }
        // All IsSelected Field in source table Value in Database Will be 0
        private void clear_Islected_Source()
        {
            List<Source> sources = unitOfWork.Sources.Get().ToList();

            foreach(var source in sources )
            {
                var _source = unitOfWork.Sources.GetByID(source.Id);
                _source.IsSelected = false;
                unitOfWork.Sources.Update(_source);
            }


        }


        [HttpPost]
        public IActionResult Delete(int id)
        {


            if(ModelState.IsValid)
            {
                var deleteModel = unitOfWork.Sources.GetByID(id);

                if(deleteModel!=null)
                {
                    
                    
                    unitOfWork.Sources.Delete(deleteModel);
                    Global_Functions.SetMessage($"Source ( {deleteModel.SourceName} ) Is Deleted Successfully", "success");
                    return RedirectToAction("GetSourceList", "Source");
                        

                }

            }


            return View();

        }



        //call from Ajax from  product form
        [HttpPost]
        public JsonResult Create_Source_With_Ajax(string source,bool isselected)
        {
            string msg = "";

            bool success = false;
            Source output = new Source();
            try
            {

                var _source = unitOfWork.Sources.Get().Where(x => x.SourceName.ToLower() == source.ToLower()).FirstOrDefault();

                if(isselected)
                {
                    // All IsSelected Field in source table Value in Database Will be 0
                    clear_Islected_Source();
                }

                //Category Exist
                if (_source != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Source");

                }
                else
                {
                    output.SourceName = source.ToUpper();
                    output.IsSelected = isselected;

                    unitOfWork.Sources.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Source");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Source");
            }
            return new JsonResult(new { output, success, msg });


        }

    }
}
