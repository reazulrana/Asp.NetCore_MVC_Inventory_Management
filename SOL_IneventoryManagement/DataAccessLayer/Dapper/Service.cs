using BussinessAccessLayer.ExtendModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using BussinessAccessLayer.Model;

namespace DataAccessLayer.Dapper
{
    public class Service : IService
    {
        private readonly IConfiguration _config;
        private string connectionstring = "";
        public Service(IConfiguration config)
        {
            this._config = config;
            connectionstring = _config.GetConnectionString("DatabasDbConnection");
        }

        public List<SaleInvoiceInfo> GetAllInvoiceList 
        {
            get
            {
                List<SaleInvoiceInfo> output = new List<SaleInvoiceInfo>();

                return output;
            }
        }

        public SaleInvoiceInfo GetSaleInvoiceById(int id)
        {
            SaleInvoiceInfo output = new SaleInvoiceInfo();
            
            DynamicParameters param = new DynamicParameters();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                param.Add("@id", id, dbType: DbType.Int32);
                output = con.Query<SaleInvoiceInfo>("select * from Sales where SaleID=@id", param, commandType: CommandType.Text).FirstOrDefault();
            }

            output.amount = GetSaleAmountByTrID(output.SaleID);
            output.ProductInfos = GetSaleProductInfoById(output.SaleID);

            return output;
        }


        public Amount GetSaleAmountByTrID(int trid)
        {
            Amount output = new Amount();

            DynamicParameters param = new DynamicParameters();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                param.Add("@id", trid, dbType: DbType.Int32);
                
                output = con.Query<Amount>("select * from Amounts where trId=@id and TrType=2", param, commandType: CommandType.Text).FirstOrDefault();
            }
            return output;
        }

        public List<ProductInfo> GetSaleProductInfoById(int SaleId)
        {


            //public string code { get; set; }
            //public string description { get; set; }
            //public string category { get; set; }
            //public string model { get; set; }
            //public string size { get; set; }
            //public string color { get; set; }
            //public int qty { get; set; } = 0;
            //public int price { get; set; } = 0;
            //public int TotalPrice { get { return qty * price; } }
          
                List<ProductInfo> output = new List<ProductInfo>();
            DynamicParameters param = new DynamicParameters();
            string query = "select Products.Code, Products.description,Categories.CType as category,Models.ModelName as model,";
            query += " Products.Size, Products.Color,MasterDetail.Qty,MasterDetail.Price, (MasterDetail.Qty * MasterDetail.Price) as TotlaPrice";
            query += " from sales inner join Amounts on sales.SaleID = Amounts.TrID inner join MasterDetail on Amounts.Id = MasterDetail.AmountId inner join Products on MasterDetail.ProductId = Products.Id";

            query += " inner join Models on Products.ModelId = Models.Id";

            query += " inner join Brands on Models.BrandId = Brands.Id";

            query += " inner join Categories on Brands.CategoryId = Categories.Id";
            query += " where sales.SaleID =@SaleID  and Amounts.TrType = 2";

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                param.Add("@SaleID", SaleId, dbType: DbType.Int32);
                output = con.Query<ProductInfo>(query, param, commandType: CommandType.Text).ToList();
            }
            return output;








        }
    }
}
