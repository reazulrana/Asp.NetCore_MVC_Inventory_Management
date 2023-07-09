using InevntoryManagement.ViewModels.Measures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.GlobalFuntion;

namespace InevntoryManagement.Controllers
{
    public class MeasureController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public MeasureController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MeasureCreateViewModel model)
        {

            if(ModelState.IsValid)
            {
                var measure = new Measure()
                {
                    Measurements = model.Measurements.ToUpper()
                };

                unitOfWork.Measures.Insert(measure);
                Global_Functions.SetMessage($"Measurement Create Successfully '{ measure.Measurements }'", "success");
                return View();

            }
            return View();
        }
    }
}
