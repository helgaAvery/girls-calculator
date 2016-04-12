using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(2, 4, 0.5)]
        [TestCase(5, 7, 0.827087475346916)]
        [TestCase(7, 49, 0.5)]
        [TestCase(0, 56, 0)]
        public void LogTest(double first, double second, double expected)
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}