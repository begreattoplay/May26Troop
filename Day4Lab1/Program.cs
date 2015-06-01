using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Lab1
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args")]
        static void Main(string[] args)
        {
            var PRODUCT1 = new product();
        }
    }

    public class product
    {
        public int unitsInStock { get; set; }
    }
}
