using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep
{
    public partial class btnSeven : Form
    {
        public btnSeven()
        {
            InitializeComponent();
            resultBox.Enabled = false;
        }

        private float firstNumber;
        private float secondNumber;
        private float result;

        private void add_Click(object sender, EventArgs e)
        {
            firstNumber  = Convert.ToInt32(first.Text);
            secondNumber = Convert.ToInt32(second.Text);
            result = firstNumber + secondNumber;
            resultBox.Text = result.ToString();
        }

        private void substract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(first.Text);
            secondNumber = Convert.ToInt32(second.Text);
            result = firstNumber - secondNumber;
            resultBox.Text = result.ToString();
        }

        private void times_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(first.Text);
            secondNumber = Convert.ToInt32(second.Text);
            result = firstNumber * secondNumber;
            resultBox.Text = result.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(first.Text);
            secondNumber = Convert.ToInt32(second.Text);
            result = firstNumber / secondNumber;
            resultBox.Text = result.ToString();
        }

        private void squeereroot_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(first.Text);
            secondNumber = Convert.ToInt32(second.Text);
            try
            {
                result = Convert.ToInt32(Math.Pow(secondNumber, 1.0 / firstNumber));
                resultBox.Text = result.ToString();
            }
            catch (Exception)
            {
                resultBox.Text = "ERROR";
            }

        }

        private void power_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(first.Text);
            secondNumber = Convert.ToInt32(second.Text);
            try
            {
                result = Convert.ToInt32(Math.Pow(secondNumber, firstNumber));
                resultBox.Text = result.ToString();
            }
            catch (Exception)
            {
                resultBox.Text = "ERROR";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            first.Text = "0";
            second.Text = "0";
            resultBox.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
        }
    }
}
