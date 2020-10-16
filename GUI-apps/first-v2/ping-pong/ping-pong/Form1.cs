using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class Form1 : Form
    {

        private static int speed_left = 4;
        private static int speed_top = 4;
        private static int points = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            rocketLabel.Top = playground.Bottom - playground.Bottom / 10;

            gameoverLabel.Left = (playground.Width / 2) - (playground.Width / 2);
            gameoverLabel.Top = (playground.Height/ 2) - (playground.Height / 2);
            gameoverLabel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rocketLabel.Left = Cursor.Position.X - (rocketLabel.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= rocketLabel.Top && ball.Bottom<= rocketLabel.Bottom && ball.Left>=rocketLabel.Left && ball.Right <=rocketLabel.Right)
            {
                speed_top += 2;
                speed_left += 2;

                speed_top = -speed_top;
                points += 1;
                points_lbl.Text = points.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 225), r.Next(150, 225), r.Next(150, 225));

            }

            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }

            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            /*
            if (ball.Top >= playground.Top)
            {
                speed_left = -speed_left;
            }*/

            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameoverLabel.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameoverLabel.Visible = false;
                playground.BackColor = Color.White;
            }
        }
    }
}