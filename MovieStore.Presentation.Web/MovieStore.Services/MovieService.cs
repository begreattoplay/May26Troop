using MovieStore.Domain.Models;
using MovieStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class MovieService : IMovieService
    {
        private IRepository _repo;

        public MovieService(IRepository repo)
        {
            _repo = repo;
        }

        public IList<MovieDTO> GetMovies()
        {
            //return _repo.Query<Movie>().Project().To<MovieDTO>().ToList();
            return _repo.Query<Movie>().Select(m => new MovieDTO
            {
                MovieId = m.MovieId,
                Title = m.Title
            }).ToList();
        }
    }
}
