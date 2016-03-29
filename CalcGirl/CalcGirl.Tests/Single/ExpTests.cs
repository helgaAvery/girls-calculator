using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class ExpTests
    {

        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new Exp();
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}