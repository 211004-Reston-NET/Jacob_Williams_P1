﻿// <auto-generated />
using System;
using DataLogic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLogic.Migrations
{
    [DbContext(typeof(Project_0_DatabaseContext))]
    [Migration("20211104210259_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Customer_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Customer_Address");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Customer_Email");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Customer_Name");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasColumnName("Customer_Phonenumber");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Models.ItemsInOrder", b =>
                {
                    b.Property<int>("ItemsInOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ItemsInOrder_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LineItemId")
                        .HasColumnType("int")
                        .HasColumnName("LineItem_Id");

                    b.Property<int>("OrdersId")
                        .HasColumnType("int")
                        .HasColumnName("Orders_Id");

                    b.HasKey("ItemsInOrderId");

                    b.HasIndex("LineItemId");

                    b.HasIndex("OrdersId");

                    b.ToTable("ItemsInOrder");
                });

            modelBuilder.Entity("Models.LineItems", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LineItem_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LineItemQuantity")
                        .HasColumnType("int")
                        .HasColumnName("LineItem_Quantity");

                    b.Property<int?>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("Product_Id");

                    b.Property<int>("StoreFrontId")
                        .HasColumnType("int")
                        .HasColumnName("StoreFront_Id");

                    b.HasKey("LineItemId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreFrontId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Orders_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("Customer_Id");

                    b.Property<int>("StoreFrontId")
                        .HasColumnType("int")
                        .HasColumnName("StoreFront_Id");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(38,0)");

                    b.HasKey("OrdersId")
                        .HasName("Orders_PKey");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StoreFrontId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Product_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Product_Description");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Product_Name");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int")
                        .HasColumnName("Product_Price");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Models.StoreFront", b =>
                {
                    b.Property<int>("StoreFrontId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StoreFront_Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StoreFrontAddress")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("StoreFront_Address");

                    b.Property<string>("StoreFrontName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("StoreFront_Name");

                    b.HasKey("StoreFrontId");

                    b.ToTable("StoreFront");
                });

            modelBuilder.Entity("Models.ItemsInOrder", b =>
                {
                    b.HasOne("Models.LineItems", "LineItem")
                        .WithMany("ItemsInOrders")
                        .HasForeignKey("LineItemId")
                        .HasConstraintName("FK__ItemsInOr__LineI__29221CFB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Order", "Orders")
                        .WithMany("ItemsInOrders")
                        .HasForeignKey("OrdersId")
                        .HasConstraintName("FK__ItemsInOr__Order__2A164134")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LineItem");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Models.LineItems", b =>
                {
                    b.HasOne("Models.Order", null)
                        .WithMany("LineItems")
                        .HasForeignKey("OrdersId");

                    b.HasOne("Models.Product", "Product")
                        .WithMany("LineItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FKey_ToProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.StoreFront", "StoreFront")
                        .WithMany("LineItems")
                        .HasForeignKey("StoreFrontId")
                        .HasConstraintName("FKey_ToStoreFront_LI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("StoreFront");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FKey_ToCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.StoreFront", "StoreFront")
                        .WithMany("Orders")
                        .HasForeignKey("StoreFrontId")
                        .HasConstraintName("FKey_ToStoreFront")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("StoreFront");
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Models.LineItems", b =>
                {
                    b.Navigation("ItemsInOrders");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Navigation("ItemsInOrders");

                    b.Navigation("LineItems");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Navigation("LineItems");
                });

            modelBuilder.Entity("Models.StoreFront", b =>
                {
                    b.Navigation("LineItems");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
