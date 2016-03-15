using System;

namespace CalcGirl
{
    public class Cos : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}