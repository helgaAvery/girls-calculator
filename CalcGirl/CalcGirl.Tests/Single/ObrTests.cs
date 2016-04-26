using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class ObrTests
    {
        /// <summary>
        /// Тест для функции вычисления обратного числа
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(2, 0.5)]
        [TestCase(4,0.25)]
        public void ObrTest(double first, double expected)
        {
            ISingleCalculator calculator = new Obr();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}