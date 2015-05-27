using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Day1Lab1
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Day 1: Lab 3, 4, 5 (010103, 010104, 010105)            
            //SmtpClient client = new SmtpClient();

            //MailMessage message = new MailMessage();
            //MailMessage message2 = message;

            //message.Subject = "Hello haha";
            //Console.WriteLine(message2.Subject);
            //message2.Subject = "got ya";
            //Console.WriteLine(message.Subject);
            ////client.Send(message);

            //Value types (structs) do not pass by REFERENCE but by VALUE (it makes copies)
            //int number = 4;
            //int number2 = number;
            //number = 6; //number2 will stil equal 4!
            
            //String formatting
            //Console.WriteLine(DateTime.Now.ToString("yy-mm-dd hh:mm"));

            //Object instantiation (Create an object from a class)
            //Random rnd = new Random(); //Creates a new instance of the Random type and stores a reference to it in rnd
            //var result = rnd.Next(10);
            //Console.WriteLine(result);

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            int num = 0;

            if (int.TryParse(input, out num))
            {
                int doubledNumber = num + num;
                Console.WriteLine(doubledNumber);
            }
            else
            {
                Console.WriteLine("Sorry, your entry was not a number!");
            }

            //try
            //{
            //    int num = int.Parse(input);
            //    int doubledNumber = num + num;
            //    Console.WriteLine(doubledNumber);
            //}
            //catch
            //{
            //    Console.WriteLine("Sorry, your entry was not a number!");
            //}

            var name = "Nick";
            var favoriteColor = "Blue";
            var myString = string.Format("Hello {0}.  You're {1}", name, favoriteColor);
            Console.WriteLine(myString);
            //if (File.Exists("HelloWorld.txt"))
            //{
            //    Console.WriteLine("I found it!");
            //}

            //Objects and passing by reference practice
            MailMessage message = new MailMessage();
            MailMessage message2 = message;
            message.Subject = "Starting subject";

            //Write subject before
            Console.WriteLine(message.Subject);

            //Change it
            ChangeSubject(message);

            //Write subject after
            Console.WriteLine(message2.Subject);

            Console.ReadLine();
        }

        //Method practicing changing an object's properties (passing by reference)
        public static void ChangeSubject(MailMessage peanutButter)
        {
            peanutButter.Subject = "This is the new subject";
        }
    }
}
