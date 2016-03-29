namespace CalcGirl.Double
{
    public class Procent : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return ((first)/100)*second;
        }
    }
}