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
            space00 = new Label();
            space01 = new Label();
            space02 = new Label();
            space12 = new Label();
            space11 = new Label();
            space10 = new Label();
            space22 = new Label();
            space21 = new Label();
            space20 = new Label();
            SuspendLayout();
            // 
            // space00
            // 
            space00.AutoSize = true;
            space00.BorderStyle = BorderStyle.FixedSingle;
            space00.Location = new Point(441, 68);
            space00.MaximumSize = new Size(100, 100);
            space00.MinimumSize = new Size(100, 100);
            space00.Name = "space00";
            space00.Size = new Size(100, 100);
            space00.TabIndex = 0;
            space00.Text = "Test";
            space00.TextAlign = ContentAlignment.MiddleCenter;
            space00.Click += space00_Click;
            // 
            // space01
            // 
            space01.AutoSize = true;
            space01.BorderStyle = BorderStyle.FixedSingle;
            space01.Location = new Point(547, 68);
            space01.MaximumSize = new Size(100, 100);
            space01.MinimumSize = new Size(100, 100);
            space01.Name = "space01";
            space01.Size = new Size(100, 100);
            space01.TabIndex = 1;
            space01.Text = "Test";
            space01.TextAlign = ContentAlignment.MiddleCenter;
            space01.Click += space01_Click;
            // 
            // space02
            // 
            space02.AutoSize = true;
            space02.BorderStyle = BorderStyle.FixedSingle;
            space02.Location = new Point(653, 68);
            space02.MaximumSize = new Size(100, 100);
            space02.MinimumSize = new Size(100, 100);
            space02.Name = "space02";
            space02.Size = new Size(100, 100);
            space02.TabIndex = 2;
            space02.Text = "Test";
            space02.TextAlign = ContentAlignment.MiddleCenter;
            space02.Click += space02_Click;
            // 
            // space12
            // 
            space12.AutoSize = true;
            space12.BorderStyle = BorderStyle.FixedSingle;
            space12.Location = new Point(653, 182);
            space12.MaximumSize = new Size(100, 100);
            space12.MinimumSize = new Size(100, 100);
            space12.Name = "space12";
            space12.Size = new Size(100, 100);
            space12.TabIndex = 5;
            space12.Text = "Test";
            space12.TextAlign = ContentAlignment.MiddleCenter;
            space12.Click += space12_Click;
            // 
            // space11
            // 
            space11.AutoSize = true;
            space11.BorderStyle = BorderStyle.FixedSingle;
            space11.Location = new Point(547, 182);
            space11.MaximumSize = new Size(100, 100);
            space11.MinimumSize = new Size(100, 100);
            space11.Name = "space11";
            space11.Size = new Size(100, 100);
            space11.TabIndex = 4;
            space11.Text = "Test";
            space11.TextAlign = ContentAlignment.MiddleCenter;
            space11.Click += space11_Click;
            // 
            // space10
            // 
            space10.AutoSize = true;
            space10.BorderStyle = BorderStyle.FixedSingle;
            space10.Location = new Point(441, 182);
            space10.MaximumSize = new Size(100, 100);
            space10.MinimumSize = new Size(100, 100);
            space10.Name = "space10";
            space10.Size = new Size(100, 100);
            space10.TabIndex = 3;
            space10.Text = "Test";
            space10.TextAlign = ContentAlignment.MiddleCenter;
            space10.Click += space10_Click;
            // 
            // space22
            // 
            space22.AutoSize = true;
            space22.BorderStyle = BorderStyle.FixedSingle;
            space22.Location = new Point(653, 297);
            space22.MaximumSize = new Size(100, 100);
            space22.MinimumSize = new Size(100, 100);
            space22.Name = "space22";
            space22.Size = new Size(100, 100);
            space22.TabIndex = 8;
            space22.Text = "Test";
            space22.TextAlign = ContentAlignment.MiddleCenter;
            space22.Click += space22_Click;
            // 
            // space21
            // 
            space21.AutoSize = true;
            space21.BorderStyle = BorderStyle.FixedSingle;
            space21.Location = new Point(547, 297);
            space21.MaximumSize = new Size(100, 100);
            space21.MinimumSize = new Size(100, 100);
            space21.Name = "space21";
            space21.Size = new Size(100, 100);
            space21.TabIndex = 7;
            space21.Text = "Test";
            space21.TextAlign = ContentAlignment.MiddleCenter;
            space21.Click += space21_Click;
            // 
            // space20
            // 
            space20.AutoSize = true;
            space20.BorderStyle = BorderStyle.FixedSingle;
            space20.Location = new Point(441, 297);
            space20.MaximumSize = new Size(100, 100);
            space20.MinimumSize = new Size(100, 100);
            space20.Name = "space20";
            space20.Size = new Size(100, 100);
            space20.TabIndex = 6;
            space20.Text = "Test";
            space20.TextAlign = ContentAlignment.MiddleCenter;
            space20.Click += space20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 592);
            Controls.Add(space22);
            Controls.Add(space21);
            Controls.Add(space20);
            Controls.Add(space12);
            Controls.Add(space11);
            Controls.Add(space10);
            Controls.Add(space02);
            Controls.Add(space01);
            Controls.Add(space00);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}