using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new Add();
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}