using System;

namespace CalcGirl
{
    public class Sqrt : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}