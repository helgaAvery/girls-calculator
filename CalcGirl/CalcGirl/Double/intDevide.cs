namespace CalcGirl.Double
{
    public class IntDevide : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return (int) (first/second);
        }
    }
}