using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenelejatszo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathLbl.Text = openFileDialog1.FileName;
            }
            player.URL = pathLbl.Text;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }
    }
}
