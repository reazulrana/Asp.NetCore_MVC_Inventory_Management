using DataAccessLayer.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InevntoryManagement.ViewModels.Settings;
using BussinessAccessLayer.Model;
using InevntoryManagement.GlobalFuntion;

namespace InevntoryManagement.Controllers
{
    public class SettingsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SettingsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult DefaultSettings()
        {
            DefaultSettingsViewModel model = new DefaultSettingsViewModel()
            {
                Branches = unitOfWork.Branchs.Get().ToList(),
                Colors = unitOfWork.Colors.Get().ToList(),
                Manufactures = unitOfWork.Manufactures.Get().ToList(),
                Measures = unitOfWork.Measures.Get().ToList(),
                PaymentTypes = unitOfWork.PaymentTypes.Get().ToList(),
                 SellFroms=unitOfWork.SellFroms.Get().ToList(),
                  SellingTypes=unitOfWork.SellingTypes.Get().ToList(),
                   Sizes=unitOfWork.Sizes.Get().ToList(),
                    Sources=unitOfWork.Sources.Get().ToList(),
                     Vendors=unitOfWork.Vendors.Get().ToList()
                                 };

            return View(model);
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


        //Branch 

        [HttpPost]
        public IActionResult SetDefaultBranch(int id)
        {

            //if No Branch Select From Branch Table
            if(id==0)
            {
                clear_IsSelected_Branch();
                Global_Functions.SetMessage($"Branch Update Successfully To No Branch", "success");
                return RedirectToAction("DefaultSettings");
            }

            var branch = unitOfWork.Branchs.GetByID(id);

            if(branch!=null)
            {
                clear_IsSelected_Branch();
                branch.IsSelected = true;

                unitOfWork.Branchs.Update(branch);
                Global_Functions.SetMessage("Branch Update Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Branch Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }


        //color section

        //Clear All IsSelected Field in Color Table From Database
        private void clear_IsSelected_Color()
        {
            List<Color> colors = unitOfWork.Colors.Get().ToList();

            foreach (var color in colors)
            {
                var _color = unitOfWork.Colors.GetByID(color.Id);
                _color.IsSelected = false;
                unitOfWork.Colors.Update(_color);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultColors(int id)
        {

            if(id==0)
            {
                clear_IsSelected_Color();

                Global_Functions.SetMessage($"Color Is Updated Successfully", "success");
                    return RedirectToAction("DefaultSettings");

            }

            var color = unitOfWork.Colors.GetByID(id);

            if (color != null)
            {
                clear_IsSelected_Color();
                color.IsSelected = true;

                unitOfWork.Colors.Update(color);
                Global_Functions.SetMessage("Color Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Color Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }



        //manufacture section


        //Clear All IsSelected Field in Manufacture Table From Database
        private void clear_IsSelected_Manufacture()
        {
            List<Manufacture> manufactures = unitOfWork.Manufactures.Get().ToList();

            foreach (var manufacture in manufactures)
            {
                var _manufacture = unitOfWork.Manufactures.GetByID(manufacture.Id);
                _manufacture.IsSelected = false;
                unitOfWork.Manufactures.Update(_manufacture);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultManufacture(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_Manufacture();
                Global_Functions.SetMessage($"Manufacture Is Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var Manufacture = unitOfWork.Manufactures.GetByID(id);

            if (Manufacture != null)
            {
                clear_IsSelected_Manufacture();
                Manufacture.IsSelected = true;

                unitOfWork.Manufactures.Update(Manufacture);
                Global_Functions.SetMessage("Manufacture Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Manufacture Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }


        //Measure Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_Measure()
        {
            List<Measure> measures= unitOfWork.Measures.Get().ToList();

            foreach (var measure in measures)
            {
                var _measure = unitOfWork.Measures.GetByID(measure.Id);
                _measure.IsSelected = false;
                unitOfWork.Measures.Update(_measure);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultMeasure(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_Measure();
                Global_Functions.SetMessage($"Measure Is Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var measure = unitOfWork.Measures.GetByID(id);

            if (measure != null)
            {
                clear_IsSelected_Measure();
                measure.IsSelected = true;

                unitOfWork.Measures.Update(measure);
                Global_Functions.SetMessage("Measure Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Measure Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }



        //PaymentType Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_PaymentType()
        {
            List<PaymentType> paymentTypes= unitOfWork.PaymentTypes.Get().ToList();

            foreach (var paymentType in paymentTypes)
            {
                var _paymentType = unitOfWork.PaymentTypes.GetByID(paymentType.Id);
                _paymentType.IsSelected = false;
                unitOfWork.PaymentTypes.Update(_paymentType);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultPaymentTypes(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_PaymentType();
                Global_Functions.SetMessage($"Payment Type Is Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var paymentType = unitOfWork.PaymentTypes.GetByID(id);

            if (paymentType != null)
            {
                clear_IsSelected_PaymentType();
                paymentType.IsSelected = true;

                unitOfWork.PaymentTypes.Update(paymentType);
                Global_Functions.SetMessage("Payment Type Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Payment Type Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }






        //SellFroms Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_SellFrom()
        {
            List<SellFrom> sellFroms = unitOfWork.SellFroms.Get().ToList();

            foreach (var sellFrom in sellFroms)
            {
                var _sellFrom = unitOfWork.SellFroms.GetByID(sellFrom.Id);
                _sellFrom.IsSelected = false;
                unitOfWork.SellFroms.Update(_sellFrom);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultSellFrom(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_SellFrom();
                Global_Functions.SetMessage($"Sell From Is Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var sellFrom = unitOfWork.SellFroms.GetByID(id);

            if (sellFrom != null)
            {
                clear_IsSelected_SellFrom();
                sellFrom.IsSelected = true;

                unitOfWork.SellFroms.Update(sellFrom);
                Global_Functions.SetMessage("Sell From Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Sell From Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }




        //SetDefaultSellingTypes Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_SellingType()
        {
            List<SellingType> sellingTypes = unitOfWork.SellingTypes.Get().ToList();

            foreach (var sellingType in sellingTypes)
            {
                var _sellingType = unitOfWork.SellingTypes.GetByID(sellingType.Id);
                _sellingType.IsSelected = false;
                unitOfWork.SellingTypes.Update(_sellingType);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultSellingTypes(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_SellingType();
                Global_Functions.SetMessage($"Selling Type Is Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var sellingType = unitOfWork.SellingTypes.GetByID(id);

            if (sellingType != null)
            {
                clear_IsSelected_SellingType();
                sellingType.IsSelected = true;

                unitOfWork.SellingTypes.Update(sellingType);
                Global_Functions.SetMessage("Selling Type Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Selling Type Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }







        //SetDefaultSizes Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_Sizes()
        {
            List<Size> sizes= unitOfWork.Sizes.Get().ToList();

            foreach (var size in sizes)
            {
                var _size = unitOfWork.Sizes.GetByID(size.Id);
                _size.IsSelected = false;
                unitOfWork.Sizes.Update(_size);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultSizes(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_Sizes();
                Global_Functions.SetMessage($"Size Is Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var size = unitOfWork.Sizes.GetByID(id);

            if (size != null)
            {
                clear_IsSelected_Sizes();
                size.IsSelected = true;

                unitOfWork.Sizes.Update(size);
                Global_Functions.SetMessage("Size Set Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Size Is Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }




        //SetDefaultSource Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_Source()
        {
            List<Source> sources  = unitOfWork.Sources.Get().ToList();

            foreach (var source in sources)
            {
                var _source = unitOfWork.Sources.GetByID(source.Id);
                _source.IsSelected = false;
                unitOfWork.Sources.Update(_source);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultSource(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_Source();
                Global_Functions.SetMessage($"Source Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var source = unitOfWork.Sources.GetByID(id);

            if (source != null)
            {
                clear_IsSelected_Source();
                source.IsSelected = true;

                unitOfWork.Sources.Update(source);
                Global_Functions.SetMessage("Source Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Source Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }



        //SetDefaultVendor Section
        //Clear All IsSelected Field in Measure Table From Database
        private void clear_IsSelected_Vendor()
        {
            List<Vendor> vendors = unitOfWork.Vendors.Get().ToList();

            foreach (var vendor in vendors)
            {
                var _vendor = unitOfWork.Vendors.GetByID(vendor.Id);
                _vendor.IsSelected = false;
                unitOfWork.Vendors.Update(_vendor);
            }

        }

        [HttpPost]
        public IActionResult SetDefaultVendor(int id)
        {

            if (id == 0)
            {
                clear_IsSelected_Vendor();
                Global_Functions.SetMessage($"Vendor Updated Successfully", "success");
                return RedirectToAction("DefaultSettings");
            }

            var vendor = unitOfWork.Vendors.GetByID(id);

            if (vendor != null)
            {
                clear_IsSelected_Vendor();
                vendor.IsSelected = true;

                unitOfWork.Vendors.Update(vendor);
                Global_Functions.SetMessage("Vendor Default Successfully", "success");
                return RedirectToAction("DefaultSettings");

            }
            else
            {
                Global_Functions.SetMessage($"Vendor Not Update Successfully Because Id Not Found in Database", "danger");
                return RedirectToAction("DefaultSettings");
            }

            //return RedirectToAction("DefaultSettings");

        }


    }
}
