using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3GenericListLab
{
    class Program
    {



        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();

            Product product = catalog.Lookup("P100");

            Debug.Assert(product != null, "Product is null");
            Debug.Assert(product.Name == "Peanut Butter", "Product is not Peanut Butter");

            Console.ReadLine();

        }
    }
}
