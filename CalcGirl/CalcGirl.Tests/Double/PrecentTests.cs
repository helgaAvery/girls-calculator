using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class PrecentTests
    {
        /// <summary>
        /// Тест для функции вычисления процента
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>
        [TestCase(12,100,12)]
        [TestCase(85, 456, 387.6)]
        public void PercentTest(double first, double second, double expected)
        {
            ICalculator calculator = new Percent();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}