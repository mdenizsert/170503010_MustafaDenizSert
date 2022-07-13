
namespace KinderGarten.Entities.UI
{
    partial class AdminPage
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
            this.Logout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addStudentbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentPasswordtxt = new System.Windows.Forms.TextBox();
            this.studentMedicinetxt = new System.Windows.Forms.TextBox();
            this.studentBirthdatetxt = new System.Windows.Forms.TextBox();
            this.studentEmailtxt = new System.Windows.Forms.TextBox();
            this.studentParentnametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentPhonetxt = new System.Windows.Forms.TextBox();
            this.studentAddresstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentLastnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNametxt = new System.Windows.Forms.TextBox();
            this.studentClasscmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(1566, 745);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(124, 45);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Ausloggen";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentClasscmb);
            this.groupBox1.Controls.Add(this.addStudentbtn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.studentPasswordtxt);
            this.groupBox1.Controls.Add(this.studentMedicinetxt);
            this.groupBox1.Controls.Add(this.studentBirthdatetxt);
            this.groupBox1.Controls.Add(this.studentEmailtxt);
            this.groupBox1.Controls.Add(this.studentParentnametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.studentPhonetxt);
            this.groupBox1.Controls.Add(this.studentAddresstxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.studentLastnametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.studentNametxt);
            this.groupBox1.Location = new System.Drawing.Point(28, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // addStudentbtn
            // 
            this.addStudentbtn.Location = new System.Drawing.Point(401, 283);
            this.addStudentbtn.Name = "addStudentbtn";
            this.addStudentbtn.Size = new System.Drawing.Size(146, 58);
            this.addStudentbtn.TabIndex = 20;
            this.addStudentbtn.Text = "Hinzufügen";
            this.addStudentbtn.UseVisualStyleBackColor = true;
            this.addStudentbtn.Click += new System.EventHandler(this.addStudentbtn_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Class\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(400, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(400, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Medizin\r\n\r\n\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(400, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Geburtsdatum\r\n\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(211, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentPasswordtxt
            // 
            this.studentPasswordtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentPasswordtxt.Location = new System.Drawing.Point(403, 234);
            this.studentPasswordtxt.Name = "studentPasswordtxt";
            this.studentPasswordtxt.Size = new System.Drawing.Size(144, 22);
            this.studentPasswordtxt.TabIndex = 13;
            // 
            // studentMedicinetxt
            // 
            this.studentMedicinetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentMedicinetxt.Location = new System.Drawing.Point(403, 144);
            this.studentMedicinetxt.Name = "studentMedicinetxt";
            this.studentMedicinetxt.Size = new System.Drawing.Size(144, 22);
            this.studentMedicinetxt.TabIndex = 12;
            // 
            // studentBirthdatetxt
            // 
            this.studentBirthdatetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentBirthdatetxt.Location = new System.Drawing.Point(403, 62);
            this.studentBirthdatetxt.Name = "studentBirthdatetxt";
            this.studentBirthdatetxt.Size = new System.Drawing.Size(144, 22);
            this.studentBirthdatetxt.TabIndex = 11;
            // 
            // studentEmailtxt
            // 
            this.studentEmailtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentEmailtxt.Location = new System.Drawing.Point(214, 234);
            this.studentEmailtxt.Name = "studentEmailtxt";
            this.studentEmailtxt.Size = new System.Drawing.Size(144, 22);
            this.studentEmailtxt.TabIndex = 10;
            // 
            // studentParentnametxt
            // 
            this.studentParentnametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentParentnametxt.Location = new System.Drawing.Point(19, 234);
            this.studentParentnametxt.Name = "studentParentnametxt";
            this.studentParentnametxt.Size = new System.Drawing.Size(144, 22);
            this.studentParentnametxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Elternname";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(211, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefonnummer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentPhonetxt
            // 
            this.studentPhonetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentPhonetxt.Location = new System.Drawing.Point(214, 144);
            this.studentPhonetxt.Name = "studentPhonetxt";
            this.studentPhonetxt.Size = new System.Drawing.Size(144, 22);
            this.studentPhonetxt.TabIndex = 6;
            // 
            // studentAddresstxt
            // 
            this.studentAddresstxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentAddresstxt.Location = new System.Drawing.Point(214, 62);
            this.studentAddresstxt.Name = "studentAddresstxt";
            this.studentAddresstxt.Size = new System.Drawing.Size(144, 22);
            this.studentAddresstxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(211, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentLastnametxt
            // 
            this.studentLastnametxt.Location = new System.Drawing.Point(19, 144);
            this.studentLastnametxt.Name = "studentLastnametxt";
            this.studentLastnametxt.Size = new System.Drawing.Size(144, 22);
            this.studentLastnametxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nachname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNametxt
            // 
            this.studentNametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentNametxt.Location = new System.Drawing.Point(19, 62);
            this.studentNametxt.Name = "studentNametxt";
            this.studentNametxt.Size = new System.Drawing.Size(144, 22);
            this.studentNametxt.TabIndex = 0;
            // 
            // studentClasscmb
            // 
            this.studentClasscmb.FormattingEnabled = true;
            this.studentClasscmb.Location = new System.Drawing.Point(19, 309);
            this.studentClasscmb.Name = "studentClasscmb";
            this.studentClasscmb.Size = new System.Drawing.Size(144, 24);
            this.studentClasscmb.TabIndex = 21;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 802);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logout);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox studentNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentLastnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentPhonetxt;
        private System.Windows.Forms.TextBox studentAddresstxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentPasswordtxt;
        private System.Windows.Forms.TextBox studentMedicinetxt;
        private System.Windows.Forms.TextBox studentBirthdatetxt;
        private System.Windows.Forms.TextBox studentEmailtxt;
        private System.Windows.Forms.TextBox studentParentnametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addStudentbtn;
        private System.Windows.Forms.ComboBox studentClasscmb;
    }
}