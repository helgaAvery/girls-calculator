using System;

namespace CalcGirl.Single
{
    public class Xinx : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}