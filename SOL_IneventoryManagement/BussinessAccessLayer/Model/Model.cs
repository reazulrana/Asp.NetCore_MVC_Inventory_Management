using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Model
    {
        public Model()
        {
            this.Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
