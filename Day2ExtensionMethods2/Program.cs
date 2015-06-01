using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExtensionMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] headlines = new string[] { "Martians Attack!", "Seahawks win Superbowl!", "Peanut Butter rocks!" };
            Console.WriteLine(headlines.GetRandom());

            int[] nums = new int[] { 1, 7, 13, 5, 132 };

            Employee[] emps = new Employee[] 
            { 
                new Employee { FirstName = "Nick", LastName = "Brittain" },
                new Employee { FirstName = "Me", LastName = "You" }
            };

            Employee emp = emps.GetRandom();

            Console.WriteLine(emp.FirstName);
            Console.WriteLine(nums.GetRandom());
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
