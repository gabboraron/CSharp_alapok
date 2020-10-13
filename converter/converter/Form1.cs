using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            float cl;
            float l;
            if (boxCl.Text != "")
            {
                cl = Convert.ToInt32(boxCl.Text);
                l = cl / 100;

                boxL.Text = l.ToString();

                ErrorText.Text = "";
            }
            else if (boxL.Text != "")
            {
                l = Convert.ToInt32(boxL.Text);
                cl = l * 100;

                boxCl.Text = cl.ToString();

                ErrorText.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxCl.Text = "";
            boxL.Text = "";
        }
    }
}
