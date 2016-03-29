using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class OstTests
    {

        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new Ost();
            double result = calculator.Calculate(7,4);
            Assert.AreEqual(3, result);
        }
    }
}