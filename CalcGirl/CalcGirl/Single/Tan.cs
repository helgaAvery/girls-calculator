using System;

namespace CalcGirl.Single
{
    public class Tan: ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}