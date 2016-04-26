﻿using System;

namespace CalcGirl.Single
{
    public class lnx : ISingleCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new ArgumentException("Число под логарифмом не может быть отрицательным", "first");
            }
            return Math.Log(2.71, first);
        }
    }
}