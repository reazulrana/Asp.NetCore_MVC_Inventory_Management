using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Vendors
{
    public class VendorListViewModel:BasePaginate
    {
        public List<VendorListModel> vendorListModels { get; set; } = new List<VendorListModel>();
        public override string ControllerName { get => "Vendor"; }
        public override string ActionName { get => "VendorList"; }

    }


    public class VendorListModel
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public bool IsSelected { get; set; }
    }
}
