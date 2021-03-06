﻿using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class AddTests
    {
        /// <summary>
        /// Тест для функции сложения
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>
        [TestCase(2,2,4)]
        [TestCase(156.5, -345.5, -189)]
        public void AddTest(double first, double second, double expected)
        {
            ICalculator calculator = new Add();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}