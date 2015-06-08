using Day9Associations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day9Associations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MoviesDbContext db = new MoviesDbContext();
            var movies = db.Movies.ToList();

            return View();
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