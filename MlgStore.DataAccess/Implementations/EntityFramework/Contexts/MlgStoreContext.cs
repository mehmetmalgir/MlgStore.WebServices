using Microsoft.EntityFrameworkCore;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.DataAccess.Implementations.EntityFramework.Contexts
{
    public class MlgStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NU8CUCN;database=MlgStoreDb;trusted_connection=true;");
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Complaints> Complaints { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ProductPhotos> ProductPhotos { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<ShipperUsers> ShipperUsers { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<UsersAdmin> UsersAdmin { get; set; }
       
        


    }
}
