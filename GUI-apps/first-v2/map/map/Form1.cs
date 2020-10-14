using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder querryData = new StringBuilder();
                querryData.Append("https://maps.google.com/maps?q=");


                if (city.Text != string.Empty)
                {
                    querryData.Append(Convert.ToString(city.Text) + ",+");
                }

                if (street.Text != string.Empty)
                {
                    querryData.Append(Convert.ToString(street.Text) + ",+");
                }

               /* if (zipnumber.Text != string.Empty)
                {
                    querryData.Append(Convert.ToString(zipnumber.Text) + ",+");
                }*/

                if (country.Text != string.Empty)
                {
                    querryData.Append(Convert.ToString(country.Text) + ",+");
                }
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate(querryData.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "ERROR");
                throw;
            }
        }
    }
}
