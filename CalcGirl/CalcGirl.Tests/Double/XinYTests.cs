using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class XinYTests
    {
        /// <summary>
        /// Тест для функции возведения числа в любую степень
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>
       [TestCase(5, 6, 15625)]
        [TestCase(2, 3, 8)]
        public void XinYTest(double first, double second, double expected)
        {
            ICalculator calculator = new XinY();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}