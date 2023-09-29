using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.ExtendModel
{
   public class SaleDetails
    {
        public int SaleID { get; set; }
        public string Invoice { get; set; }
        public string TrDate { get; set; }
        public string Branch { get; set; }
        public string PaymentType { get; set; }
        public int TotalAmount { get; set; }
        public int PaymentOnCash { get; set; }
        public int Dues { get; set; }
        public int Transport { get; set; }
        public int Others { get; set; }
        public int Discount { get; set; }
        public int NetAmount { get; set; }










    }
}
