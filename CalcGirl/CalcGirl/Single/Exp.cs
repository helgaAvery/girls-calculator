using System;

namespace CalcGirl.Single
{
    public class Exp : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}