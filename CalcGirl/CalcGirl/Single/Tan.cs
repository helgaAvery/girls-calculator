using System;

namespace CalcGirl.Single
{
    public class Tan: ISingleCalculator
    {
        /// <summary>
        /// Функция вычисления тангенса числа
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}