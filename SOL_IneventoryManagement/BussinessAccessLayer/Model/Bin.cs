﻿using System;
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
        public string BinNo { get; set; }

    }
}
