using BussinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Interface
{
   public interface IUnitOfWork
    {
        IRepository<Amount> Amounts { get; }
        IRepository<Category> Categories { get; }
        IRepository<Brand> Brands { get; }
        IRepository<Model> Models { get; }


        IRepository<Manufacture> Manufacture { get; }
        IRepository<Source> Sources { get; }
        IRepository<Vendor> Vendors { get; }
        IRepository<Size> Sizes { get; }
        IRepository<Measure> Measures { get; }







    }
}
