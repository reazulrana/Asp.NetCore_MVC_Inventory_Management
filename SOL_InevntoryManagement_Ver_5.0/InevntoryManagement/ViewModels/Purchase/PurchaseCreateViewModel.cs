using BussinessAccessLayer.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Purchase
{
    public class PurchaseCreateViewModel
    {

        #region Purchase Information

        [Display(Name ="Purchase No.")]
        public string Invoice { get; set; }

        [Display(Name = "Purchase Date")]
        [Required]
        [DataType(dataType:DataType.Date)]
        public DateTime TrDate { get; set; }

        [Display(Name = "Receive Date")]
        [DataType(dataType: DataType.Date)]
        [Required]
        public DateTime ReceiveDate { get; set; }


        [Required]
        [Display(Name ="Branch")]
        public int BranchId { get; set; }


        [Display(Name = "Receive By")]
        public int ReceivedByID { get; set; }

        [Display(Name ="Vendor")]
        public int VendorId { get; set; }
        
        [Display(Name ="Source")]
        public int SourceId { get; set; }

        [MaxLength(200,ErrorMessage ="Max Length Character Is 200 Please Keep The Field Length Below 200 Character")]
        public string Remarks { get; set; }
        #endregion

        #region For MasterDetails
        public List<int> ProductIds { get; set; } = new List<int>();
        public List<string> Images { get; set; } = new List<string>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<string> Descriptions { get; set; } = new List<string>();
        public List<string> Models { get; set; } = new List<string>();
        public List<string> Sizes { get; set; } = new List<string>();
        public List<string> Colors { get; set; } = new List<string>();
        public List<int> Qtys { get; set; }= new List<int>();
        public List<int> Prices { get; set; }= new List<int>();
        #endregion

        #region PriceDetails
        [Display(Name ="Product Cost")]
        public int TotalAmount { get; set; }
        [Display(Name ="Due")]

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
        public int PaymentTypeId { get; set; }
        #endregion

        //public Amount amount { get; set; }

        #region List Section
        public List<SelectListItem> BranchList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VendorList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SourceList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PaymentTypeList { get; set; } = new List<SelectListItem>();
        public List<PurchaseProductInfo> PurchaseProductInfos { get; set; } = new List<PurchaseProductInfo>();


        #endregion

    }
}
