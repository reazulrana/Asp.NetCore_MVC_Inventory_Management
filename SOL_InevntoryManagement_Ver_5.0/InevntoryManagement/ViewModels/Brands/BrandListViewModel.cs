using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using BussinessAccessLayer.Model;

namespace InevntoryManagement.ViewModels.Brands
{
    public class BrandListViewModel
    {


        public int brandId { get; set; }
        public int CategoryId { get; set; }

        public string brandName { get; set; }
        public string Ctype { get; set; }


    }
}
