using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class LogTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(8,2);
            Assert.AreEqual(3, result);
        }
    }
}