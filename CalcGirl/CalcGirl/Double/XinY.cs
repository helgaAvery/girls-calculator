using System;

namespace CalcGirl.Double
{
    public class XinY : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}