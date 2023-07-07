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
        public string SourceName { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
