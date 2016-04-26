using System;

namespace CalcGirl.Single
{
    public class XinThree : ISingleCalculator
    {
        /// <summary>
        /// Функция возведения числа в куб
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(first,3);
        }
    }
}