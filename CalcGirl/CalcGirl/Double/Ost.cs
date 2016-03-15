namespace CalcGirl.Double
{
    public class Ost : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first%second;
        }
    }
}