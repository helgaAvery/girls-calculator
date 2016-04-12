using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]
        [TestCase(10, 22026, 4)]
        [TestCase(6,4)]
        [TestCase(34, 0.897)]
        public void ExpTest(double first, double expected)
        {
            ISingleCalculator calculator = new Exp();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}