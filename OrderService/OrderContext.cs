using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OrderApp
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("name=OrderContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // 配置关系
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.Customer)
                .WithMany()
                .HasForeignKey(o => o.Customer.ID);

            modelBuilder.Entity<OrderDetail>()
                .HasRequired(od => od.ProductItem)
                .WithMany()
                .HasForeignKey(od => od.ProductItem.ID);
        }
    }
}
