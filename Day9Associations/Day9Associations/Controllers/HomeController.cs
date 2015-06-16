using Day9Associations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Day9Associations.Repositories;

namespace Day9Associations.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;

        //public HomeController() : this(new MockRepository())
        //{

        //}

        public HomeController(IRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            IList<Movie> movies = null;

            movies = _repo.ListMovies();

            //using (MoviesDbContext db = new MoviesDbContext())
            //{
            //    movies = db.Movies.Include(c => c.Category).ToList();
            //};

            return View(movies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}