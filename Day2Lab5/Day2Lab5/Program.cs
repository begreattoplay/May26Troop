using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer nick = new Customer();
            nick.FirstName = "Nick";
            nick.LastName = "Brittain";

            nick.BillingAddress.City = "Pearland";
            nick.BillingAddress.State = "TX";
            nick.BillingAddress.Street = "1111 Neat Rd.";
            nick.BillingAddress.Zip = "77584";

            //Property Initializer Syntax
            Customer rob = new Customer
            {
                BillingAddress =
                {
                    City = "Deer Park",
                    State = "TX",
                    Street = "3423 St.",
                    Zip = "32343"
                },
                ShippingAddress =
                {
                    City = "Pasadena",
                    Street = "Houston",
                    State = "TX",
                    Zip = "35323"
                },
                FirstName = "Rob",
                LastName = "Greenlee"
            };


            Console.ReadLine();

        }
    }
}
