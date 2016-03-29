using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class Power10XTests
    {
        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new Power10X();
            double result = calculator.Calculate(3);
            Assert.AreEqual(1000, result);
        }
    }
}