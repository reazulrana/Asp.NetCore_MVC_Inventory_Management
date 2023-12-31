﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230711075253_Change_Product_Table")]
    partial class Change_Product_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BussinessAccessLayer.Model.Amount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("Dues")
                        .HasColumnType("int");

                    b.Property<int>("GrossAmount")
                        .HasColumnType("int");

                    b.Property<int>("NetAmount")
                        .HasColumnType("int");

                    b.Property<int>("Others")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<int>("TrID")
                        .HasColumnType("int");

                    b.Property<int>("TrType")
                        .HasColumnType("int");

                    b.Property<int>("Traport")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Amounts");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Bin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BinNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bins");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MemberId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Manufacture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManufactureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TrID")
                        .HasColumnType("int");

                    b.Property<int>("TrType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.MasterDetail", b =>
                {
                    b.Property<int>("DID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MasterId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("DID");

                    b.HasIndex("MasterId");

                    b.HasIndex("ProductId");

                    b.ToTable("MasterDetail");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Measure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Measurements")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Measures");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountPrice")
                        .HasColumnType("int");

                    b.Property<string>("Manufacture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("OpeningBalance")
                        .HasColumnType("int");

                    b.Property<int>("OpeningQty")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unitprice")
                        .HasColumnType("int");

                    b.Property<string>("Vendor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Purchase", b =>
                {
                    b.Property<int>("PurchaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SourceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TrDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TrID")
                        .HasColumnType("int");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.HasKey("PurchaseID");

                    b.HasIndex("SourceId");

                    b.HasIndex("TrID")
                        .IsUnique()
                        .HasFilter("[TrID] IS NOT NULL");

                    b.HasIndex("VendorId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TrDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TrID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("SaleID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TrID")
                        .IsUnique()
                        .HasFilter("[TrID] IS NOT NULL");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SourceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Brand", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Category", "Category")
                        .WithMany("Brands")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Customer", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Member", "Member")
                        .WithMany("Customers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.MasterDetail", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Master", "master")
                        .WithMany("MasterDetails")
                        .HasForeignKey("MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BussinessAccessLayer.Model.Product", null)
                        .WithMany("MasterDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("master");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Model", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Product", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Model", "Model")
                        .WithMany("Products")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Purchase", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Source", "Source")
                        .WithMany("Purchases")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BussinessAccessLayer.Model.Amount", "Amount")
                        .WithOne("Purchase")
                        .HasForeignKey("BussinessAccessLayer.Model.Purchase", "TrID");

                    b.HasOne("BussinessAccessLayer.Model.Master", "Master")
                        .WithOne("Purchase")
                        .HasForeignKey("BussinessAccessLayer.Model.Purchase", "TrID");

                    b.HasOne("BussinessAccessLayer.Model.Vendor", "Vendor")
                        .WithMany("Purchases")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amount");

                    b.Navigation("Master");

                    b.Navigation("Source");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Sale", b =>
                {
                    b.HasOne("BussinessAccessLayer.Model.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BussinessAccessLayer.Model.Amount", "Amount")
                        .WithOne("Sale")
                        .HasForeignKey("BussinessAccessLayer.Model.Sale", "TrID");

                    b.HasOne("BussinessAccessLayer.Model.Master", "Master")
                        .WithOne("Sale")
                        .HasForeignKey("BussinessAccessLayer.Model.Sale", "TrID");

                    b.Navigation("Amount");

                    b.Navigation("Customer");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Amount", b =>
                {
                    b.Navigation("Purchase");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Category", b =>
                {
                    b.Navigation("Brands");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Master", b =>
                {
                    b.Navigation("MasterDetails");

                    b.Navigation("Purchase");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Member", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Model", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Product", b =>
                {
                    b.Navigation("MasterDetails");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Source", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("BussinessAccessLayer.Model.Vendor", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
