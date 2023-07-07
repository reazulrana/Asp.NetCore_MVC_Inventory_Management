using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Purchase
    {

        [Key]
        public int PurchaseID { get; set; }
        public string Invoice { get; set; }
        public DateTime TrDate { get; set; }
        public int VendorId { get; set; }
        public int SourceId { get; set; }
        public string Remarks { get; set; }
        
        [ForeignKey("TrID")]
        public virtual Master Master { get; set; }

        [ForeignKey("TrID")]
        public virtual Amount Amount { get; set; }
        public virtual Source Source { get; set; }
        public virtual Vendor Vendor { get; set; }


    }
}
