using System;

namespace CalcGirl.Double
{
    public class SqrtY : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, (1/second));
        }
    }
}