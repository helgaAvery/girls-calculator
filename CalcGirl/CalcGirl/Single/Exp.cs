using System;

namespace CalcGirl.Single
{
    /// <summary>
    /// Функция возведения экспаненты в любую степень
    /// </summary>
    public class Exp : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}