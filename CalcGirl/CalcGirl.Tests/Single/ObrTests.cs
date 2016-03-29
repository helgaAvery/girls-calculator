using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class ObrTests
    {
        [Test]
        public void SimpleTest()
        {
            ISingleCalculator calculator = new Obr();
            double result = calculator.Calculate(5);
            Assert.AreEqual(0.2, result);
        }
    }
}