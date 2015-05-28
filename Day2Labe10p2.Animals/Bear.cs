using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10p2.Animals
{
    public class Bear : Animal, IAnimal
    {
        public Bear()
        {
            this.Name = "Bear";
            
        }
        public string MakeSound()
        {
            return "Roar!";
        }
    }
}
