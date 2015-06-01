using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxRules.Tests
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TestCalculateAgeLessFive()
        {
            //Arrange
            Tax tax = new Tax(new ErehwonCitizen
            {
                BirthDate = DateTime.Parse("2010-06-01"),
                FirstName = "Test",
                LastName = "Person"
            });
            //Act
            decimal taxAmount = tax.Calculate(100);

            //Assert
            Assert.AreEqual(0, taxAmount);
        }

        [TestMethod]
        public void TestCalculateTodayIsThursday()
        {
            DateTime nextThursday = DateTime.Now;
            for (var i = 1; i < 8; i++)
            {
                if (nextThursday.DayOfWeek == DayOfWeek.Thursday)
                    return;

                nextThursday = nextThursday.AddDays(i);
            }

            Tax tax = new Tax(new ErehwonCitizen
            {
                BirthDate = DateTime.Parse("1999-04-30"),
                FirstName = "Test",
                LastName = "Person"
            }, nextThursday);

            //Act
            decimal taxAmount = tax.Calculate(100);

            //Assert
            Assert.AreEqual(16m, taxAmount);
        }
    }
}
