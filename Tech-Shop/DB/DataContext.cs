using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tech_Shop.DB;
using Tech_Shop.DB.Models;
using Tech_Shop.Migrations;

namespace Tech_Shop.DB
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base ("name=Tech-ShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ComputerSpecification> ComputerSpecifications { get; set; }
        public virtual DbSet<Order> Orders { get; set; }





    }
}