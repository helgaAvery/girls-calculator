using System;

namespace CalcGirl.Single
{
    public class Power10X : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}