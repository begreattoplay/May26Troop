using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                EndDate = null,
                StartDate = DateTime.Parse("2015-05-28"),
                Name = "Nick"
            };

            //int years;

            //years = emp.NumOfYears.GetValueOrDefault(-10);
            //emp.EndDate = emp.EndDate.GetValueOrDefault(DateTime.Now);

            int? num1 = TryParseAsInt("89898");
            Debug.Assert(num1 == 89898);

            int? num2 = TryParseAsInt("I am not a number");
            Debug.Assert(num2 == null);

            int? num3 = TryParseAsInt("6.5");
            Debug.Assert(num3 == null);
        }

        public static int? TryParseAsInt(string value)
        {
            try
            {
                return int.Parse(value);
            }
            catch
            {

            }

            return null;
        }
    }
}
