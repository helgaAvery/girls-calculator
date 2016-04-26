using CalcGirl.Single;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalcGirl.Tests.Single
{
    [TestFixture()]
    public class XinxTests
    {
        /// <summary>
        /// Тест для функции возведения любого числа в квадрат
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(2, 4)]
        [TestCase(5, 25)]
        public void XinxTest(double first, double expected)
        {
            ISingleCalculator calculator = new Xinx();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}