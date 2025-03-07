using Microsoft.EntityFrameworkCore;
using BookRepublic.Models.cs;

namespace BookRepublic
{
    public class BookRepublicDbContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ProductsType> ProductsType { get; set; }
        public DbSet<Sellers> Sellers { get; set; }
        public DbSet<Users> Users { get; set; }

        public BookRepublicDbContext(DbContextOptions<BookRepublicDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Orders>().HasData(new Orders[]
            {
                new Orders { Id = 1, CustomerId = 1, PaymentType = "creditCard", ProductId = 1, SellerId =1, Status = "sold", TotalPrice = 100 },
            });

            modelBuilder.Entity<Sellers>().HasData(new Sellers[]
            {
                new Sellers { Id = 1, Name = "John Doe", Address = "123 Main St", Email = "123test.com", ProductId = 1, StoreName = "John's Store" },
            });

            modelBuilder.Entity<Products>().HasData(new Products[]
            {
                new Products { Id = 1, Name = "Shoes", Price = 100, Description = "Shoes for sale", Quantity = 1, SellerId = 1, ProductType = "clothing" },
            });

            modelBuilder.Entity<Customers>().HasData(new Customers[]
            {
                new Customers { Id = 1, Name = "Jane Doe", Address = "123 Main St", Email = "123test.com" },
            });

            modelBuilder.Entity<Users>().HasData(new Users[]
            {
                new Users { Id = 1, Name = "JohnDoe", Address = "123test ", Email = "123test@gmail.com"},
            });

            modelBuilder.Entity<ProductsType>().HasData(new ProductsType[]
            {
                new ProductsType { Id = 1, Name = "clothing" },
            });
        }

    }
}
