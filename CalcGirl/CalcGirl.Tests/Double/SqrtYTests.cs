using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class SqrtYTests
    {
        [TestCase(9, 2, 3)]
        [TestCase(25, 2, 5)]
        public void SqrtYTest(double first, double second, double expected)
        {
            ICalculator calculator = new SqrtY();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}