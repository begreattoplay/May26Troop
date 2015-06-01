using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = "Everything is Awesome!";
            string revMessage = message.TinkerBell();
            Console.WriteLine(revMessage);
            Console.WriteLine(("Today is Monday").TinkerBell());


            message.TinkerBell().WriteColor(ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta);


            Console.ReadLine();
        }
    }

    public static class StringExtensions
    {
        public static string TinkerBell(this string stringToExtend)
        {
            char[] textArray = stringToExtend.ToCharArray();
            Array.Reverse(textArray);
            return new String(textArray);
        }

        public static void WriteColor(this string stringToExtend, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(stringToExtend);
        }
    }

    public class StringUtility
    {
        public static string Reverse(string text)
        {
            char[] textArray = text.ToCharArray();
            Array.Reverse(textArray);
            return new String(textArray);
        }
    }
}
