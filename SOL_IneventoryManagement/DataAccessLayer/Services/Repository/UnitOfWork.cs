﻿using BussinessAccessLayer.Model;
using Dapper;
using DataAccessLayer.Services.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
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
        BaseRepository<Bin> _Bins;

        BaseRepository<Brand> _Brands;
        BaseRepository<Model> _Models;



        BaseRepository<Manufacture> _Manufactures;
        BaseRepository<Source> _Sources;
        BaseRepository<Vendor> _Vendors;
        BaseRepository<Size> _Sizes;
        BaseRepository<Measure> _Measures;
        BaseRepository<Product> _Products;
        BaseRepository<Color> _Colors;
        BaseRepository<Branch> _Branchs;
        BaseRepository<Purchase> _Purchase;
        BaseRepository<MasterDetail> _MasterDetails;
        BaseRepository<PaymentType> _PaymentTypes;
        BaseRepository<Sale> _Sales;
        BaseRepository<SellFrom> _SellFroms;
        BaseRepository<SellingType> _SellingTypes;
        BaseRepository<Customer> _Customers;



















        private readonly IConfiguration _config;
        private string connectionstring = "";
  
   
        public UnitOfWork(ApplicationDbContext dbContext, IConfiguration config)
        {
           this._dbContext= dbContext;
            this._config = config;
            connectionstring = _config.GetConnectionString("DatabasDbConnection");

        }


        public List<T> ExecuteRawQuery<T>(string strquery, DynamicParameters param, CommandType commandtype)
        {
            List<T> output = new List<T>();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                output = con.Query<T>(strquery, param, commandType: commandtype).ToList();
            }


            return output;
        }


        public List<T> ExecuteRawQuery<T>(string strquery)
        {
            List<T> output = new List<T>();

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                output = con.Query<T>(strquery, null,commandType: CommandType.Text).ToList();
            }


            return output;
        }


        public T ExecuteSingleRawQuery<T>(string strquery, DynamicParameters param, CommandType commandtype)
        {
            T output;

            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                output = con.Query<T>(strquery, param, commandType: commandtype).FirstOrDefault();
            }


            return output;
        }

     

        public void BeginTransaction()
        {
            _dbContext.Database.BeginTransaction();
      
        }

        public void CommitTransaction()
        {
            _dbContext.Database.CommitTransaction();
        }
        public void RollbackTransaction()
        {
            _dbContext.Database.RollbackTransaction();
        }

  
        public IRepository<Amount> Amounts
        {
            get
            {
                return _Amounts ??
                    (_Amounts = new BaseRepository<Amount>(_dbContext));
            }
        }

        public IRepository<Manufacture> Manufactures
        {
            get
            {
                return _Manufactures ??
                    (_Manufactures = new BaseRepository<Manufacture>(_dbContext));
            }
        }

        public IRepository<Category> Categories { 
            get {
                return _Categories ?? (_Categories = new BaseRepository<Category>(_dbContext));
            } 
        }


        public IRepository<Bin> Bins
        {
            get
            {
                return _Bins ?? (_Bins = new BaseRepository<Bin>(_dbContext));
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


        //Product
        public IRepository<Product> Products
        {
            get
            {
                return _Products ?? (_Products = new BaseRepository<Product>(_dbContext));
            }
        }
        //_Colors


        //Color
        public IRepository<Color> Colors
        {
            get
            {
                return _Colors ?? (_Colors = new BaseRepository<Color>(_dbContext));
            }
        }

        //Branch
        public IRepository<Branch> Branchs
        {
            get
            {
                return _Branchs ?? (_Branchs = new BaseRepository<Branch>(_dbContext));
            }
        }

        //Purchase
        public IRepository<Purchase> Purchases
        {
            get
            {
                return _Purchase ?? (_Purchase = new BaseRepository<Purchase>(_dbContext));
            }
        }

        //MasterDetail
        public IRepository<MasterDetail> MasterDetails
        {
            get
            {
                return _MasterDetails ?? (_MasterDetails = new BaseRepository<MasterDetail>(_dbContext));
            }
        }


        //PaymentTypes
        public IRepository<PaymentType> PaymentTypes
        {
            get
            {
                return _PaymentTypes ?? (_PaymentTypes = new BaseRepository<PaymentType>(_dbContext));
            }
        }


        //Sales
        public IRepository<Sale> Sales
        {
            get
            {
                return _Sales ?? (_Sales = new BaseRepository<Sale>(_dbContext));
            }
        }



        //SaleFrom
        public IRepository<SellFrom> SellFroms
        {
            get
            {
                return _SellFroms ?? (_SellFroms = new BaseRepository<SellFrom>(_dbContext));
            }
        }




        //SaleFrom
        public IRepository<SellingType> SellingTypes
        {
            get
            {
                return _SellingTypes ?? (_SellingTypes = new BaseRepository<SellingType>(_dbContext));
            }
        }




        //Customer
        public IRepository<Customer> Customers
        {
            get
            {
                return _Customers ?? (_Customers = new BaseRepository<Customer>(_dbContext));
            }
        }
    }
}
