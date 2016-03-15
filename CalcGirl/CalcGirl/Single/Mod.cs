using System;

namespace CalcGirl.Single
{
    public class Mod : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}