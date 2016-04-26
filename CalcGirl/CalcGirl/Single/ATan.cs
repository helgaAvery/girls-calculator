using System;

namespace CalcGirl.Single
{
    public class ATan : ISingleCalculator
    {
        /// <summary>
        /// Функция вычисляющая арктангенс
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}