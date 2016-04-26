using System;
using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class SqrtTests
    {

        [TestCase(4, 2)]
        [TestCase(25, 5)]
        public void SqrtTest(double first, double expected)
        {
            ISingleCalculator calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void NegativeSqrtTest()
        {
            ISingleCalculator calculator = new Sqrt();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-2));
        }
    }

}