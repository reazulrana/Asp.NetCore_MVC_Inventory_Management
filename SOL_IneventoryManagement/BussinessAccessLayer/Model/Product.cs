using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Product
    {
        public Product()
        {
            this.MasterDetails = new HashSet<MasterDetail>();
        }
        [Key]
        public int Id { get; set; }
        [MaxLength(35, ErrorMessage = "Max Legth is 35 That You Have Excced")]

        public string Code { get; set; }
        [MaxLength(120, ErrorMessage = "Max Legth is 120 That You Have Excced")]
        public string Description { get; set; }
        public int ModelId { get; set; } //using for relationship
        [MaxLength(25, ErrorMessage = "Max Legth is 25 That You Have Excced")]
        public string Color { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]
        public string Size { get; set; }
        [MaxLength(2, ErrorMessage = "Max Legth is 2 That You Have Excced")]
        public string SizeType { get; set; }
        public int Unitprice { get; set; }
        public int OpeningBalance { get; set; }
        public int OpeningQty { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]

        public string Vendor { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]

        public string Manufacture { get; set; }
        [MaxLength(10, ErrorMessage = "Max Legth is 10 That You Have Excced")]

        public string Bin { get; set; }
        public string PhotoPath { get; set; }
        [MaxLength(250, ErrorMessage = "Max Legth is 250 That You Have Excced")]
        public string Remarks { get; set; }
        public int DiscountPrice { get; set; }
        [MaxLength(10, ErrorMessage = "Max Legth is 10 That You Have Excced")]

        public string Measurement { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]

        public string Source { get; set; }
        public int Pipeline { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<MasterDetail> MasterDetails { get; set; }

    }
}
