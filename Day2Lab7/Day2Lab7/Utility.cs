using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab7
{
    public class Utility
    {
        public static string CleanUserInput(string input)
        {
            return input.ToLower().Trim();
        }
    }
}
