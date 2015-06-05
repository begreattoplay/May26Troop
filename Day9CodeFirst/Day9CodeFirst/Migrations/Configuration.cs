namespace Day9CodeFirst.Migrations
{
    using Day9CodeFirst.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day9CodeFirst.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Day9CodeFirst.Models.MovieDBContext";
        }

        protected override void Seed(Day9CodeFirst.Models.MovieDBContext context)
        {
            Movie[] movies = new Movie[]
            {
                new Movie { Title = "Star Wars", Director = "Lucas" },
                new Movie { Title = "Momento", Director = "Nolan" },
                new Movie { Title = "King Kong", Director = "Jackson" }
            };

            context.Movies.AddOrUpdate(m => m.Title, movies);

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
