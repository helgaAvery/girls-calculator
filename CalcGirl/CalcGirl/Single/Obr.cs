using System;

namespace CalcGirl.Single
{
    public class Obr : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return 1/first;
        }
    }
}