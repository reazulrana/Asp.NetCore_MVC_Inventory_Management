using BussinessAccessLayer.Model;
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
        public string Remarks { get; set; }
        #endregion

        #region For MasterDetails
        public List<int> ProductId { get; set; } = new List<int>();
        public List<int> Qty { get; set; }= new List<int>();
        public List<int> Price { get; set; }= new List<int>();
        #endregion

        public Amount amount { get; set; }

        #region List Section
        public List<Branch> BranchList { get; set; } = new List<Branch>();
        public List<Vendor> VendorList { get; set; } = new List<Vendor>();
        public List<Source> SourceList { get; set; } = new List<Source>();
        #endregion

    }
}
