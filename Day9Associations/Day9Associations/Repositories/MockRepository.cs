using Day9Associations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day9Associations.Repositories
{
    public class MockRepository : IRepository
    {
        public void CreateMovie(Movie movieToCreate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Movie FindMovie(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie 
                { 
                    Title = "Mock Movie 1", 
                    Director = "Mock Director 1", 
                    Category = new Category
                    {
                        Name = "Mock Category 1"
                    }
                }
            };
        }
    }
}