using System;

namespace CalcGirl.Single
{
    public class Cos : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}