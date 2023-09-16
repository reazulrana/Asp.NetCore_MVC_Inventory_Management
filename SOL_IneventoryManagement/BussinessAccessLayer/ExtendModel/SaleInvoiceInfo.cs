using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.ExtendModel
{
    public class SaleInvoiceInfo
    {
        public int SaleID { get; set; }
        public string Invoice { get; set; }
       // public string TrDate { get; set; }
        public int CustomerID { get; set; }

        public int UserID { get; set; }

        public string Remarks { get; set; }
        public int PaymentTypeId { get; set; }

        public string OrderNo { get; set; }
        public string SaleType { get; set; } //corporate
        public string SaleFrom { get; set; } // Online/Showroom

        public int BranchId { get; set; }

        public List<ProductInfo> ProductInfos { get; set; } = new List<ProductInfo>();
        public Amount amount { get; set; } = new Amount();

    }
}
