using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]
        public string Invoice { get; set; }
        [Required]
        public DateTime TrDate { get; set; }
        public int CustomerID { get; set; }

        public int UserID { get; set; }
        [MaxLength(200, ErrorMessage = "Max Legth is 200 That You Have Excced")]

        public string Remarks { get; set; }
        public int PaymentTypeId { get; set; }
        [MaxLength(30, ErrorMessage = "Max Legth is 30 That You Have Excced")]

        public string OrderNo { get; set; }
        [MaxLength(30, ErrorMessage = "Max Legth is 30 That You Have Excced")]
        public int SaleType { get; set; } //corporate
        public int SaleFrom { get; set; } // Online/Showroom

        public int BranchId { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
