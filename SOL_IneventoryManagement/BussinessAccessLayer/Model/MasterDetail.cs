using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BussinessAccessLayer.Model
{
    public class MasterDetail
    {
        [Key]
        public int DID { get; set; }
        public int MasterId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public virtual Master master { get; set; }
    }
}
