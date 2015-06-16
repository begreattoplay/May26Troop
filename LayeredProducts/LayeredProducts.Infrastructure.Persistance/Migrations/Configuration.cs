namespace LayeredProducts.Infrastructure.Persistance.Migrations
{
    using LayeredProducts.Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LayeredProducts.Infrastructure.Persistance.ProductsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LayeredProducts.Infrastructure.Persistance.ProductsDbContext context)
        {
            Category c1 = new Category { Name = "Smartphones" };

            context.Categories.AddOrUpdate(c => c.Name, c1);
            context.SaveChanges();

            context.Products.AddOrUpdate(p => p.Name, new Product
            {
                CategoryId = c1.CategoryId,
                Name = "iPhone",
                Price = 499.99m
            });
        }
    }
}
