using HappyShopper.Entities;
using Microsoft.EntityFrameworkCore;

namespace HappyShopper.Data
{
    public class StoreContext :DbContext 
    {
        private readonly DbContextOptions _options;

        public StoreContext(DbContextOptions options) : base(options)
        {
            _options = options;
            //Database.SetInitializer(new DbInitializer());
            //DbInitializer.Initialize(this);
        }

        protected override void OnModelCreating( ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Eskimo boots",
                    Description = "Cool and soft",
                    Price = 485,
                    PictureUrl = "images/products/boots-reddis.png",
                    Type = "Boots",
                    Brand = "Reddis",
                    QuantityInStock = 100

                },
                new Product
                {
                    Id=2,
                    Name = "Nike Hoodie",
                    Description = "Cool fashion",
                    Price = 485,
                    PictureUrl = "images/products/hoodie.png",
                    Type = "Hoodie",
                    Brand = "Nike",
                    QuantityInStock = 332

                },
                new Product
                {
                    Id=3,
                    Name = "Chinese Chop Sticks",
                    Description = "Very effective",
                    Price = 113,
                    PictureUrl = "images/products/chopsticks.png",
                    Type = "Cutlery",
                    Brand = "Chinatown",
                    QuantityInStock = 405

                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }

}
