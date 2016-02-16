using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGirl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int secondInt = Convert.ToInt32(second);
            double result = firstInt + secondInt;
            textBox3.Text = result.ToString();

        }

        private void multyply(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int secondInt = Convert.ToInt32(second);
            double result = firstInt * secondInt;
            textBox3.Text = result.ToString();
        }

        private void textOne(object sender, EventArgs e)
        {

        }

        private void textTwo(object sender, EventArgs e)
        {

        }

        private void textThree(object sender, EventArgs e)
        {

        }

        private void minus(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            float firstInt = Convert.ToInt32(first);
            float secondInt = Convert.ToInt32(second);
            double result = firstInt - secondInt;
            textBox3.Text = result.ToString();
        }

        private void divide(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int secondInt = Convert.ToInt32(second);
            double result = firstInt / secondInt;
            textBox3.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
