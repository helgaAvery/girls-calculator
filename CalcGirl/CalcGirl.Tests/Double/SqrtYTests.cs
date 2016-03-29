using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class SqrtYTests
    {

        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new SqrtY();
            double result = calculator.Calculate(8, 3);
            Assert.AreEqual(2, result);
        }
    }
}