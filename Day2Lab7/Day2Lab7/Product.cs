using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab7
{
    public class Product
    {
        public decimal Price { get; set; }

        public static Product Create(decimal price)
        {
            Product p = new Product();
            p.Price = price;
            return p;
        }
    }
}
