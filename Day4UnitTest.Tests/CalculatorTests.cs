using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day4UnitTest.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.AddNumbers(5, 0);

            //Assert
            Assert.AreEqual(5, result, "You can't do math this didn't work");
        }
    }
}
