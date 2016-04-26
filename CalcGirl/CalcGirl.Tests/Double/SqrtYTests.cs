using System;
using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class SqrtYTests
    {
        /// <summary>
        /// Тест для функции извлечения корня любой степени
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>
        [TestCase(9, 2, 3)]
        [TestCase(25, 2, 5)]
        public void SqrtYTest(double first, double second, double expected)
        {
            ICalculator calculator = new SqrtY();

            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Проверка на исключение: отрицательное число
        /// </summary>
         [Test]
        public void NegativeYTest()
        {
            ICalculator calculator = new SqrtY();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-4, 2));
        }
    }
}