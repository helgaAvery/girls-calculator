﻿using System;

namespace CalcGirl.Single
{
    public class Sqrt : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}