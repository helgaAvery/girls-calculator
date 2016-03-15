using System;

namespace CalcGirl.Single
{
    public class XinThree : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,3);
        }
    }
}