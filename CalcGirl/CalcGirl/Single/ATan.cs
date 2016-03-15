using System;

namespace CalcGirl.Single
{
    public class ATan : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}