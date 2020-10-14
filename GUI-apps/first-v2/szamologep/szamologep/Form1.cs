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
        }

        private static double result = 0;
        private static string operatorClicked = "";
        private static bool isOperatorclicked = false;

        private void nrClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultBox.Text != "0" && (!isOperatorclicked))
            {
                if (button.Text != ".")
                {
                    resultBox.Text += button.Text;
                    isOperatorclicked = false;
                }
                else
                {
                    if (!resultBox.Text.Contains("."))
                    {
                        resultBox.Text += button.Text;
                        isOperatorclicked = false;
                    }
                }
            }
            else
            {
                resultBox.Clear();
                resultBox.Text = button.Text;
                isOperatorclicked = false;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            result = 0;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operatorClicked = button.Text;
            }else
            {
                operatorClicked = button.Text;
                result = Double.Parse(resultBox.Text);
            }
            isOperatorclicked = true;
            operatorClicked = button.Text;
            result = Double.Parse(resultBox.Text);
        }

        private void operatorEqualClick(object sender, EventArgs e)
        {
            if (resultBox.Text != "0")
            {
                switch (operatorClicked)
                {
                    case "+":
                        resultBox.Text = (result + Double.Parse(resultBox.Text)).ToString();
                        break;
                    case "-":
                        resultBox.Text = (result - Double.Parse(resultBox.Text)).ToString();
                        break;
                    case "*":
                        resultBox.Text = (result * Double.Parse(resultBox.Text)).ToString();
                        break;
                    case "÷":
                        resultBox.Text = (result / Double.Parse(resultBox.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
