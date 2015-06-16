namespace Day9Associations.Migrations
{
    using Day9Associations.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day9Associations.Models.MoviesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Day9Associations.Models.MoviesDbContext context)
        {

            Category sciFi = new Category { Name = "SciFi" };
            Category horror = new Category { Name = "Horror" };


            context.Categories.AddOrUpdate(c => c.Name, sciFi, horror);
            context.SaveChanges();

            Movie starWars = new Movie 
            { 
                Title = "Star Wars", 
                Director = "George Lucas",
                CategoryId = sciFi.Id
            };
            context.Movies.AddOrUpdate(m => m.Title, starWars);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
