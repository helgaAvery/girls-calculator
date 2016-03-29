using System;

namespace CalcGirl.Single
{
    public class in10x : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}