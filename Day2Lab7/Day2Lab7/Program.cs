using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cleaned = Utility.CleanUserInput("   asdfasdf   ");

            Product mouse = new Product();
            mouse.Price = 34.324m;
            Console.WriteLine(mouse.Price);

            Product laptop = Product.Create(234.342m);
            Console.WriteLine(laptop.Price);

            Console.ReadLine();
        }
    }
}
