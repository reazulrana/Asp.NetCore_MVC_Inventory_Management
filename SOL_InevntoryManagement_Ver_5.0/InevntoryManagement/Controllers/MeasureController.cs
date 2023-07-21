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


        //call from Ajax from  product form
        [HttpPost]
        public JsonResult Create_Measure_With_Ajax(string measurement)
        {
            string msg = "";

            bool success = false;
            Measure output = new Measure();
            try
            {

                var _measurement = unitOfWork.Measures.Get().Where(x => x.Measurements.ToLower() == measurement.ToLower()).FirstOrDefault();

                //Measurement Exist
                if (_measurement != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Measurement");

                }
                else
                {
                    output.Measurements = measurement.ToUpper();

                    unitOfWork.Measures.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Measurement");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Measurement");
            }
            return new JsonResult(new { output, success, msg });


        }

    }
}
