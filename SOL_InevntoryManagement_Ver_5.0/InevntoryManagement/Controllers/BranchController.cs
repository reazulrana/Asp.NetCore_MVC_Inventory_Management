using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.GlobalFuntion;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.Controllers
{
    public class BranchController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public BranchController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }



        // Call From Jquery Ajax
        [HttpPost]
        public JsonResult Create_Branch_With_Ajax(string branch, string contact, string incharge)
        {
            string msg = "";

            bool success = false;
            Branch output = new Branch();
            try
            {

                var category = unitOfWork.Branchs.Get().Where(x => x.Name.ToLower() == branch.ToLower()).FirstOrDefault();

                //Category Exist
                if (category != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Branch");

                }
                else
                {
                    output.Name = branch.ToUpper();

                    output.Contact = contact.ToUpper();
                    output.BranchIncharge = incharge.ToUpper();

                    unitOfWork.Branchs.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Branch");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Branch");
            }
            return new JsonResult(new { output, success, msg });


        }



        // call with ajax function from Purchase Create form jquery 


    }
}
