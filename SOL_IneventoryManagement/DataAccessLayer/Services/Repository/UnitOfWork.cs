using BussinessAccessLayer.Model;
using DataAccessLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {



        public ApplicationDbContext _dbContext { get; }

        BaseRepository<Amount> _Amounts;
        BaseRepository<Category> _Categories;
        BaseRepository<Brand> _Brands;
        BaseRepository<Model> _Models;



        BaseRepository<Manufacture> _Manufacture;
        BaseRepository<Source> _Sources;
        BaseRepository<Vendor> _Vendors;
        BaseRepository<Size> _Sizes;
        BaseRepository<Measure> _Measures;







        public UnitOfWork(ApplicationDbContext dbContext)
        {
           this._dbContext= dbContext;
       
        }


        public IRepository<Amount> Amounts
        {
            get
            {
                return _Amounts ??
                    (_Amounts = new BaseRepository<Amount>(_dbContext));
            }
        }

        public IRepository<Manufacture> Manufacture
        {
            get
            {
                return _Manufacture ??
                    (_Manufacture = new BaseRepository<Manufacture>(_dbContext));
            }
        }

        public IRepository<Category> Categories { 
            get {
                return _Categories ?? (_Categories = new BaseRepository<Category>(_dbContext));
            } 
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _Brands ?? (_Brands = new BaseRepository<Brand>(_dbContext));
            }
        }

        public IRepository<Model> Models
        {
            get
            {
                return _Models ?? (_Models = new BaseRepository<Model>(_dbContext));
            }
        }

        public IRepository<Source> Sources
        {
            get
            {
                return _Sources ?? (_Sources = new BaseRepository<Source>(_dbContext));
            }
        }

        public IRepository<Vendor> Vendors
        {
            get
            {
                return _Vendors ?? (_Vendors = new BaseRepository<Vendor>(_dbContext));
            }
        }


        public IRepository<Size> Sizes
        {
            get
            {
                return _Sizes ?? (_Sizes = new BaseRepository<Size>(_dbContext));
            }
        }


        //Measure
        public IRepository<Measure> Measures
        {
            get
            {
                return _Measures ?? (_Measures = new BaseRepository<Measure>(_dbContext));
            }
        }
    }
}
