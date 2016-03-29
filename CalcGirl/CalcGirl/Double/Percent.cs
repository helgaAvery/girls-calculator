namespace CalcGirl.Double
{
    public class Percent : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second / 100;
        }
    }
}