using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class AtanTests
    {

        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new ATan();
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}