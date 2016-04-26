using CalcGirl.Single;
using NUnit.Framework;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class ExpTests
    {
        /// <summary>
        /// Тест для функции возведения экспаненты в любую степень
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(0, 1)]
        public void ExpTest(double first, double expected)
        {
            ISingleCalculator calculator = new Exp();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}