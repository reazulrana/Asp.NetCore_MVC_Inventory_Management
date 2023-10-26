using InevntoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InevntoryManagement.ViewModels.Category
{
    public class CategoryListViewModel:BasePaginate
    {

        public List<CategoryListModel> categories { get; set; } = new List<CategoryListModel>();
        public override string ActionName { get=> "CategoryList"; }
        public override string ControllerName { get=>"Category"; }
    }


    public class CategoryListModel
    {
        public int Id { get; set; }

        public string CType { get; set; }
    }
}
