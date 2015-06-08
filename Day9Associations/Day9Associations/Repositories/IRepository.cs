using Day9Associations.Models;
using System;
using System.Collections.Generic;
namespace Day9Associations.Repositories
{
    public interface IRepository
    {
        void CreateMovie(Movie movieToCreate);
        void Dispose();
        Movie FindMovie(int id);
        IList<Movie> ListMovies();
    }
}
