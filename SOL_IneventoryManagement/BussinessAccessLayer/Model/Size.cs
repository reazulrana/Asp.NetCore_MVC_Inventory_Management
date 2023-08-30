using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel;
namespace BussinessAccessLayer.Model
{
  public  class Size
    {
        [Key]
        public int Id { get; set; }
       

        [MaxLength(50, ErrorMessage = "Max Legth is 50 That You Have Excced")]
        public string ProductSize { get; set; }
        [Description("1: Size, 2: Dimension")]

        [MaxLength(2, ErrorMessage = "Max Legth is 2 That You Have Excced")]

        public int SizeType { get; set; }
        public bool IsSelected { get; set; }

    }
}
