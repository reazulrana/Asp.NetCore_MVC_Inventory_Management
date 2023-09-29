using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Purchase
{
    public class PurchaseDetailsInfo
    {
        #region Purchase Information

        public string Purchaseno { get; set; }

        public string TrDate { get; set; }

        public string ReceiveDate { get; set; }


        public string Branch { get; set; }


        //public int ReceivedByID { get; set; }

        public string Vendor { get; set; }

        public string Source { get; set; }

        public string Remarks { get; set; }
        #endregion

        #region For MasterDetails
        public List<ProductInfo> PurchaseProductInfos { get; set; } = new List<ProductInfo>();
        #endregion

        #region PriceDetails
        public string TotalAmount { get; set; }

        public string PaymentOnCash { get; set; }

        public string Dues { get; set; }
        public string Transport { get; set; }
        public string Others { get; set; }
        public string GrossAmount { get; set; }
        public string Discount { get; set; }

        public string NetAmount { get; set; }
        public string PaymentType { get; set; }
        #endregion
    }
}
