using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessAccessLayer.Model
{
   public class Bin
    {
        

        [Key]
        public int Id { get; set; }
        [MaxLength(10, ErrorMessage = "Max Legth is 10 That You Have Excced")]

        public string BinNo { get; set; }

    }
}
