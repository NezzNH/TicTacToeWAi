namespace TicTacToeWAi
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
            this.space00 = new System.Windows.Forms.Label();
            this.space01 = new System.Windows.Forms.Label();
            this.space02 = new System.Windows.Forms.Label();
            this.space12 = new System.Windows.Forms.Label();
            this.space11 = new System.Windows.Forms.Label();
            this.space10 = new System.Windows.Forms.Label();
            this.space22 = new System.Windows.Forms.Label();
            this.space21 = new System.Windows.Forms.Label();
            this.space20 = new System.Windows.Forms.Label();
            this.aispace00 = new System.Windows.Forms.Label();
            this.aispace01 = new System.Windows.Forms.Label();
            this.aispace02 = new System.Windows.Forms.Label();
            this.aispace12 = new System.Windows.Forms.Label();
            this.aispace11 = new System.Windows.Forms.Label();
            this.aispace10 = new System.Windows.Forms.Label();
            this.aispace22 = new System.Windows.Forms.Label();
            this.aispace21 = new System.Windows.Forms.Label();
            this.aispace20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // space00
            // 
            this.space00.AutoSize = true;
            this.space00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space00.Location = new System.Drawing.Point(333, 95);
            this.space00.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space00.MaximumSize = new System.Drawing.Size(71, 61);
            this.space00.MinimumSize = new System.Drawing.Size(71, 61);
            this.space00.Name = "space00";
            this.space00.Size = new System.Drawing.Size(71, 61);
            this.space00.TabIndex = 0;
            this.space00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space00.Click += new System.EventHandler(this.space00_Click_1);
            // 
            // space01
            // 
            this.space01.AutoSize = true;
            this.space01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space01.Location = new System.Drawing.Point(407, 95);
            this.space01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space01.MaximumSize = new System.Drawing.Size(71, 61);
            this.space01.MinimumSize = new System.Drawing.Size(71, 61);
            this.space01.Name = "space01";
            this.space01.Size = new System.Drawing.Size(71, 61);
            this.space01.TabIndex = 1;
            this.space01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space01.Click += new System.EventHandler(this.space01_Click);
            // 
            // space02
            // 
            this.space02.AutoSize = true;
            this.space02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space02.Location = new System.Drawing.Point(481, 95);
            this.space02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space02.MaximumSize = new System.Drawing.Size(71, 61);
            this.space02.MinimumSize = new System.Drawing.Size(71, 61);
            this.space02.Name = "space02";
            this.space02.Size = new System.Drawing.Size(71, 61);
            this.space02.TabIndex = 2;
            this.space02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space02.Click += new System.EventHandler(this.space02_Click);
            // 
            // space12
            // 
            this.space12.AutoSize = true;
            this.space12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space12.Location = new System.Drawing.Point(481, 163);
            this.space12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space12.MaximumSize = new System.Drawing.Size(71, 61);
            this.space12.MinimumSize = new System.Drawing.Size(71, 61);
            this.space12.Name = "space12";
            this.space12.Size = new System.Drawing.Size(71, 61);
            this.space12.TabIndex = 5;
            this.space12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space12.Click += new System.EventHandler(this.space12_Click);
            // 
            // space11
            // 
            this.space11.AutoSize = true;
            this.space11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space11.Location = new System.Drawing.Point(407, 163);
            this.space11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space11.MaximumSize = new System.Drawing.Size(71, 61);
            this.space11.MinimumSize = new System.Drawing.Size(71, 61);
            this.space11.Name = "space11";
            this.space11.Size = new System.Drawing.Size(71, 61);
            this.space11.TabIndex = 4;
            this.space11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space11.Click += new System.EventHandler(this.space11_Click);
            // 
            // space10
            // 
            this.space10.AutoSize = true;
            this.space10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space10.Location = new System.Drawing.Point(333, 163);
            this.space10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space10.MaximumSize = new System.Drawing.Size(71, 61);
            this.space10.MinimumSize = new System.Drawing.Size(71, 61);
            this.space10.Name = "space10";
            this.space10.Size = new System.Drawing.Size(71, 61);
            this.space10.TabIndex = 3;
            this.space10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space10.Click += new System.EventHandler(this.space10_Click);
            // 
            // space22
            // 
            this.space22.AutoSize = true;
            this.space22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space22.Location = new System.Drawing.Point(481, 232);
            this.space22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space22.MaximumSize = new System.Drawing.Size(71, 61);
            this.space22.MinimumSize = new System.Drawing.Size(71, 61);
            this.space22.Name = "space22";
            this.space22.Size = new System.Drawing.Size(71, 61);
            this.space22.TabIndex = 8;
            this.space22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space22.Click += new System.EventHandler(this.space22_Click);
            // 
            // space21
            // 
            this.space21.AutoSize = true;
            this.space21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space21.Location = new System.Drawing.Point(407, 232);
            this.space21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space21.MaximumSize = new System.Drawing.Size(71, 61);
            this.space21.MinimumSize = new System.Drawing.Size(71, 61);
            this.space21.Name = "space21";
            this.space21.Size = new System.Drawing.Size(71, 61);
            this.space21.TabIndex = 7;
            this.space21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space21.Click += new System.EventHandler(this.space21_Click);
            // 
            // space20
            // 
            this.space20.AutoSize = true;
            this.space20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space20.Location = new System.Drawing.Point(333, 232);
            this.space20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.space20.MaximumSize = new System.Drawing.Size(71, 61);
            this.space20.MinimumSize = new System.Drawing.Size(71, 61);
            this.space20.Name = "space20";
            this.space20.Size = new System.Drawing.Size(71, 61);
            this.space20.TabIndex = 6;
            this.space20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.space20.Click += new System.EventHandler(this.space20_Click);
            // 
            // aispace00
            // 
            this.aispace00.AutoSize = true;
            this.aispace00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace00.Location = new System.Drawing.Point(618, 106);
            this.aispace00.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace00.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace00.Name = "aispace00";
            this.aispace00.Size = new System.Drawing.Size(50, 50);
            this.aispace00.TabIndex = 9;
            this.aispace00.Text = "label1";
            this.aispace00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace01
            // 
            this.aispace01.AutoSize = true;
            this.aispace01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace01.Location = new System.Drawing.Point(674, 106);
            this.aispace01.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace01.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace01.Name = "aispace01";
            this.aispace01.Size = new System.Drawing.Size(50, 50);
            this.aispace01.TabIndex = 10;
            this.aispace01.Text = "label1";
            this.aispace01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace02
            // 
            this.aispace02.AutoSize = true;
            this.aispace02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace02.Location = new System.Drawing.Point(730, 106);
            this.aispace02.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace02.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace02.Name = "aispace02";
            this.aispace02.Size = new System.Drawing.Size(50, 50);
            this.aispace02.TabIndex = 11;
            this.aispace02.Text = "label1";
            this.aispace02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace12
            // 
            this.aispace12.AutoSize = true;
            this.aispace12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace12.Location = new System.Drawing.Point(730, 166);
            this.aispace12.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace12.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace12.Name = "aispace12";
            this.aispace12.Size = new System.Drawing.Size(50, 50);
            this.aispace12.TabIndex = 14;
            this.aispace12.Text = "label1";
            this.aispace12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace11
            // 
            this.aispace11.AutoSize = true;
            this.aispace11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace11.Location = new System.Drawing.Point(674, 166);
            this.aispace11.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace11.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace11.Name = "aispace11";
            this.aispace11.Size = new System.Drawing.Size(50, 50);
            this.aispace11.TabIndex = 13;
            this.aispace11.Text = "label4";
            this.aispace11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace10
            // 
            this.aispace10.AutoSize = true;
            this.aispace10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace10.Location = new System.Drawing.Point(618, 166);
            this.aispace10.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace10.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace10.Name = "aispace10";
            this.aispace10.Size = new System.Drawing.Size(50, 50);
            this.aispace10.TabIndex = 12;
            this.aispace10.Text = "label1";
            this.aispace10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace22
            // 
            this.aispace22.AutoSize = true;
            this.aispace22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace22.Location = new System.Drawing.Point(730, 232);
            this.aispace22.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace22.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace22.Name = "aispace22";
            this.aispace22.Size = new System.Drawing.Size(50, 50);
            this.aispace22.TabIndex = 17;
            this.aispace22.Text = "label1";
            this.aispace22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace21
            // 
            this.aispace21.AutoSize = true;
            this.aispace21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace21.Location = new System.Drawing.Point(674, 232);
            this.aispace21.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace21.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace21.Name = "aispace21";
            this.aispace21.Size = new System.Drawing.Size(50, 50);
            this.aispace21.TabIndex = 16;
            this.aispace21.Text = "label7";
            this.aispace21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aispace20
            // 
            this.aispace20.AutoSize = true;
            this.aispace20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aispace20.Location = new System.Drawing.Point(618, 232);
            this.aispace20.MaximumSize = new System.Drawing.Size(50, 50);
            this.aispace20.MinimumSize = new System.Drawing.Size(50, 50);
            this.aispace20.Name = "aispace20";
            this.aispace20.Size = new System.Drawing.Size(50, 50);
            this.aispace20.TabIndex = 15;
            this.aispace20.Text = "label1";
            this.aispace20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 443);
            this.Controls.Add(this.aispace22);
            this.Controls.Add(this.aispace21);
            this.Controls.Add(this.aispace20);
            this.Controls.Add(this.aispace12);
            this.Controls.Add(this.aispace11);
            this.Controls.Add(this.aispace10);
            this.Controls.Add(this.aispace02);
            this.Controls.Add(this.aispace01);
            this.Controls.Add(this.aispace00);
            this.Controls.Add(this.space22);
            this.Controls.Add(this.space21);
            this.Controls.Add(this.space20);
            this.Controls.Add(this.space12);
            this.Controls.Add(this.space11);
            this.Controls.Add(this.space10);
            this.Controls.Add(this.space02);
            this.Controls.Add(this.space01);
            this.Controls.Add(this.space00);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label space00;
        private Label space01;
        private Label space02;
        private Label space12;
        private Label space11;
        private Label space10;
        private Label space22;
        private Label space21;
        private Label space20;
        private Label aispace00;
        private Label aispace01;
        private Label aispace02;
        private Label aispace12;
        private Label aispace11;
        private Label aispace10;
        private Label aispace22;
        private Label aispace21;
        private Label aispace20;
    }
}