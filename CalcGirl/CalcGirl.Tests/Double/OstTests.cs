﻿using CalcGirl.Double;
using NUnit.Framework;

namespace CalcGirl.Tests.Double
{
    [TestFixture]
    public class OstTests
    {
        /// <summary>
        /// Тест для функции вычисления остатка от деления
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>

        [TestCase(7, 4, 3)]
        [TestCase(86, 7,2)]
        [TestCase(0, 56, 0)]
        public void OstTest(double first, double second, double expected)
        {
            ICalculator calculator = new Ost();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}