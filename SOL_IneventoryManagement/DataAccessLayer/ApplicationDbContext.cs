﻿using BussinessAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public  class ApplicationDbContext:DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            //var builder = new ConfigurationBuilder().SetBasePath(System.IO.Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //var connectionstring = builder.Build().GetSection("ConnectionStrings").GetSection("DatabasDbConnection").Value;

            //optionsBuilder.UseSqlServer(connectionstring);
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Amount> Amounts { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<MasterDetail> MasterDetail { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Measure> Measures { get; set; }


        








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
