using Day2Lab10p2.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10p2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create our animal objects but only talk to them by the interface (contract) they signed
            IAnimal eagle = new Eagle();
            IAnimal chicken = new Chicken();
            IAnimal bear = new Bear();

            //Add our animals to an array the only cares about the interface they implement (the contract or the what) not the
            //classes that are really implementing the code inside (the how)
            IAnimal[] animals = new IAnimal[] { eagle, chicken, bear };

            //Call the static DoSomething method on  AnimalUtility passing in each animal
            foreach(var animal in animals)
            {
                AnimalUtility.DoSomething(animal);
            }

            Console.ReadLine();
        }
    }
}
