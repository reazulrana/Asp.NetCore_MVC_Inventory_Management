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



        // Call From Jquery Ajax
        [HttpPost]
        public JsonResult Create_PaymentType_With_Ajax(string paymenttype)
        {
            string msg = "";

            bool success = false;
            PaymentType output = new PaymentType();
            try
            {

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

    }
}
