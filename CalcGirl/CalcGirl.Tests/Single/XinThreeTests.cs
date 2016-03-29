using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class XinThreeTests
    {
        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new XinThree();
            double result = calculator.Calculate(2);
            Assert.AreEqual(8, result);
        }
    }
}