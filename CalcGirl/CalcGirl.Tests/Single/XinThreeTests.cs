using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class XinThreeTests
    {
        [TestCase(2,8)]
        [TestCase(5,125)]
        public void XinThreeTest(double first, double expected)
        {
            ISingleCalculator calculator = new XinThree();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}