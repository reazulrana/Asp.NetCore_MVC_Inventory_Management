using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Sales
{
    public class ShowSaLeInvoiceData
    {

        public string Invoice { get; set; }


        public DateTime TrDate { get; set; }
        //public int CustomerID { get; set; }


        public string SaleType { get; set; } //corporate

        public string SaleFrom { get; set; } // Online/Showroom


        public string CustName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int UserID { get; set; }

        public string Remarks { get; set; }



        public int BranchId { get; set; }
        //public virtual Customer Customer { get; set; }
        //[MaxLength(30, ErrorMessage = "Max Legth is 30 That You Have Excced")]
        //public string OrderNo { get; set; }




        #region For MasterDetails
        public List<int> ProductIds { get; set; } = new List<int>();
        public List<string> Images { get; set; } = new List<string>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<string> Descriptions { get; set; } = new List<string>();
        public List<string> Models { get; set; } = new List<string>();
        public List<string> Sizes { get; set; } = new List<string>();
        public List<string> Colors { get; set; } = new List<string>();
        public List<int> Qtys { get; set; } = new List<int>();
        public List<int> Prices { get; set; } = new List<int>();
        #endregion
        #region PriceDetails
        public int TotalAmount { get; set; }

        public int PaymentOnCash { get; set; }

        public int Dues { get; set; }
        public int Transport { get; set; }
        public int Others { get; set; }
        public int GrossAmount { get; set; }
        public int Discount { get; set; }

        public int NetAmount { get; set; }


        public int PaymentTypeId { get; set; }
        #endregion

    }
}
