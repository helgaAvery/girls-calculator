using System;

namespace CalcGirl.Single
{
    public class Sqrt : ISingleCalculator
    {
        /// <summary>
        /// Функция извлекает корень из числа
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new ArgumentException("Число под корнем не может быть отрицательным", "first");
            }
            return Math.Sqrt(first);
        }
    }
}