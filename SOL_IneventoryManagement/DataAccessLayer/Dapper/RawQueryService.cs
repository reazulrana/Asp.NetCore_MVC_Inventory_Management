using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper
{
   public class RawQueryService : IRawQueryService
    {
        public string GetSaletListQuery {
            get
            {
                string query = "select s.SaleID, s.Invoice,convert(nvarchar(50), s.TrDate,103) as TrDate, b.name as Branch,p.Payments as PaymentType,a.TotalAmount,a.PaymentOnCash,a.Dues,a.Transport,a.Others,a.Discount,a.NetAmount from sales s";
                query = query + " inner join Branchs b on s.BranchId = b.Id";
                query = query + " inner join PaymentTypes p on s.PaymentTypeId = p.Id";
                query = query + " inner join amounts a on s.SaleID = a.TrID where a.TrType = 2";
                return query;


            }
        }
    }
}
