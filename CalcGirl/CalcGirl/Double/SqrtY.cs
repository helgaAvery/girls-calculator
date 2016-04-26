using System;

namespace CalcGirl.Double
{
    public class SqrtY : ICalculator
    {
        /// <summary>
        /// Функция извлечения любого корня
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (first < 0)
            {
                throw new ArgumentException("Число под корнем не может быть отрицательным", "first");
            }
            return Math.Pow(first, 1 / second);
        }
    }
}