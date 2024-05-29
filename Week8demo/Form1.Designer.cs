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
            radioButtonDC = new RadioButton();
            radioButtonPT = new RadioButton();
            radioButtonAccess = new RadioButton();
            radioButtonOFV = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // FnametextBox
            // 
            FnametextBox.Location = new Point(126, 36);
            FnametextBox.Name = "FnametextBox";
            FnametextBox.Size = new Size(100, 23);
            FnametextBox.TabIndex = 2;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(126, 97);
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
            label3.Location = new Point(303, 133);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 8;
            label3.Text = "Member Ship ";
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Transparent;
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(303, 434);
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
            label4.Location = new Point(322, 211);
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
            groupBox1.Location = new Point(164, 157);
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
            groupBox2.Location = new Point(164, 235);
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
            label5.Location = new Point(429, 54);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 0;
            label5.Text = "Address";
            // 
            // textBoxaddy
            // 
            textBoxaddy.Location = new Point(532, 52);
            textBoxaddy.Name = "textBoxaddy";
            textBoxaddy.Size = new Size(100, 23);
            textBoxaddy.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(429, 105);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 0;
            label6.Text = "Moblie ";
            // 
            // textBoxMoblie
            // 
            textBoxMoblie.Location = new Point(532, 103);
            textBoxMoblie.Name = "textBoxMoblie";
            textBoxMoblie.Size = new Size(100, 23);
            textBoxMoblie.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(322, 287);
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
            groupBox3.Location = new Point(164, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(382, 90);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extras type";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 506);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
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
    }
}
