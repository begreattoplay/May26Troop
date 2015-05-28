using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee alex = new Employee();
            alex.FirstName = "Alex";
            alex.LastName = "Isaac";

            Employee[] employees = new Employee[] { 
                alex, 
                new Employee 
                { 
                    FirstName = "Nick", 
                    LastName = "Brittain" 
                },
                new Employee
                {
                    FirstName = "Keenan",
                    LastName = "Silver"
                }
            };

            Array.Sort(employees, new LastFirstComparer());

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            
            //var colors = new string[] { "Red", "Green", "Blue" };
            //Array.Sort(colors);

            //foreach(var color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            Console.ReadLine();
        }
    }
}
