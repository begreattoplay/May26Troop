using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10p2.Animals
{
    public class Eagle : Animal, IAnimal
    {
        public Eagle()
        {
            this.Name = "Eagle";
        }

        public string MakeSound()
        {
            return "wooo Eagle";
        }
    }
}
