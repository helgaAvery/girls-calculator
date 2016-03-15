using System;

namespace CalcGirl.Single
{
    public class Log10 : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}