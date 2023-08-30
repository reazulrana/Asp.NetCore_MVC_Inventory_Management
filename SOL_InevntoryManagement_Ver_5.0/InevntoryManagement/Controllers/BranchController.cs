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

        //Clear All IsSelected Field in Branch Table From Database
        private void clear_IsSelected_Branch()
        {
            List<Branch> branchs = unitOfWork.Branchs.Get().ToList();

            foreach (var branch in branchs)
            {
                var _branch = unitOfWork.Branchs.GetByID(branch.Id);
                _branch.IsSelected = false;
                unitOfWork.Branchs.Update(_branch);
            }

        }

        // Call From Jquery Ajax
        [HttpPost]
        public JsonResult Create_Branch_With_Ajax(string branch, string contact, string incharge,bool isselected)
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
                    if(isselected)
                    {
                        clear_IsSelected_Branch(); //Clear All IsSelected Field in Branch Table From Database
                    }

                    output.Name = branch.ToUpper();

                    output.Contact = contact.ToUpper();
                    output.BranchIncharge = incharge.ToUpper();
                    output.IsSelected = isselected;
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



        // call with ajax function from Sale Form Branch List Table
        [HttpGet]
        public JsonResult GetAjaxBranchList()
        {
            var output = unitOfWork.Branchs.Get();


            return new JsonResult(new { output });
        }


        [HttpPost]
        public JsonResult BranchMakeDefault(string id)
        {
            int intid = int.Parse(id);
            var branch = unitOfWork.Branchs.GetByID(intid);
            string msg = "There Is Some Problem. You Cannot update the Record";
            if(branch!=null)
            {
                clear_IsSelected_Branch();
                branch.IsSelected = true;

                unitOfWork.Branchs.Update(branch);
                msg = "Record Update Successfully";
            }

            return new JsonResult(new { msg });
        }
        

    }
}
