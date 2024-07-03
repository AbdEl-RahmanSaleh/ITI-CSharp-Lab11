namespace calculator
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
            btn1 = new Button();
            bt2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btnEqual = new Button();
            btndot = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivision = new Button();
            txtScreen = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(8, 165);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 60);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn11_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(94, 165);
            bt2.Name = "bt2";
            bt2.Size = new Size(80, 60);
            bt2.TabIndex = 1;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += btn11_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(180, 165);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 60);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn11_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(8, 99);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn11_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(94, 99);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 60);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn11_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(180, 98);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 60);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn11_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(8, 33);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 60);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn11_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(94, 33);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 60);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn11_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.MenuHighlight;
            btnEqual.Location = new Point(180, 236);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(80, 60);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btndot
            // 
            btndot.Location = new Point(8, 236);
            btndot.Name = "btndot";
            btndot.Size = new Size(80, 60);
            btndot.TabIndex = 9;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btn11_Click;
            // 
            // btn11
            // 
            btn11.Location = new Point(94, 236);
            btn11.Name = "btn11";
            btn11.Size = new Size(80, 60);
            btn11.TabIndex = 10;
            btn11.Text = "0";
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn11_Click;
            // 
            // btn12
            // 
            btn12.Location = new Point(180, 33);
            btn12.Name = "btn12";
            btn12.Size = new Size(80, 60);
            btn12.TabIndex = 11;
            btn12.Text = "9";
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn11_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(266, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 60);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnMultiply_Click_1;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(266, 166);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(80, 60);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnMultiply_Click_1;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(266, 33);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 60);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click_1;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(266, 99);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(80, 60);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnMultiply_Click_1;
            // 
            // txtScreen
            // 
            txtScreen.Dock = DockStyle.Top;
            txtScreen.Location = new Point(0, 0);
            txtScreen.Name = "txtScreen";
            txtScreen.Size = new Size(348, 27);
            txtScreen.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 299);
            Controls.Add(txtScreen);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btndot);
            Controls.Add(btnEqual);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(bt2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button bt2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btnEqual;
        private Button btndot;
        private Button btn11;
        private Button btn12;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivision;
        private TextBox txtScreen;
    }
}
