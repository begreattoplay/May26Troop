using Day9CodeFirst.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9CodeFirst.Models
{
    public class MovieDBContext : DbContext
    {
        static MovieDBContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDBContext, Configuration>());
        }
        public IDbSet<Movie> Movies { get; set; }
    }
}