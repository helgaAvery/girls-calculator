﻿using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class Power10XTests
    {
        /// <summary>
        /// Тест для функции возведения десяти в любую степень
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(3, 1000)]
        [TestCase(5, 100000)]
        public void Power10XTest(double first, double expected)
        {
            ISingleCalculator calculator = new Power10X();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}