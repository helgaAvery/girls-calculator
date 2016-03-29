using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class XinYTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new XinY();
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(25, result);
        }
    }
}