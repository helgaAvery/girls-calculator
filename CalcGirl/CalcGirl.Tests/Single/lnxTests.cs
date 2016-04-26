using System;
using CalcGirl.Double;
using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class lnxTests
    {
        [TestCase(2.71, 1)]
        [TestCase(7.3441, 0.5)]
        public void LnXTest(double first, double expected)
        {
            ISingleCalculator calculator = new lnx();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NegativeLnXTest()
        {
            ISingleCalculator calculator = new lnx();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-4));
        }
    }

} 