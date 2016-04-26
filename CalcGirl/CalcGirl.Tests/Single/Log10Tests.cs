using System;
using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class Log10Tests
    {
        [TestCase(10, 1)]

        public void Log10Test(double first, double expected)
        {
            ISingleCalculator calculator = new Log10();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);

            
        }
        [Test]
        public void NegativeLn10XTest()
        {
            ISingleCalculator calculator = new Log10();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-1));
        }
    }
}