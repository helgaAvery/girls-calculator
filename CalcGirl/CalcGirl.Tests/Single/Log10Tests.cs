using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class Log10Tests
    {
        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new Log10();
            double result = calculator.Calculate(1000);
            Assert.AreEqual(3, result);
        }
    }
}