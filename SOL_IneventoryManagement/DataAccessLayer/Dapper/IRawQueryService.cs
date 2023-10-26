using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper
{
    public interface IRawQueryService
    {


        public string GetSaletListQuery { get; }
        public string GetSaleProductInfoByIdQuery { get; }
        public string Get_Single_Product_Balance_By_ID_Query { get; }
        public string Get_Sale_Invoice_Details_Query { get; }
        public string Get_Sale_Invoice_Product_Details_Query { get; }

        

    }
}
