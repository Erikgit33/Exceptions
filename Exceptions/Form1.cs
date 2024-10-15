using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Divide(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

                if (result == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
                else
                {
                    labelResult.Text = "Result: " + result.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Both the numerator and denominator must be numbers.");
            }
        }

        private static double Divide(double numerator,double denominator)
        {
            double result;
            try
            {
                result = numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }

            return result;
        }
    }
}
