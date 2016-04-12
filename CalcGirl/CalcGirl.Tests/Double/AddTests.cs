using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2,2,4)]
        [TestCase(156.5, -345.5, -189)]
        [TestCase(-0.9, -12, 15)]
        [TestCase(0, 56, -78)]
        public void AddTest(double first, double second, double expected)
        {
            ICalculator calculator = new Add();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}