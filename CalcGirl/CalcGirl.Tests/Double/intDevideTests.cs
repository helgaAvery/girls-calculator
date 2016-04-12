using CalcGirl.Double;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalcGirl.Tests.Double
{
    [TestFixture()]
    public class intDevideTests
    {
        [TestCase(7, 4, 1)]
        [TestCase(0, 56, 0)]
        public void IntDevideTest(double first, double second, double expected)
        {
            ICalculator calculator = new IntDevide();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}