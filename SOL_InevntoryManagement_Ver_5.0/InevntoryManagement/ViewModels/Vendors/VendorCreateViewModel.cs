using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Vendors
{
    public class VendorCreateViewModel
    {

        [Required]
        [Display(Name ="Vendor Name")]
        [Remote("FindVendor","Vendor")]
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public bool IsSelected { get; set; }
    }
}
