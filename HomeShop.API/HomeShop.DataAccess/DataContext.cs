using HomeShop.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace HomeShop.API.Data
{
    public class DataContext : DbContext
    {
        /* The dbContextOptions carries the configuration information needed to 
        configure the DbContext. The dbContextOptions can also be configured 
        using the OnConfiguring method. This method gets the 
        DbContextOptionsBuilder as its argument. It is then used to create the dbContextOptions*/
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}