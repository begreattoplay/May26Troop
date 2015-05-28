using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LastFirstComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee employee1 = x as Employee;
            Employee employee2 = y as Employee;

            return employee1.LastName.CompareTo(employee2.LastName) == 0 
                ? 0 
                : employee1.FirstName.CompareTo(employee2.FirstName);
        }
    }
}
