using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.ExtendModel
{
   public class ProductBalance
    {
        //tp.Id, tp.Code,tp.Description,
        //tp.CType,tp.ModelName,tp.Size, coalesce(tp.pQty,0) as purqty,
        //coalesce(ts.sQty,0) saleQty

        public int Id { get; set; }
        public string code { get; set; }
        public string Description { get; set; }
        public string CType { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public string ModelName { get; set; }
        public int purqty { get; set; }
        public int saleQty { get; set; }
        public int Balance { get; set; }
        public int OpeningQty { get; set; } // Tobe Added With Stock Qty
        public int Unitprice { get; set; }
        public string photopath { get; set; }
       



    }
}
