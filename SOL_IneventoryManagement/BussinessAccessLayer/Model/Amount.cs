using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Amount
    {
        [Key]
        public int Id { get; set; }
        public int TrID { get; set; }
        public int TrType { get; set; }
        public int TotalAmount { get; set; }
        public int PaymentOnCash { get; set; }

        public int Dues { get; set; }
        public int Transport { get; set; }
        public int Others { get; set; }
        public int GrossAmount { get; set; }
        public int Discount { get; set; }
        public int NetAmount { get; set; }
        public int PaymentTypeId { get; set; }

        public virtual List<MasterDetail> MasterDetails { get; set; } = new List<MasterDetail>();

    }
}
