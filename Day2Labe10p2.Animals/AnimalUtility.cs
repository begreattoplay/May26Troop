using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10p2.Animals
{
    public class AnimalUtility
    {
        public static void DoSomething(IAnimal animal)
        {
            Console.WriteLine("The {0} says {1}", animal.Name, animal.MakeSound());
        }
    }
}
