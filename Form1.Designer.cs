namespace Caculator
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
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn_open = new Button();
            btn_close = new Button();
            btnEqual = new Button();
            btn_clear = new Button();
            btn_ce = new Button();
            btn_cong = new Button();
            btn_tru = new Button();
            btn_nhan = new Button();
            btn_chia = new Button();
            btn_0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(338, 27);
            txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 65);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 43);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(79, 65);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 43);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(155, 65);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 43);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 129);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 43);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(79, 129);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 43);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(155, 129);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 43);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 187);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 43);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(79, 187);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 43);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(155, 187);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 43);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn_open
            // 
            btn_open.Location = new Point(12, 246);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(51, 45);
            btn_open.TabIndex = 10;
            btn_open.Text = "(";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(79, 246);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(51, 45);
            btn_close.TabIndex = 11;
            btn_close.Text = ")";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(155, 246);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(51, 45);
            btnEqual.TabIndex = 12;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(230, 65);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(51, 43);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_ce
            // 
            btn_ce.Location = new Point(230, 129);
            btn_ce.Name = "btn_ce";
            btn_ce.Size = new Size(51, 43);
            btn_ce.TabIndex = 14;
            btn_ce.Text = "CE";
            btn_ce.UseVisualStyleBackColor = true;
            btn_ce.Click += btn_ce_Click;
            // 
            // btn_cong
            // 
            btn_cong.Location = new Point(299, 65);
            btn_cong.Name = "btn_cong";
            btn_cong.Size = new Size(51, 43);
            btn_cong.TabIndex = 15;
            btn_cong.Text = "+";
            btn_cong.UseVisualStyleBackColor = true;
            btn_cong.Click += btn_cong_Click;
            // 
            // btn_tru
            // 
            btn_tru.Location = new Point(299, 129);
            btn_tru.Name = "btn_tru";
            btn_tru.Size = new Size(51, 43);
            btn_tru.TabIndex = 16;
            btn_tru.Text = "-";
            btn_tru.UseVisualStyleBackColor = true;
            btn_tru.Click += btn_tru_Click;
            // 
            // btn_nhan
            // 
            btn_nhan.Location = new Point(299, 187);
            btn_nhan.Name = "btn_nhan";
            btn_nhan.Size = new Size(51, 43);
            btn_nhan.TabIndex = 17;
            btn_nhan.Text = "*";
            btn_nhan.UseVisualStyleBackColor = true;
            btn_nhan.Click += btn_nhan_Click;
            // 
            // btn_chia
            // 
            btn_chia.Location = new Point(299, 248);
            btn_chia.Name = "btn_chia";
            btn_chia.Size = new Size(51, 43);
            btn_chia.TabIndex = 18;
            btn_chia.Text = "/";
            btn_chia.UseVisualStyleBackColor = true;
            btn_chia.Click += btn_chia_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(230, 187);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(51, 43);
            btn_0.TabIndex = 19;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 380);
            Controls.Add(btn_0);
            Controls.Add(btn_chia);
            Controls.Add(btn_nhan);
            Controls.Add(btn_tru);
            Controls.Add(btn_cong);
            Controls.Add(btn_ce);
            Controls.Add(btn_clear);
            Controls.Add(btnEqual);
            Controls.Add(btn_close);
            Controls.Add(btn_open);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn_open;
        private Button btn_close;
        private Button btnEqual;
        private Button btn_clear;
        private Button btn_ce;
        private Button btn_cong;
        private Button btn_tru;
        private Button btn_nhan;
        private Button btn_chia;
        private Button btn_0;
    }
}
