using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(rnd.Next(1000));
            }

            Stopwatch stopwatch = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            stopwatch.Start();

            var grouped = numbers.GroupBy(n => n).Where(g => g.Skip(1).Any()).ToList();

            for (int i = 0; i < grouped.Count; i++)
            {
                var g = grouped[i];
                sb.Append(string.Format("{0} has {1} duplicates{2}", g.Key, g.Count(), Environment.NewLine));
            }

            Console.WriteLine(sb.ToString());

            //foreach (int number1 in numbers)
            //{
            //    int duplicateCount = 0;
            //    foreach (int number2 in numbers)
            //    {
            //        if (number1 == number2)
            //        {
            //            duplicateCount++;
            //        }
            //    }
            //    Console.WriteLine("{0} has {1} duplicates", number1, duplicateCount);
            //}

            stopwatch.Stop();
            Console.WriteLine("Total time is {0} miliseconds.", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
