using System;

namespace CalcGirl.Single
{
    /// <summary>
    /// Функция вычисления косинуса
    /// </summary>
    public class Cos : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}