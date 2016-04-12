using CalcGirl.Single;
using NUnit.Framework;
using NUnit.Framework.Internal.Builders;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class AtanTests
    {
        [TestCase(0,0)]
        public void ATanTest(double first, double expected)
        {
          
            ISingleCalculator calculator = new ATan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
            
        }
    }
}