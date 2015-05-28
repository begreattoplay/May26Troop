using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10p2.Animals
{
    public class Chicken : Animal, IAnimal
    {
        public Chicken()
        {
            this.Name = "Chicken";
        }

        public string MakeSound()
        {
            return "Hi I'm a Chicken";
        }
    }
}
