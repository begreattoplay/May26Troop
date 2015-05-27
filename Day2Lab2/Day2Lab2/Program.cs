using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math
            Math math = new Math();

            int result1 = math.AddNumbers(3, 2);
            int result2 = math.AddNumbers(0, 2);
            int result3 = math.AddNumbers(1, 5, 2, 13, 7);

            Debug.Assert(result1 == 5, "You don't know math!");
            Debug.Assert(result2 == 2);


            //Customers
            Customer sally = new Customer(23);
            sally.Age = 23;
            sally.FirstName = "Sally";
            sally.LastName = "Williams";
            sally.BirthDate = new DateTime(2015, 6, 25);

            //Loop through an objects properties without knowing what they are
            var props = sally.GetType().GetProperties();

            for (int i = 0; i < props.Length; i++)
            {
                var p = props[i];
                Console.WriteLine("Property: {0}, Value {1}", p.Name, p.GetValue(sally));
            }

            //Property initializer syntax
            Customer mike = new Customer(10)
            {
                Age = 10,
                BirthDate = DateTime.Parse("2015-06-23"),
                FirstName = "Mike",
                LastName = "Williams"
            };
            
            Debug.Assert(sally.Age == 23, "Sally is 23");
            Debug.Assert(mike.Age == 10, "Mike is 10");

            Console.ReadLine();            
        }
    }
}
