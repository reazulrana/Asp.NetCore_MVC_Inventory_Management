using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Bin
    {
        public Bin()
        {
            this.Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        public string BinNo { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
