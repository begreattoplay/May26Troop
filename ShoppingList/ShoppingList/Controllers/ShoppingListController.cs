using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {
            ShoppingListService service = new ShoppingListService();

            IndexViewModel vm = new IndexViewModel
            {
                Customers = service.GetItems()
            };

            return View(vm);
        }
    }
}