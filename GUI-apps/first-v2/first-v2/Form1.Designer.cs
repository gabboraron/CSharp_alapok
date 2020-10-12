namespace first_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gomb = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gomb
            // 
            this.gomb.Location = new System.Drawing.Point(343, 336);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(94, 29);
            this.gomb.TabIndex = 0;
            this.gomb.Text = "gombocska";
            this.gomb.UseVisualStyleBackColor = true;
            this.gomb.Click += new System.EventHandler(this.gomb_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_hello.Location = new System.Drawing.Point(343, 176);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(50, 20);
            this.lbl_hello.TabIndex = 1;
            this.lbl_hello.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.gomb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.Label lbl_hello;
    }
}

