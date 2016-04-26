namespace CalcGirl.Double
{
    public class Percent : ICalculator
    {
        /// <summary>
        /// ������� ���������� �������� �� �����
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second / 100;
        }
    }
}