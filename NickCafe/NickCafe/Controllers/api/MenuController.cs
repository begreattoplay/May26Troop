using NickCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NickCafe.Controllers.api
{
    public class MenuController : ApiController
    {
        private static IList<Product> _products;


        static MenuController()
        {
            _products = new List<Product> { new Product { Name = " Tea", IsBreakfast = true, ProductPrice = .99m, ProductId = 1, ProductDescription = "This is Sparta" } };


        }

        public IList<Product> Get()
        {

            return _products;


        }
        public bool Post(Product product)
        {
            _products.Add(product);
            
            return true;
        }

    }
}
