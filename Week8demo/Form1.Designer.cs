namespace Week8demo
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
            label1 = new Label();
            label2 = new Label();
            FnametextBox = new TextBox();
            EmailtextBox = new TextBox();
            radioButtonmo3 = new RadioButton();
            radioButtonmo12 = new RadioButton();
            radioButtonmo24 = new RadioButton();
            label3 = new Label();
            buttonSubmit = new Button();
            label4 = new Label();
            radioButtonBas = new RadioButton();
            radioButtonReg = new RadioButton();
            radioButtonPer = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            textBoxaddy = new TextBox();
            label6 = new Label();
            textBoxMoblie = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            radioButtonOFV = new RadioButton();
            radioButtonDC = new RadioButton();
            radioButtonPT = new RadioButton();
            radioButtonAccess = new RadioButton();
            label8 = new Label();
            groupBox4 = new GroupBox();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // FnametextBox
            // 
            FnametextBox.Location = new Point(106, 36);
            FnametextBox.Name = "FnametextBox";
            FnametextBox.Size = new Size(100, 23);
            FnametextBox.TabIndex = 2;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(106, 97);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(100, 23);
            EmailtextBox.TabIndex = 3;
            // 
            // radioButtonmo3
            // 
            radioButtonmo3.AutoSize = true;
            radioButtonmo3.Location = new Point(48, 16);
            radioButtonmo3.Name = "radioButtonmo3";
            radioButtonmo3.Size = new Size(70, 19);
            radioButtonmo3.TabIndex = 4;
            radioButtonmo3.TabStop = true;
            radioButtonmo3.Text = "3 Month";
            radioButtonmo3.UseVisualStyleBackColor = true;
            // 
            // radioButtonmo12
            // 
            radioButtonmo12.AutoSize = true;
            radioButtonmo12.Location = new Point(152, 16);
            radioButtonmo12.Name = "radioButtonmo12";
            radioButtonmo12.Size = new Size(76, 19);
            radioButtonmo12.TabIndex = 6;
            radioButtonmo12.TabStop = true;
            radioButtonmo12.Text = "12 Month";
            radioButtonmo12.UseVisualStyleBackColor = true;
            // 
            // radioButtonmo24
            // 
            radioButtonmo24.AutoSize = true;
            radioButtonmo24.Location = new Point(262, 16);
            radioButtonmo24.Name = "radioButtonmo24";
            radioButtonmo24.Size = new Size(76, 19);
            radioButtonmo24.TabIndex = 7;
            radioButtonmo24.TabStop = true;
            radioButtonmo24.Text = "24 Month";
            radioButtonmo24.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(374, 144);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 8;
            label3.Text = "Member Ship ";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Transparent;
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(374, 434);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(116, 60);
            buttonSubmit.TabIndex = 9;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(393, 222);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 10;
            label4.Text = "Options";
            // 
            // radioButtonBas
            // 
            radioButtonBas.AutoSize = true;
            radioButtonBas.Location = new Point(41, 18);
            radioButtonBas.Name = "radioButtonBas";
            radioButtonBas.Size = new Size(52, 19);
            radioButtonBas.TabIndex = 11;
            radioButtonBas.TabStop = true;
            radioButtonBas.Text = "Basic";
            radioButtonBas.UseVisualStyleBackColor = true;
            // 
            // radioButtonReg
            // 
            radioButtonReg.AutoSize = true;
            radioButtonReg.Location = new Point(156, 18);
            radioButtonReg.Name = "radioButtonReg";
            radioButtonReg.Size = new Size(65, 19);
            radioButtonReg.TabIndex = 12;
            radioButtonReg.TabStop = true;
            radioButtonReg.Text = "Regular";
            radioButtonReg.UseVisualStyleBackColor = true;
            // 
            // radioButtonPer
            // 
            radioButtonPer.AutoSize = true;
            radioButtonPer.Location = new Point(261, 18);
            radioButtonPer.Name = "radioButtonPer";
            radioButtonPer.Size = new Size(70, 19);
            radioButtonPer.TabIndex = 13;
            radioButtonPer.TabStop = true;
            radioButtonPer.Text = "Perumin";
            radioButtonPer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonmo24);
            groupBox1.Controls.Add(radioButtonmo12);
            groupBox1.Controls.Add(radioButtonmo3);
            groupBox1.Location = new Point(235, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 51);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Duration";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonPer);
            groupBox2.Controls.Add(radioButtonReg);
            groupBox2.Controls.Add(radioButtonBas);
            groupBox2.Location = new Point(235, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 49);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Membership type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(673, 38);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 0;
            label5.Text = "Address";
            // 
            // textBoxaddy
            // 
            textBoxaddy.Location = new Point(776, 36);
            textBoxaddy.Name = "textBoxaddy";
            textBoxaddy.Size = new Size(100, 23);
            textBoxaddy.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(673, 89);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 0;
            label6.Text = "Moblie ";
            // 
            // textBoxMoblie
            // 
            textBoxMoblie.Location = new Point(776, 87);
            textBoxMoblie.Name = "textBoxMoblie";
            textBoxMoblie.Size = new Size(100, 23);
            textBoxMoblie.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(393, 298);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 10;
            label7.Text = "Extras";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonOFV);
            groupBox3.Controls.Add(radioButtonDC);
            groupBox3.Controls.Add(radioButtonPT);
            groupBox3.Controls.Add(radioButtonAccess);
            groupBox3.Location = new Point(235, 322);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(382, 90);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extras type";
            // 
            // radioButtonOFV
            // 
            radioButtonOFV.AutoSize = true;
            radioButtonOFV.Location = new Point(158, 43);
            radioButtonOFV.Name = "radioButtonOFV";
            radioButtonOFV.Size = new Size(134, 19);
            radioButtonOFV.TabIndex = 14;
            radioButtonOFV.TabStop = true;
            radioButtonOFV.Text = "Online firness videos";
            radioButtonOFV.UseVisualStyleBackColor = true;
            // 
            // radioButtonDC
            // 
            radioButtonDC.AutoSize = true;
            radioButtonDC.Location = new Point(261, 18);
            radioButtonDC.Name = "radioButtonDC";
            radioButtonDC.Size = new Size(115, 19);
            radioButtonDC.TabIndex = 13;
            radioButtonDC.TabStop = true;
            radioButtonDC.Text = "Diet consultation";
            radioButtonDC.UseVisualStyleBackColor = true;
            // 
            // radioButtonPT
            // 
            radioButtonPT.AutoSize = true;
            radioButtonPT.Location = new Point(156, 18);
            radioButtonPT.Name = "radioButtonPT";
            radioButtonPT.Size = new Size(108, 19);
            radioButtonPT.TabIndex = 12;
            radioButtonPT.TabStop = true;
            radioButtonPT.Text = "Personal Trainer";
            radioButtonPT.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccess
            // 
            radioButtonAccess.AutoSize = true;
            radioButtonAccess.Location = new Point(41, 18);
            radioButtonAccess.Name = "radioButtonAccess";
            radioButtonAccess.Size = new Size(93, 19);
            radioButtonAccess.TabIndex = 11;
            radioButtonAccess.TabStop = true;
            radioButtonAccess.Text = "24/7 Access  ";
            radioButtonAccess.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(374, 12);
            label8.Name = "label8";
            label8.Size = new Size(140, 21);
            label8.TabIndex = 10;
            label8.Text = "Payment options";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton4);
            groupBox4.Location = new Point(265, 60);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(134, 50);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Payment type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 19);
            label9.Name = "label9";
            label9.Size = new Size(129, 15);
            label9.TabIndex = 15;
            label9.Text = "Frequency of payment:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(93, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Monthly";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 50);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Weekly";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(41, 18);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(86, 19);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "Direct debit";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButton1);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(radioButton3);
            groupBox5.Location = new Point(405, 60);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(168, 75);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 506);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(buttonSubmit);
            Controls.Add(label3);
            Controls.Add(EmailtextBox);
            Controls.Add(textBoxMoblie);
            Controls.Add(textBoxaddy);
            Controls.Add(label6);
            Controls.Add(FnametextBox);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Register Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FnametextBox;
        private TextBox EmailtextBox;
        private RadioButton radioButtonmo3;
        private RadioButton radioButtonmo12;
        private RadioButton radioButtonmo24;
        private Label label3;
        private Button buttonSubmit;
        private Label label4;
        private RadioButton radioButtonBas;
        private RadioButton radioButtonReg;
        private RadioButton radioButtonPer;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox textBoxaddy;
        private Label label6;
        private TextBox textBoxMoblie;
        private Label label7;
        private GroupBox groupBox3;
        private RadioButton radioButtonDC;
        private RadioButton radioButtonPT;
        private RadioButton radioButtonAccess;
        private RadioButton radioButtonOFV;
        private Label label8;
        private GroupBox groupBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label9;
        private GroupBox groupBox5;
    }
}
