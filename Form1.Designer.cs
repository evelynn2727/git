namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx = new System.Windows.Forms.TextBox();
            this.btnR = new System.Windows.Forms.Button();
            this.tbr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbr2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnR2 = new System.Windows.Forms.Button();
            this.tby = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBł = new System.Windows.Forms.Button();
            this.btnZn = new System.Windows.Forms.Button();
            this.tbS = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X=";
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(82, 36);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(100, 20);
            this.tbx.TabIndex = 1;
            this.tbx.Text = "111011";
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(82, 72);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Oblicz Kody";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(82, 111);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(100, 20);
            this.tbr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "R=";
            // 
            // tbr2
            // 
            this.tbr2.Location = new System.Drawing.Point(362, 111);
            this.tbr2.Name = "tbr2";
            this.tbr2.Size = new System.Drawing.Size(100, 20);
            this.tbr2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "R2=";
            // 
            // btnR2
            // 
            this.btnR2.Location = new System.Drawing.Point(362, 72);
            this.btnR2.Name = "btnR2";
            this.btnR2.Size = new System.Drawing.Size(75, 23);
            this.btnR2.TabIndex = 7;
            this.btnR2.Text = "Oblicz Kody";
            this.btnR2.UseVisualStyleBackColor = true;
            this.btnR2.Click += new System.EventHandler(this.btnR2_Click);
            // 
            // tby
            // 
            this.tby.Location = new System.Drawing.Point(362, 36);
            this.tby.Name = "tby";
            this.tby.Size = new System.Drawing.Size(100, 20);
            this.tby.TabIndex = 12;
            this.tby.Text = "111011";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y=";
            // 
            // btnBł
            // 
            this.btnBł.Location = new System.Drawing.Point(223, 34);
            this.btnBł.Name = "btnBł";
            this.btnBł.Size = new System.Drawing.Size(75, 23);
            this.btnBł.TabIndex = 20;
            this.btnBł.Text = "Błąd";
            this.btnBł.UseVisualStyleBackColor = true;
            this.btnBł.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnZn
            // 
            this.btnZn.Location = new System.Drawing.Point(223, 194);
            this.btnZn.Name = "btnZn";
            this.btnZn.Size = new System.Drawing.Size(75, 23);
            this.btnZn.TabIndex = 25;
            this.btnZn.Text = "Znajdź";
            this.btnZn.UseVisualStyleBackColor = true;
            this.btnZn.Click += new System.EventHandler(this.btnZn_Click);
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(210, 154);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 20);
            this.tbS.TabIndex =18;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(223, 109);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 16;
            this.btnS.Text = "Syndrom";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 266);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.btnZn);
            this.Controls.Add(this.btnBł);
            this.Controls.Add(this.tbr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnR2);
            this.Controls.Add(this.tby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kod Hemminga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbr2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnR2;
        private System.Windows.Forms.TextBox tby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBł;
        private System.Windows.Forms.Button btnZn;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Button btnS;
    }
}

