using MovieStore.Services.Models;
using System;
using System.Collections.Generic;
namespace MovieStore.Services
{
    public interface IMovieService
    {
        IList<MovieDTO> GetMovies();
    }
}
