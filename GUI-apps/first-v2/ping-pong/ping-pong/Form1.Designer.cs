namespace ping_pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.rocketLabel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playground.Controls.Add(this.gameoverLabel);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.rocketLabel);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(953, 576);
            this.playground.TabIndex = 0;
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameoverLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.Location = new System.Drawing.Point(266, 187);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(358, 178);
            this.gameoverLabel.TabIndex = 5;
            this.gameoverLabel.Text = "Játék vége!\r\n\r\nF1 - Új játék\r\nEsc - kilépés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pontszám: ";
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_lbl.Location = new System.Drawing.Point(148, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(26, 29);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Maroon;
            this.ball.Location = new System.Drawing.Point(266, 127);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // rocketLabel
            // 
            this.rocketLabel.BackColor = System.Drawing.Color.Coral;
            this.rocketLabel.Location = new System.Drawing.Point(293, 554);
            this.rocketLabel.Name = "rocketLabel";
            this.rocketLabel.Size = new System.Drawing.Size(200, 10);
            this.rocketLabel.TabIndex = 1;
            this.rocketLabel.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 576);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ping-pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox rocketLabel;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

