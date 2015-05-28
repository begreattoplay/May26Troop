using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3GenericListLab
{
    class ProCatalog
    {
        List<Product> _products;

        public ProCatalog()
        {
            _products = new List<Product>();

            _products.Add(new Product
                {
                    Id = "P100",
                    Name = "Peanut Butter",
                    Price = 4.44m
                });
        }

        public Product Lookup(string id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
