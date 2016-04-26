using CalcGirl.Single;
using NUnit.Framework;
using NUnit.Framework.Internal.Builders;

namespace CalcGirl.Tests.Single
{
    [TestFixture]
    public class AtanTests
    {
        /// <summary>
        /// Тест для функции вычисления арктангенса
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(0,0)]
        public void ATanTest(double first, double expected)
        {
          
            ISingleCalculator calculator = new ATan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
            
        }
    }
}