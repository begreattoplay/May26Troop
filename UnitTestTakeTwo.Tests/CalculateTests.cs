using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTakeTwo.Tests
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        public void AgeLessThanFive()
        {
            //arrange
            Person peep = PersonMaker("billy", "bob", 6);
            Tax tax = new Tax();
            decimal amountToTax = 100.00m;


            //act
            decimal result = tax.Calculate(peep, amountToTax);


            //assert
            Assert.AreEqual(0, result);


        }

        private static Person PersonMaker(string firstName, string lastName, int age)
        {
            Person peep = new Person()
            {
              FirstName = firstName,
              LastName = lastName,
              Age = age

            };
            return peep;
        }

        [TestMethod]
        public void FirstNameTest()
        {

            //arrange
            Person peep = PersonMaker("james", "Rick", 33);
            Tax tax = new Tax();
            decimal amountToTax = 10.00m;
            //act
            decimal result = tax.Calculate(peep, amountToTax);
            //assert
            Assert.AreEqual(1.60m, result);

        }

        [TestMethod]
        public void TestIfThursday()
        {

            //arrange
            Person peep = PersonMaker("Wayne", "Bradey", 33);
            Tax tax = new Tax();
            decimal amountToTax = 10.00m;
            //act
            decimal result = tax.Calculate(peep, amountToTax);
            //assert
            Assert.AreEqual(0.80m, result);

        }
 

    }
}
