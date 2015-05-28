using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regular array - really fast but really hard to use
            //string[] stringArray = new string[] { "Nick", "Cookies" };


            //Generic list of strings
            List<string> stringList = new List<string>();
            
            //Add two strings to the generic list of strings
            stringList.Add("Nick");
            stringList.Add("Cookies");

            //Remove the string with the value Nick
            stringList.Remove("Nick");

            //Convert the generic list of strings to a plain ol string array
            string[] stringArray = stringList.ToArray();

            //Convert the plain ol string array to a generic list of strings
            List<string> newStringList = stringArray.ToList();

            //Generic list of Employees
            List<Employee> empList = new List<Employee>();

            //Add a new employee to the generic list of employees
            empList.Add(new Employee { Name = "Bob" });
            
            //Create a generic dictionary with int keys and employee values
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            //Add a employee with key 43424 and a new employee object
            employees.Add(43424, new Employee { Name = "Joe Bob" });

            //Get the employee from the employee dictionary with the key 43424
            Employee joe = employees[43424];

            //Create a generic dictionary with string keys and string values to hold
            //a list of states and their state codes
            Dictionary<string, string> states = new Dictionary<string, string>();
            
            //Add two states: key is the state code, value is the name
            states.Add("TX", "Texas");
            states.Add("NY", "New York");

            //Create a generic dictionary with int keys and string values
            //to store the months
            Dictionary<int, string> months = new Dictionary<int, string>();

            //Add January and February
            months.Add(1, "January");
            months.Add(2, "February");

            //Use the generic dictionary's TryGetValue method to attempt to grab
            //a value in the dictionary by a particular key
            string september;
            months.TryGetValue(9, out september);






            foreach(string item in stringList)
            {
                Console.WriteLine(item);
            }

            foreach(Employee emp in empList)
            {
                Console.WriteLine(emp.Name);
            }

            Console.ReadLine();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
    }
}
