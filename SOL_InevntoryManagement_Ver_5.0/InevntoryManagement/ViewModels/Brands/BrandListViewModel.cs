using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Services.Interface;
using DataAccessLayer.Services.Repository;
using BussinessAccessLayer.Model;
using InevntoryManagement.Models;

namespace InevntoryManagement.ViewModels.Brands
{
    public class BrandListViewModel:BasePaginate
    {


        public List<BrandList> brandLists { get; set; } = new List<BrandList>();

        public override string ControllerName { get => "Brand"; }
        public override string ActionName { get => "GetBrandList"; }


    }



    public class BrandList
    {
        public int brandId { get; set; }
        public int CategoryId { get; set; }

        public string brandName { get; set; }
        public string Ctype { get; set; }
    }
}
