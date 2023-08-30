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
    public class PaymentTypeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public PaymentTypeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }




        //Clear All IsSelected Field in Branch Table From Database
        private void clear_IsSelected_PaymentType()
        {
            List<PaymentType> paymentTypes = unitOfWork.PaymentTypes.Get().ToList();

            foreach (var paymentType in paymentTypes)
            {
                var _paymentType = unitOfWork.PaymentTypes.GetByID(paymentType.Id);
                _paymentType.IsSelected = false;
                unitOfWork.PaymentTypes.Update(_paymentType);
            }

        }

        // Call From Jquery Ajax
        [HttpPost]
        public JsonResult Create_PaymentType_With_Ajax(string paymenttype, bool isselected)
        {
            string msg = "";

            bool success = false;
            PaymentType output = new PaymentType();
            try
            {
                if(isselected)
                {
                    clear_IsSelected_PaymentType();//Clear All IsSelected Field in Branch Table From Database
                }

                var _paymenttype = unitOfWork.PaymentTypes.Get().Where(x => x.Payments.ToLower() == paymenttype.ToLower()).FirstOrDefault();

                //Category Exist
                if (_paymenttype != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Payment Type");

                }
                else
                {
                    output.Payments = paymenttype.ToUpper();
                    output.IsSelected = isselected;
                    unitOfWork.PaymentTypes.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Payment Type");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Payment Type");
            }
            return new JsonResult(new { output, success, msg });


        }


        // call with ajax function from Sale Form Branch List Table
        [HttpGet]
        public JsonResult GetAjaxPaymentTypeList()
        {
            var output = unitOfWork.Branchs.Get();


            return new JsonResult(new { output });
        }


        [HttpPost]
        public JsonResult PaymentTypeMakeDefault(string id)
        {
            int intid = int.Parse(id);
            var pt = unitOfWork.PaymentTypes.GetByID(intid);
            string msg = "There Is Some Problem. You Cannot update the Record";
            if (pt != null)
            {
                clear_IsSelected_PaymentType();
                pt.IsSelected = true;

                unitOfWork.PaymentTypes.Update(pt);
                msg = "Record Update Successfully";
            }

            return new JsonResult(new { msg });
        }
    }
}
