using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab2
{
    public class Math
    {
        //public int AddNumbers(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        public int AddNumbers(params int[] numbers)
        {
            int result = 0;
            foreach(var num in numbers)
            {
                result += num;
            }

            return result;
        }

        //TODO: multiple number of parameters
    }
}
