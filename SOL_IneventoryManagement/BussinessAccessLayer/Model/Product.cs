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
        public int ModelId { get; set; }
        [DefaultValue(0)]
        
        public string Color { get; set; }
        [DefaultValue(0)]
        
        public string Size { get; set; }
        [DefaultValue(0)]
        public string Dimension { get; set; }
        [DefaultValue(0)]
        public int Unitprice { get; set; }
        [DefaultValue(0)]
        public int OpeningBalance { get; set; }
        [DefaultValue(0)]
        public int OpeningQty { get; set; }
        public DateTime CreatedDate { get; set; }
        public int VendorId { get; set; }
        public int ManufactureId { get; set; }
        public int BinId { get; set; }
        public string PhotoPath { get; set; }
        public string Remarks { get; set; }
        [DefaultValue(0)]
        public int DiscountPrice { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Manufacture Manufacture { get; set; }
        public virtual Bin Bin { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<MasterDetail> MasterDetails { get; set; }

    }
}
