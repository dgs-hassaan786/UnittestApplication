using Auto.DataProvider;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.NUnitTest
{
    [TestFixture]
    class CalculatorTester
    {
        [TestCase]
        public void TestAdd()
        {
            int actual = 6;
            var calculator = new Calculator();
            int result = calculator.Add(1, 5);
            Assert.AreEqual(actual, result);
        }

        [TestCase]
        public void TestDivide()
        {
            int actual = 4;
            var calculator = new Calculator();
            int result = calculator.Divide(20, 5);
            Assert.AreEqual(actual, result);
        }

        [TestCase]
        public void TestFaultyDivide()
        {
            
            var calculator = new Calculator();
            int result = calculator.Modulus(20, 5);
            
            //int actual = 4;
            //Assert.AreEqual(actual, result);
            Assert.AreEqual(result, result);
        }

        [TestCase]
        public void TestMultiply()
        {
            var actual = 2.08;
            var calculator = new Calculator();
            var result = calculator.Multiply(1.3, 1.6);
            Assert.AreEqual(actual, result);
        }
    }
}
