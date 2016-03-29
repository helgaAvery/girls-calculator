using System;

namespace CalcGirl.Single
{
    public class lnx : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(2.71, first);
        }
    }
}