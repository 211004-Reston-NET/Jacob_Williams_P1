using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLogic.Entities
{
    public partial class Project_0_DatabaseContext : DbContext
    {
        public Project_0_DatabaseContext()
        {
        }

        public Project_0_DatabaseContext(DbContextOptions<Project_0_DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ItemsInOrder> ItemsInOrders { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Address");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Email");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.CustomerPhonenumber).HasColumnName("Customer_Phonenumber");
            });

            modelBuilder.Entity<ItemsInOrder>(entity =>
            {
                entity.ToTable("ItemsInOrder");

                entity.Property(e => e.ItemsInOrderId).HasColumnName("ItemsInOrder_Id");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_Id");

                entity.Property(e => e.OrdersId).HasColumnName("Orders_Id");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.ItemsInOrders)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK__ItemsInOr__LineI__29221CFB");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.ItemsInOrders)
                    .HasForeignKey(d => d.OrdersId)
                    .HasConstraintName("FK__ItemsInOr__Order__2A164134");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.ToTable("LineItem");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_Id");

                entity.Property(e => e.LineItemQuantity).HasColumnName("LineItem_Quantity");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFront_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FKey_ToProduct");

                entity.HasOne(d => d.StoreFront)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.StoreFrontId)
                    .HasConstraintName("FKey_ToStoreFront_LI");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrdersId)
                    .HasName("Orders_PKey");

                entity.Property(e => e.OrdersId).HasColumnName("Orders_Id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFront_Id");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(38, 0)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FKey_ToCustomer");

                entity.HasOne(d => d.StoreFront)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreFrontId)
                    .HasConstraintName("FKey_ToStoreFront");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Product_Description");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFront_Id");

                entity.Property(e => e.StoreFrontAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StoreFront_Address");

                entity.Property(e => e.StoreFrontName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StoreFront_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
