﻿using System;
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
            double firstInt = Convert.ToDouble(first);
            double secondInt = Convert.ToDouble(second);
            double result = firstInt + secondInt;
            textBox3.Text = result.ToString();

        }

        private void multyply(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            double firstInt = Convert.ToDouble(first);
            double secondInt = Convert.ToDouble(second);
            double result = firstInt * secondInt;
            textBox3.Text = result.ToString();
        }

        private void minus(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            double firstInt = Convert.ToDouble(first);
            double secondInt = Convert.ToDouble(second);
            double result = firstInt - secondInt;
            textBox3.Text = result.ToString();
        }

        private void divide(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            double firstInt = Convert.ToDouble(first);
            double secondInt = Convert.ToDouble(second);
            double result = firstInt / secondInt;
            textBox3.Text = result.ToString();
            //textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
        }
    }
}
