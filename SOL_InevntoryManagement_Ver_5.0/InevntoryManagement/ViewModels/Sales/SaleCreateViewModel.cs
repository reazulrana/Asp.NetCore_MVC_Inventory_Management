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
        //[Key]
        //public int SaleID { get; set; }

        //[MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]

        [Required]
        public string Invoice { get; set; }

        [Required]
        [Display(Name ="Invoice Date")]
        public DateTime TrDate { get; set; }
        public int CustomerID { get; set; }
        [Display(Name ="Customer Name")]
        [Required]
        public string CustName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int UserID { get; set; }
       
        [MaxLength(200, ErrorMessage = "Max Legth is 200 That You Have Excced")]
        public string Remarks { get; set; }
        [Required]
        public int PaymentTypeId { get; set; }
        //[MaxLength(30, ErrorMessage = "Max Legth is 30 That You Have Excced")]
        public string OrderNo { get; set; }
        //[MaxLength(30, ErrorMessage = "Max Legth is 30 That You Have Excced")]
        public string SaleType { get; set; }
        [Required]
        public int BranchId { get; set; }
        public virtual Customer Customer { get; set; }





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



        #region List Section
        public List<SelectListItem> BranchList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VendorList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SourceList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PaymentTypeList { get; set; } = new List<SelectListItem>();
        public List<PurchaseProductInfo> PurchaseProductInfos { get; set; } = new List<PurchaseProductInfo>();


        #endregion
    }
}
