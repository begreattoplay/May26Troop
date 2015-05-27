using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab1
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string PriceString
        {
            get { return this.Price.ToString("C"); }
        }

        public decimal CalculateWithTexasTaxRate()
        {
            return this.CalculatePrice(8.25m, 0);
        }

        public decimal CalculatePrice()
        {
            return this.CalculatePrice(0, 0);
        }

        public decimal CalculatePrice(decimal taxRate)
        {
            return CalculatePrice(taxRate, 0);
        }

        public decimal CalculatePrice(decimal taxRate, decimal discount)
        {
            return this.Price + (this.Price * taxRate) - (this.Price * discount);
        }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product()
        {

        }
    }
}
