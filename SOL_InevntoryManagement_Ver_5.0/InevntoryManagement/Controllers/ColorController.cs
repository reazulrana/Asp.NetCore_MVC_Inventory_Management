using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using InevntoryManagement.GlobalFuntion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.Controllers
{
    public class ColorController : Controller
    {


        private readonly IUnitOfWork unitOfWork;

        public ColorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        // Call From Jquery Ajax
        [HttpPost]
        public JsonResult Create_Category_With_Ajax(string colorname)
        {
            string msg = "";

            bool success = false;
            Color output = new Color();
            try
            {

                var color = unitOfWork.Colors.Get().Where(x => x.ColorName.ToLower() == colorname.ToLower()).FirstOrDefault();

                //Category Exist
                if (color != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Color");

                }
                else
                {
                    output.ColorName = colorname.ToUpper();

                    unitOfWork.Colors.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Color");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Color");
            }
            return new JsonResult(new { output, success, msg });


        }



    }
}
