using System;

namespace CalcGirl.Single
{
    public class Power10X : ISingleCalculator
    {
        /// <summary>
        /// Функция возведения 10 в любую степень
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}