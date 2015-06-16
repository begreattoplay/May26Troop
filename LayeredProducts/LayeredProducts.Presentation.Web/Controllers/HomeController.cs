using LayeredProducts.Presentation.Web.Models;
using LayeredProducts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayeredProducts.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _service;

        public HomeController(IProductService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _service.GetProducts();

            return View(model);
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