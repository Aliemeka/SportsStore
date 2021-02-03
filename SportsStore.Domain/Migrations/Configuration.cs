using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsStore.Domain.Data.StoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SportsStore.Domain.Data.StoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //DbSet<T>.AddOrUpdate();

            // Seed method for products with default data
            context.Products.AddOrUpdate(product => product.ProductID, 
                new Product()
                {
                    ProductID = 1,
                    Name = "Nike Air",
                    Category = "Shoes",
                    Description = "Compact Nike Air shoes for comfort and euphoria. Comes with a bonus pair.",
                    Price = 400
                },
                new Product()
                {
                    ProductID = 2,
                    Name = "Nigeria FC 2018 Kit",
                    Category = "Jerseys",
                    Description = "Nigeria best-selling jersey to turn up the swag on the streets and on the pitch. Comes with a gift basket.",
                    Price = 350
                },
                new Product()
                {
                    ProductID = 3,
                    Name = "AHos Life-jacket",
                    Description = "Protective and fashionable ladies swimming suit.",
                    Category = "Swimming suits",
                    Price = 250
                },
                new Product()
                {
                    ProductID = 4,
                    Name = "Ping-Pong Table",
                    Category = "Table tennis gears",
                    Description = "Ping-pong table for playing professional table tennis.",
                    Price = 600
                }
            );
        }
    }
}
