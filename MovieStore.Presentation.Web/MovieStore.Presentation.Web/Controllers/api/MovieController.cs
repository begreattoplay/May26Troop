using MovieStore.Services;
using MovieStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieStore.Presentation.Web.Controllers.api
{
    public class MovieController : ApiController
    {
        private IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        public IHttpActionResult Get()
        {
            IList<MovieDTO> movies = _service.GetMovies();

            return Ok(movies);
        }

        //public IList<MovieDTO> Get()
        //{
        //    IList<MovieDTO> movies = _service.GetMovies();

        //    return movies;
        //}
    }
}
