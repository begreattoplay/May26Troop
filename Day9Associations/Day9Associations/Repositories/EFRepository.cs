using Day9Associations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Day9Associations.Repositories
{
    public class EFRepository : IDisposable, IRepository
    {
        private MoviesDbContext _db = new MoviesDbContext();

        public IList<Movie> ListMovies()
        {
            return _db.Movies.Include(m => m.Category).ToList();
        }

        public Movie FindMovie(int id)
        {
            return _db.Movies.Find(id);
        }

        public void CreateMovie(Movie movieToCreate)
        {
            _db.Movies.Add(movieToCreate);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}