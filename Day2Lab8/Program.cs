using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            UsedCar nicksCar = new UsedCar();
            nicksCar.Model = "Accord";

            CertifiedUsedCar certCar = new CertifiedUsedCar();
            certCar.Model = "Camry";

            NewCar tesla = new NewCar();
            tesla.Model = "Tesla Model S";


            Car[] cars = new Car[] { nicksCar, tesla, certCar };

            foreach(Car car in cars)
            {
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Price);
                Console.WriteLine(car.VIN);

                if (car is CertifiedUsedCar)
                {
                    CertifiedUsedCar cert = car as CertifiedUsedCar;

                    Console.WriteLine("Your car type is: {0}", cert.GetType().Name);
                    Console.WriteLine(cert.Miles);
                    Console.WriteLine(cert.WarrantyMonths);
                }
                else if (car is UsedCar)
                {
                    UsedCar used = car as UsedCar;

                    Console.WriteLine("Your car type is: {0}", used.GetType().Name);
                }
                else if (car is NewCar)
                {
                    NewCar newCar = car as NewCar;

                    Console.WriteLine("Your car type is: {0}", newCar.GetType().Name);
                }

                Console.WriteLine("----------");
            }

            Console.ReadLine();
        }
    }


    public class NewCar : Car
    {

    }

    public class UsedCar : Car
    {
        public int Miles { get; set; }
    }

    public class CertifiedUsedCar: UsedCar
    {
        public int WarrantyMonths { get; set; }
    }

    public abstract class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
