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
        public string ProductSize { get; set; }
        [Description("1: Size, 2: Dimension")]
        public int SizeType { get; set; }

    }
}
