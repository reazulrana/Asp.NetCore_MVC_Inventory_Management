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
        public string Invoice { get; set; }
        public DateTime TrDate { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Remarks { get; set; }


        [ForeignKey("TrID")]
        public virtual Master Master { get; set; }

        [ForeignKey("TrID")]
        public virtual Amount Amount { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
