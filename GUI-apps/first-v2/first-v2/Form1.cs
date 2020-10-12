using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void gomb_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter > 1)
            {
                lbl_hello.Text = "Már üdvözöltelek :(";
            }
            else
            {
                lbl_hello.Text = "Légy Üdvözölve!";
            }
        }
    }
}
