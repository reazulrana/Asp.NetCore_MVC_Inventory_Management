using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Settings
{
    public class DefaultSettingsViewModel
    {

        public List<Branch> Branches { get; set; } = new List<Branch>();
        public List<Color> Colors { get; set; } = new List<Color>();
        public List<Manufacture> Manufactures { get; set; } = new List<Manufacture>();
        public List<Measure> Measures { get; set; } = new List<Measure>();
        public List<PaymentType> PaymentTypes { get; set; } = new List<PaymentType>();
        public List<SellFrom> SellFroms { get; set; } = new List<SellFrom>();
        public List<SellingType> SellingTypes { get; set; } = new List<SellingType>();
        public List<Size> Sizes { get; set; } = new List<Size>();
        public List<Source> Sources { get; set; } = new List<Source>();
        public List<Vendor> Vendors { get; set; } = new List<Vendor>();



    }
}
