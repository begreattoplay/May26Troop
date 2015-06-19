using JSDay4WebAPI.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSDay4WebAPI.Controllers.API
{
    public class ProductsController : ApiController
    {
        private static ConcurrentStack<Product> _products;

        static ProductsController()
        {
            _products = new ConcurrentStack<Product>(new List<Product> {
                new Product { Name = "Milk", Price = 2.33m },
                new Product { Name = "Cheese", Price = 55.33m },
                new Product { Name = "Tesla", Price = 8989.33m }
            });
        }

        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post(Product product)
        {
            _products.Push(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
