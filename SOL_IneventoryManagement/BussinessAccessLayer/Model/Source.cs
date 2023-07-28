using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
  public  class Source
    {
        public Source()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]
        public string SourceName { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
