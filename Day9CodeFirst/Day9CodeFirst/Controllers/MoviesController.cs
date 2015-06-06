using Day9CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day9CodeFirst.Controllers
{
    public class MoviesController : Controller
    {
        //Private Class Instance Variable (or global class variable)
        private MovieDBContext _db = new MovieDBContext();

        // GET: Movies
        //Public Instance Method
        public ActionResult Index()
        {
            IQueryable<Movie> movies = from m in _db.Movies select m;
            return View(movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            Movie movie = _db.Movies.Find(id);

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie model)
        {
            if (ModelState.IsValid)
            {
                //Don't use this it has some inherit problems
                //_db.Entry(movie).State = System.Data.Entity.EntityState.Modified;

                Movie dbMovie = _db.Movies.Find(model.Id);
                dbMovie.Title = model.Title;
                dbMovie.Director = model.Director;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}