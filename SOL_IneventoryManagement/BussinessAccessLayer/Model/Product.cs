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
        public string Code { get; set; }
        public string Description { get; set; }
        public int ModelId { get; set; } //using for relationship
        [DefaultValue(0)]
        public string Color { get; set; }
        public string Size { get; set; }
        public string SizeType { get; set; }
        [DefaultValue(0)]
        public int Unitprice { get; set; }
        [DefaultValue(0)]
        public int OpeningBalance { get; set; }
        [DefaultValue(0)]
        public int OpeningQty { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Vendor { get; set; }
        public string Manufacture { get; set; }
        public string Bin { get; set; }
        public string PhotoPath { get; set; }
        public string Remarks { get; set; }
        [DefaultValue(0)]
        public int DiscountPrice { get; set; }
        public string Measurement { get; set; }
        public string Source { get; set; }
        public int Pipeline { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<MasterDetail> MasterDetails { get; set; }

    }
}
