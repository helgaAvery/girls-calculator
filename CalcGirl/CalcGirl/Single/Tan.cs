using System;

namespace CalcGirl
{
    public class Tan: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}