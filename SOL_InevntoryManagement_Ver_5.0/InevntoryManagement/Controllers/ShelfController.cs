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
    public class ShelfController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ShelfController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }


        // Call from ajax 

        [HttpPost]
        public JsonResult Create_BinNo_With_Ajax(string binno)
        {
            string msg = "";

            bool success = false;
            Bin output = new Bin();
            try
            {

                var _bin = unitOfWork.Bins.Get().Where(x => x.BinNo.ToLower() == binno.ToLower()).FirstOrDefault();

                //Category Exist
                if (_bin != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Bin No ");

                }
                else
                {
                    output.BinNo = binno.ToUpper();


                    unitOfWork.Bins.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Bin No ");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Bin No ");
            }
            return new JsonResult(new { output, success, msg });


        }



    }
}
