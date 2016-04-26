using System;

namespace CalcGirl.Single
{
    public class Xinx : ISingleCalculator
    {
        /// <summary>
        /// Функция возведения числа в квадрат
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}