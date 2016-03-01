using System;
using System.Windows.Forms;

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
            double firstInt = Convert.ToDouble(first);
            double secondInt = Convert.ToDouble(second);
            double result;

            switch (((Button)sender).Name)
            {
                case "add": result = firstInt + secondInt; break;
                case "minus": result = firstInt - secondInt; break;
                case "multyply": result = firstInt * secondInt; break;
                case "divide": result = firstInt / secondInt; break;
                default:
                    result = 0; break;
              
            }
            textBox3.Text = result.ToString();

        }
    }
}
