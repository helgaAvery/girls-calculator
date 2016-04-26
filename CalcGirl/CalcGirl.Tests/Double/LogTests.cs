using System;
using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(2, 4, 0.5)]
        [TestCase(7, 49, 0.5)]
      
        public void LogTest(double first, double second, double expected)
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NegativeTest()
        {
            ICalculator calculator = new Log();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(3 ,-2));
            
        }
    }
}