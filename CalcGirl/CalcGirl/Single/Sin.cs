using System;

namespace CalcGirl.Single
{
    public class Sin : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}