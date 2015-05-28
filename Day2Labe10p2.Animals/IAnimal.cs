using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10p2.Animals
{
    public interface IAnimal
    {
        string Name { get; set; }
        string MakeSound();
    }
}
