using System;

namespace CalcGirl
{
    public class Sin : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}