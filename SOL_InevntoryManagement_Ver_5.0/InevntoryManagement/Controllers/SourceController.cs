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
        public IActionResult GetSourceList()
        {
            var sorces = (from obj in unitOfWork.Sources.Get()
                          select new SourceListViewModel()
                          {
                              SourceId = obj.Id,
                              SourceName = obj.SourceName
                          }
                          ).ToList();
                         

            return View(sorces);
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

                Source source = new Source()
                {
                    SourceName = model.SourceName
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
                    SourceName = source.SourceName

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

                    source.SourceName = updatemodel.SourceName.ToUpper();

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
    }
}
