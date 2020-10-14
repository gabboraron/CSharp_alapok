namespace szamologep
{
    partial class btnSeven
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.squeereroot = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultBox.Location = new System.Drawing.Point(642, 394);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(484, 148);
            this.resultBox.TabIndex = 15;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.second.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.SystemColors.WindowText;
            this.second.Location = new System.Drawing.Point(642, 211);
            this.second.Multiline = true;
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(484, 148);
            this.second.TabIndex = 19;
            this.second.Text = "0";
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.ForeColor = System.Drawing.SystemColors.WindowText;
            this.first.Location = new System.Drawing.Point(642, 30);
            this.first.Multiline = true;
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(484, 148);
            this.first.TabIndex = 20;
            this.first.Text = "0";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SkyBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(13, 30);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(262, 148);
            this.add.TabIndex = 21;
            this.add.Text = "összeadás";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // substract
            // 
            this.substract.BackColor = System.Drawing.Color.SkyBlue;
            this.substract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substract.Location = new System.Drawing.Point(281, 30);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(262, 148);
            this.substract.TabIndex = 22;
            this.substract.Text = "kivonás";
            this.substract.UseVisualStyleBackColor = false;
            this.substract.Click += new System.EventHandler(this.substract_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.SkyBlue;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(281, 184);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(262, 148);
            this.divide.TabIndex = 24;
            this.divide.Text = "osztás";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.Color.SkyBlue;
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(13, 184);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(262, 148);
            this.times.TabIndex = 23;
            this.times.Text = "szorzás";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.SkyBlue;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(281, 338);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(262, 148);
            this.power.TabIndex = 26;
            this.power.Text = "hatványozás";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // squeereroot
            // 
            this.squeereroot.BackColor = System.Drawing.Color.SkyBlue;
            this.squeereroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squeereroot.Location = new System.Drawing.Point(13, 338);
            this.squeereroot.Name = "squeereroot";
            this.squeereroot.Size = new System.Drawing.Size(262, 148);
            this.squeereroot.TabIndex = 25;
            this.squeereroot.Text = "gyökvonás";
            this.squeereroot.UseVisualStyleBackColor = false;
            this.squeereroot.Click += new System.EventHandler(this.squeereroot_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.SkyBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(13, 492);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(530, 68);
            this.clear.TabIndex = 27;
            this.clear.Text = "tisztít";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(962, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "első szám";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(957, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "második szám";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(637, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "eredmény";
            // 
            // btnSeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1138, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.power);
            this.Controls.Add(this.squeereroot);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.times);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.first);
            this.Controls.Add(this.second);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "btnSeven";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "műveletmegoldó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button substract;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button squeereroot;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

