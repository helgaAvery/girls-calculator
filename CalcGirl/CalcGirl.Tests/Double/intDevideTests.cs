using CalcGirl.Double;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalcGirl.Tests.Double
{
    [TestFixture()]
    public class intDevideTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new IntDevide();
            double result = calculator.Calculate(7,4);
            Assert.AreEqual(1, result);
        }
    }
}