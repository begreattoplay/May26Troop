using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3GenericListLab
{
    public class ProductCatalog
    {
        private List<Product> _products;

        public ProductCatalog()
        {
            _products = new List<Product>();

            _products.Add(new Product
            {
                Id = "P100",
                Name = "Peanut Butter",
                Price = 3.99m
            });

            _products.Add(new Product
            {
                Id = "P250",
                Name = "Cookie",
                Price = 4.99m
            });

            _products.Add(new Product
            {
                Id = "P435",
                Name = "Marker",
                Price = 12.99m
            });
        }

        public Product Lookup(string id)
        {
            Product product = null;

            foreach(var p in _products)
            {
                if (p.Id == id)
                    product = p;
            }

            return product;
        }
    }
}
