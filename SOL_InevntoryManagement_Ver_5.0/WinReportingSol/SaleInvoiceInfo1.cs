//using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinReportingSol
{
    public class SaleInvoiceInfo1
    {
        public int SaleID { get; set; }
        public string Invoice { get; set; }
      //  public DateTime TrDate { get; set; }
        public int CustomerID { get; set; }

        public int UserID { get; set; }

        public string Remarks { get; set; }
        public int PaymentTypeId { get; set; }

        public string OrderNo { get; set; }
        public string SaleType { get; set; } //corporate
        public string SaleFrom { get; set; } // Online/Showroom

        public int BranchId { get; set; }

        public List<ProductInfo1> ProductInfos { get; set; } = new List<ProductInfo1>();
        public Amount1 amount { get; set; } = new Amount1();

    }
}
