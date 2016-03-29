using CalcGirl.Single;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalcGirl.Tests.Single
{
    [TestFixture()]
    public class XinxTests
    {
        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new Xinx();
            double result = calculator.Calculate(3);
            Assert.AreEqual(9, result);
        }
    }
}