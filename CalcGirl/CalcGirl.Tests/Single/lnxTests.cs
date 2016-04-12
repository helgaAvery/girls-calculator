using CalcGirl.Double;
using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class lnxTests
    {
        [TestCase(2.71, 1)]
        [TestCase(10,0.2)]
        [TestCase(7.3441, 0.5)]
        [TestCase(0, 87)]
        public void LnXTest(double first, double expected)
        {
            ISingleCalculator calculator = new lnx();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
} 