using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab2
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;
        public int Age 
        { 
            get
            {
                return _age;
            }
            set
            {
                _age = value < 0 ? 0 : value;

                //Refactor to use one line
                if (value < 0)
                    _age = 0;
                else
                    _age = value;
            }
        }
        public DateTime BirthDate { get; set; }

        public Customer(int age)
        {
            _age = age;
        }
    }
}
