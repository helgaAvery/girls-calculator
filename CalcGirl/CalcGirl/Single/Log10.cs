using System;

namespace CalcGirl.Single
{
    public class Log10 : ISingleCalculator
    {
        /// <summary>
        /// Функция вычисления десятичного логарифма
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new ArgumentException("Число под логарифмом не может быть отрицательным", "first");
            }
            return Math.Log10(first);
        }
    }
}