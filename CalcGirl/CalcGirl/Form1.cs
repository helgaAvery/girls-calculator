using System;
using System.Windows.Forms;
using CalcGirl.Double;
using CalcGirl.Single;

namespace CalcGirl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public void Calculate (object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            double firstDouble = Convert.ToDouble(first);
            double secondDouble = Convert.ToDouble(second);
            double result;

            ICalculator calc = CalculatorFactory.CreateCalculator(((Button) sender).Name);
            result = calc.Calculate(firstDouble, secondDouble);
            textBox3.Text = result.ToString();

        }

        public void SingleCalculate(object sender, EventArgs e)
        {
            string first = textBox1.Text;
           double firstDouble = Convert.ToDouble(first);
            double result;

            ISingleCalculator calc = CalculatorSingleFactory.CreateCalculator(((Button)sender).Name);
            result = calc.Calculate(firstDouble);
            textBox3.Text = result.ToString();

        }
    }
}
