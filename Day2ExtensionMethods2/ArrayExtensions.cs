using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExtensionMethods2
{
    public static class ArrayExtensions
    {
        //public static string GetRandom(this Array arrayToExtend)
        //{
        //    Random rnd = new Random();
        //    int index = rnd.Next(arrayToExtend.Length);
        //    return arrayToExtend.GetValue(index).ToString();
        //}

        //public static string GetRandom(this string[] arrayToExtend)
        //{
        //    Random rnd = new Random();
        //    int index = rnd.Next(arrayToExtend.Length);
        //    return arrayToExtend[index];
        //}

        public static T GetRandom<T>(this T[] arrayToExtend)
        {
            Random rnd = new Random();
            int index = rnd.Next(arrayToExtend.Length);
            return arrayToExtend[index];
        }
    }
}
