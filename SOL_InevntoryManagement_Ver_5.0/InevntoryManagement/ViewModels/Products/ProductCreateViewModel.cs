using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Products
{
    public class ProductCreateViewModel
    {

        [Required]
        public string Code { get; set; }
        [Required]
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public int Brandid { get; set; }
        //public string ModelName { get; set; }

        [Required]
        [Display(Name ="Model")]
        public int ModelId { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Size { get; set; }
        public string SizeType { get; set; }
        [Required]
        [Display(Name ="Unit Price")]
        public int Unitprice { get; set; }


        [DefaultValue(0)]
        [Display(Name = "Dicount")]
        [Required]
        public int DiscountPrice { get; set; }

        [DefaultValue(0)]
        [Display(Name = "Opening Balance")]
        [Required]
        public int OpeningBalance { get; set; }
        [DefaultValue(0)]
        [Display(Name = "Opening Qty")]
        [Required]
        public int OpeningQty { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Vendor")]
        public string Vendor { get; set; }
        [Display(Name = "Manufacture")]
        public string Manufacture { get; set; }
        [Display(Name = "Bin")]

        public string Bin { get; set; }
        [Display(Name = "Photo")]

        public IFormFile Photo { get; set; }
        public string Remarks { get; set; }
        public string Measurement { get; set; }
        public string Source { get; set; }
        public int Pipeline { get; set; }
        public string ExistingPhotoPath { get; set; }



        [Display(Name ="Category")]
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Vendors { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Manufactures { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Bins { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Sizes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Colors { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Models { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Brands { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> Measurements { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Sources { get; set; } = new List<SelectListItem>();

    


    }
}
