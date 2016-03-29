namespace CalcGirl.Double
{
    public class intDevide : ICalculator
    {
        public double Calculate(double first, double second)
        {
            int a;
            a = (int) (first/second);
            return a;
        }
    }
}