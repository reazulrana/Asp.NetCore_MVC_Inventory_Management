using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessAccessLayer.Model
{
  public  class Branch
    {
        [Key]

        public int Id { get; set; }
        
        [MaxLength(20, ErrorMessage = "Max Legth is 20 That You Have Excced")]
        public string Name { get; set; }
        [MaxLength(35, ErrorMessage = "Max Legth is 35 That You Have Excced")]

        public string Contact { get; set; }
        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]
        public string BranchIncharge { get; set; }
        public bool IsSelected { get; set; }
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
        public virtual List<Sale> Sales { get; set; } = new List<Sale>();

    }
}
