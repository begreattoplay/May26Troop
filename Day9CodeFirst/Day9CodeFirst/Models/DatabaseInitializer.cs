using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9CodeFirst.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            

            //foreach (Movie m in movies)
            //{
            //    context.Movies.Add(m);
            //}
        }
    }
}