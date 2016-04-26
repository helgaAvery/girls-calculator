using System;

namespace CalcGirl.Single
{
    public class Obr : ISingleCalculator
    {
        /// <summary>
        /// Функция вычисления обратного числа
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return 1/first;
        }
    }
}