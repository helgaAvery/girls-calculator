using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class SqrtTests
    {

        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new Sqrt();
            double result = calculator.Calculate(4);
            Assert.AreEqual(2, result);
        }
    }
}