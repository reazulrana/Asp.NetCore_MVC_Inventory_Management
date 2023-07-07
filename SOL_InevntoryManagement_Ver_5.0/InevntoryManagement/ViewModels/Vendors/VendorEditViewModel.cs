using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Vendors
{
    public class VendorEditViewModel:VendorCreateViewModel
    {

        [Required]
        public int VendorId { get; set; }

    }
}
