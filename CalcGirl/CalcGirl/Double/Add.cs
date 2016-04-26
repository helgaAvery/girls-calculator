namespace CalcGirl.Double
{
    public class Add: ICalculator
    {
        /// <summary>
        /// Функция сложения
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
