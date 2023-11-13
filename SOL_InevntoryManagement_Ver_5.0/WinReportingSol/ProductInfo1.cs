using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinReportingSol
{
   public class ProductInfo1
    {

        public string code { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public int qty { get; set; } = 0;
        public int price { get; set; } = 0;
        public int TotalPrice { get { return qty * price; } }

    }
}
