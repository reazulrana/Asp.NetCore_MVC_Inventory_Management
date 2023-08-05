using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Purchase
    {

        [Key]
        public int PurchaseID { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]

        public string PurchaseNo { get; set; }
     
        [Required]
        [DataType(dataType: DataType.Date)]
        public DateTime TrDate { get; set; }
        [Required]
        [DataType(dataType: DataType.Date)]
        public DateTime ReceiveDate { get; set; }
        public int ReceivedByID { get; set; }
        public int VendorId { get; set; }
        public int SourceId { get; set; }
        [MaxLength(200, ErrorMessage = "Max Legth is 200 That You Have Excced")]

        public string Remarks { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Source Source { get; set; }
        public virtual Vendor Vendor { get; set; }


    }
}
