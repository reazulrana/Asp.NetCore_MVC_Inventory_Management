using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using InevntoryManagement.ViewModels.Sales;
using Microsoft.AspNetCore.Mvc.Rendering;
using BussinessAccessLayer.Model;
using InevntoryManagement.GlobalFuntion;

namespace InevntoryManagement.Controllers
{
    public class SaleController : Controller
    {
        private readonly IUnitOfWork unitofWork;

        public SaleController(IUnitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Create()
        {
            SaleCreateViewModel model = new SaleCreateViewModel();
            model.BranchList = BranchList(model);
            model.SaleTypeList = SaleTypes(model);

            model.SaleFromList = SaleFroms(model);
            model.PaymentTypeList = PaymentTypeList(model);


            //int maxno = unitOfWork.Purchases.Get().Select(X=>X.PurchaseNo).Max(x => int.Parse(x.PurchaseNo.Substring(x.PurchaseNo.Length-(x.PurchaseNo.IndexOf("-")-1))));
            List<int> s = unitofWork.Sales.Get().Select(x => int.Parse(x.Invoice.Substring((x.Invoice.IndexOf("-") + 1)))).ToList();

            //List<int> sb= s as List<int>;

            string maxno = s.Count > 0 ? (s.Max() + 1).ToString() : "1";

            string day = DateTime.Today.Day.ToString().Length == 1 ? "0" + DateTime.Today.Day.ToString() : DateTime.Today.Day.ToString();
            string month = DateTime.Today.Month.ToString().Length == 1 ? "0" + DateTime.Today.Month.ToString() : DateTime.Today.Month.ToString(); ;
            string year = DateTime.Today.Year.ToString().Length >= 4 ? DateTime.Today.Year.ToString().Substring(2, 2) : DateTime.Today.Year.ToString();
            string fulldate = day + "/" + month + "/" + year.ToString();

            fulldate = fulldate + "-" + maxno;
            model.Invoice = fulldate;
            return View(model);
        }


        //Get All Branch From Database
        private List<SelectListItem> BranchList(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitofWork.Branchs.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Name,
                          Value = obj.Id.ToString(),
                          Selected = model.BranchId != 0 ? obj.Id == model.BranchId : false
                      }).ToList();

            return output;
        }



        //Get All SaleType From Database
        private List<SelectListItem> SaleTypes(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitofWork.SellingTypes.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Types!=null? obj.Types:null,
                          Value = obj.Id!=0? obj.Id.ToString():null,
                          Selected = model.SaleType!=null ? obj.Types.ToLower() == model.SaleType.ToLower() : false
                      }).ToList();

            return output;
        }




        //Get All SaleFrom From Database
        private List<SelectListItem> SaleFroms(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitofWork.SellFroms.Get()
                      select new SelectListItem()
                      {
                          Text = obj.SaleFrom != null ? obj.SaleFrom : null,
                          Value = obj.Id != 0 ? obj.Id.ToString() : null,
                          Selected = model.SaleFrom != null ? obj.SaleFrom.ToLower() == model.SaleFrom.ToLower() : false
                      }).ToList();

            return output;
        }




        //Get All PaymentTypes From Database
        private List<SelectListItem> PaymentTypeList(SaleCreateViewModel model)
        {
            List<SelectListItem> output = new List<SelectListItem>();
            output = (from obj in unitofWork.PaymentTypes.Get()
                      select new SelectListItem()
                      {
                          Text = obj.Payments != null ? obj.Payments : null,
                          Value = obj.Id != 0 ? obj.Id.ToString() : null,
                          Selected = model.PaymentTypeId != 0 ? obj.Id == model.PaymentTypeId : obj.Payments.ToUpper()=="Cash".ToUpper()
                      }).ToList();

            return output;
        }



        // Call from Sale form with ajax btnSaveSaleFrom

        [HttpPost]
        public JsonResult Create_SaleFrom_With_Ajax(string SaleFrom)
        {
            string msg = "";

            bool success = false;
            SellFrom output = new SellFrom();
            try
            {

                var _salefrom = unitofWork.SellFroms.Get().Where(x => x.SaleFrom.ToLower() == SaleFrom.ToLower()).FirstOrDefault();

                //Category Exist
                if (_salefrom != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Sale From");

                }
                else
                {
                    output.SaleFrom = SaleFrom.ToUpper();

                    unitofWork.SellFroms.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Sale From");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Sale From");
            }
            return new JsonResult(new { output, success, msg });


        }



        // Call from Sale form with ajax btnSaveSaleFrom

        [HttpPost]
        public JsonResult Create_SaleType_With_Ajax(string SaleType)
        {
            string msg = "";

            bool success = false;
            SellingType output = new SellingType();
            try
            {

                var _saletype = unitofWork.SellingTypes.Get().Where(x => x.Types.ToLower() == SaleType.ToLower()).FirstOrDefault();

                //SaleType Is Exist
                if (_saletype != null)
                {
                    success = false;
                    msg = Global_Functions.DuplicateErrorMessage("Sale Type");

                }
                else
                {
                    output.Types = SaleType.ToUpper();

                    unitofWork.SellingTypes.Insert(output);
                    success = true;
                    msg = Global_Functions.SaveMessage("Sale Type");
                }
            }
            catch
            {
                success = false;
                msg = Global_Functions.SaveErrorMessage("Sale Type");
            }
            return new JsonResult(new { output, success, msg });


        }

    }
}
