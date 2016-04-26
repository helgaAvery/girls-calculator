using System;
using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class LogTests
    {
        /// <summary>
        /// Тест для функции извлечения логарифма
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>
        [TestCase(2, 4, 0.5)]
        [TestCase(7, 49, 0.5)]
      
        public void LogTest(double first, double second, double expected)
        {
            ICalculator calculator = new Log();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Проверка на исключение: отрицательное число
        /// </summary>
        [Test]
        public void NegativeTest()
        {
            ICalculator calculator = new Log();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(3 ,-2));
            
        }
    }
}