using System;

namespace CalcGirl.Single
{
    public static class CalculatorSingleFactory
    {
        public static ISingleCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin": 
                    return new Sin();
                case "Cos": 
                    return new  Cos();
                case "Sqrt": 
                    return new Sqrt();
                case "Tan":
                    return new Tan();
                case "Mod":
                    return new Mod();
                case "ATan":
                    return new ATan();
                case "Exp":
                    return new Exp();
                case "XinThree":
                    return new XinThree();
                case "Obr":
                    return new Obr();
                case "Log10":
                    return new Log10();



               default: throw new ArgumentException("Упс, неизвестная операция...", "name");

            }
        }
    }
}