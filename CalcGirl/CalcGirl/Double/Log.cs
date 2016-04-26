using System;

namespace CalcGirl.Double
{
    public class Log : ICalculator
    {
        /// <summary>
        /// Функция извлечения любого логарифма
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (first < 0)
            {
                throw new ArgumentException("Основание логарифма не может быть отрицательным", "first");
            }
            if (second < 0)
            {
                throw new ArgumentException("Число под логарифмом не может быть отрицательным", "second");
            }
            return Math.Log(first,second);
        }
    }
}