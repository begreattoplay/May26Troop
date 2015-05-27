using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product nicksLaptop = new Product("Surface", 232343.3243m);

            Product macBook = new Product();
            macBook.Name = "Air";


            Console.WriteLine(nicksLaptop.CalculateWithTexasTaxRate());

            Console.WriteLine("Name: {0}, Price {1}", nicksLaptop.Name, nicksLaptop.PriceString);
            Console.ReadLine();
        }
    }
}
