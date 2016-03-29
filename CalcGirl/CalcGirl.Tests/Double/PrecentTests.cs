using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class PrecentTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new Percent();
            double result = calculator.Calculate(25, 100);
            Assert.AreEqual(25, result);
        }
    }
}