using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
  public  class Category
    {
        public Category()
        {
            this.Brands = new HashSet<Brand>();
        }

        [Key]
        public int Id { get; set; }
        public string CType { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
    }
}
