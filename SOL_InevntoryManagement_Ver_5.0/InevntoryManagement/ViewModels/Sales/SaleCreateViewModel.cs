using BussinessAccessLayer.Model;
using InevntoryManagement.ViewModels.Purchase;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sales
{
    public class SaleCreateViewModel
    {
  
        [Required]
        public string Invoice { get; set; }

        [Required]
        [Display(Name ="Invoice Date")]
        public DateTime TrDate { get; set; }
        public int CustomerID { get; set; }

        [Required]
        [Display(Name ="Sell Type")]
        public string SaleType { get; set; } //corporate
        [Required]
        [Display(Name = "Sell Point")]
        public string SaleFrom { get; set; } // Online/Showroom

        [Display(Name = "Customer Name")]
        [Required]
        public string CustName { get; set; }
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }
        public int UserID { get; set; }
       
        [MaxLength(200, ErrorMessage = "Max Legth is 200 That You Have Excced")]
        public string Remarks { get; set; }
     
 

        [Required]
        [Display(Name ="Branch")]
        public int BranchId { get; set; }
        //public virtual Customer Customer { get; set; }
        //[MaxLength(30, ErrorMessage = "Max Legth is 30 That You Have Excced")]
        //public string OrderNo { get; set; }




        #region For MasterDetails
        public List<int> ProductIds { get; set; } = new List<int>();
        public List<string> Images { get; set; } = new List<string>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<string> Descriptions { get; set; } = new List<string>();
        public List<string> Models { get; set; } = new List<string>();
        public List<string> Sizes { get; set; } = new List<string>();
        public List<string> Colors { get; set; } = new List<string>();
        public List<int> Qtys { get; set; } = new List<int>();
        public List<int> Prices { get; set; } = new List<int>();
        #endregion
        #region PriceDetails
        [Display(Name = "Product Cost")]
        public int TotalAmount { get; set; }
        [Display(Name = "Due")]

        public int PaymentOnCash { get; set; }

        public int Dues { get; set; }
        [Display(Name = "Transport")]
        public int Transport { get; set; }
        public int Others { get; set; }
        [Display(Name = "Total Amount")]
        public int GrossAmount { get; set; }
        public int Discount { get; set; }
        [Display(Name = "Net Amount")]

        public int NetAmount { get; set; }
        
        [Display(Name = "Payment Type")]
        [Required]
        public int PaymentTypeId { get; set; }
        #endregion


        #region List Section
        public List<SelectListItem> BranchList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PaymentTypeList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SaleTypeList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SaleFromList { get; set; } = new List<SelectListItem>();
        
        public List<PurchaseProductInfo> PurchaseProductInfos { get; set; } = new List<PurchaseProductInfo>();



        #endregion
    }
}
