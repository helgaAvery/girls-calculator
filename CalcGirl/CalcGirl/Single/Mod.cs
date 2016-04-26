using System;

namespace CalcGirl.Single
{
    public class Mod : ISingleCalculator
    {
        /// <summary>
        /// Функция вычисления модуля числа
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}