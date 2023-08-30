using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLayer.Model
{
  public  class SellingType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25,ErrorMessage ="Max Length Is 25 You Can Not Exceed This Length ")]
        public string Types { get; set; }
        public bool IsSelected { get; set; }
    }
}
