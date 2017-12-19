namespace Tech_ShopManagemant
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<ComputerSpecification> ComputerSpecifications { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

 
    }
}
