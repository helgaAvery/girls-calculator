using System;

namespace CalcGirl.Double
{
    public class XinY : ICalculator
    {
        /// <summary>
        /// Функция возведения любого числа в любую степень
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}