using CalcGirl.Double;
using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class lnxTests
    {
        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new lnx();
            double result = calculator.Calculate(2.71);
            Assert.AreEqual(1, result);
        }
    }
} 