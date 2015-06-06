using Day7HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7HtmlHelpers.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            Product p = new Product();
            p.Price = 234235.4634534m;

            List<State> states = new List<State>();
            states.Add(new State
            {
                Name = "Texas",
                StateCode = "TX"
            });

            states.Add(new State
            {
                Name = "Georgia",
                StateCode = "GA"
            });

            p.States = states;

            return View(p);
        }

        [HttpPost]
        public ActionResult Index(Product p)
        {
            return View();
        }
    }

    public class State
    {
        public string StateCode { get; set; }
        public string Name { get; set; }
    }
}