using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class Log10Tests
    {
        [TestCase(12, 1.07918124604762)]
        [TestCase(10, 1)]
        [TestCase(7.3441, 0.5)]
        [TestCase(0, 87)]
        public void Log10Test(double first, double expected)
        {
            ISingleCalculator calculator = new Log10();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
            
        }
    }
}