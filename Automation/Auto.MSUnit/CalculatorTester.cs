using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Auto.DataProvider;

namespace Auto.MSUnit
{
    [TestClass]
    public class CalculatorTester
    {
        [TestMethod]
        public void TestAdd()
        {
            int actual = 6;
            var calculator = new Calculator();
            int result = calculator.Add(1, 5);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            int actual = 4;
            var calculator = new Calculator();
            int result = calculator.Divide(20,5);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void TestFaultyDivide()
        {
            int actual = 4;
            var calculator = new Calculator();
            int result = calculator.Modulus(20, 5);
            Assert.AreEqual(actual, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var actual = 2.08;
            var calculator = new Calculator();
            var result = calculator.Multiply(1.3, 1.6);
            Assert.AreEqual(actual, result);
        }
    }
}
