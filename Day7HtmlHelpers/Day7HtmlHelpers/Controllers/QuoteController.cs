using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7HtmlHelpers.Controllers
{
    public class QuoteController : Controller
    {
        private static List<string> _quotes = new List<string>();

        public QuoteController()
        {
            if (_quotes.Count == 0)
            {
                _quotes.Add("You have to learn the rules of the game. And then you have to play better than anyone else");
                _quotes.Add("Try not to become a man of success, but rather try to become a man of value");
                _quotes.Add("The true sign of intelligence is not knowledge but imagination");
                _quotes.Add("Weakness of attitude becomes weakness of character");
            }
        }

        // GET: Quote
        [ChildActionOnly]
        public ActionResult GetQuote()
        {
            Random rnd = new Random();
            int index = rnd.Next(_quotes.Count);
            return PartialView("_QuotePartial", _quotes[index]);
        }
    }
}