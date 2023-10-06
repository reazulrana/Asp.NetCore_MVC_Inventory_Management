using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Purchase
{
    public class PurchaseListViewModel:BasePaginate
    {
        public List<PurchaseDetailsModel> purchaseDetailsModel { get; set; } = new List<PurchaseDetailsModel>();


        public override string ControllerName { get ; set; } ="Purchase" ;
        public override string ActionName { get; set; } = "EditPurchaseList";

        public override void ChangeActionName(string actionname = null)
        {
            if(actionname!=null)
            {
                ActionName = actionname;
            }
        }

    }




    public class PurchaseDetailsModel
    {
        #region Purchase Information
        public int id { get; set; }

        public string PurchaseNo { get; set; }

        [DataType(dataType: DataType.Date)]
        public DateTime TrDate { get; set; }

        [DataType(dataType: DataType.Date)]
        public DateTime ReceiveDate { get; set; }


        public string Branch { get; set; }


        public int ReceivedByID { get; set; }

        public string Vendor { get; set; }

        public string Source { get; set; }

        public string Remarks { get; set; }
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
        public string PaymentType { get; set; }
        #endregion
    }
}
