using System;

namespace CalcGirl.Single
{
    public class Sin : ISingleCalculator
    {
        /// <summary>
        /// Функция вычисления синуса числа
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}