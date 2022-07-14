
namespace KinderGarten
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminLogin = new System.Windows.Forms.Button();
            this.adminPasswordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminEmailText = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.warnLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teacherLoginbtn = new System.Windows.Forms.Button();
            this.teacherPasswordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherEmailtxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentLoginbtn = new System.Windows.Forms.Button();
            this.studentPasswordtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentEmailtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adminLogin);
            this.groupBox1.Controls.Add(this.adminPasswordText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.adminEmailText);
            this.groupBox1.Location = new System.Drawing.Point(53, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Login";
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(143, 249);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(94, 38);
            this.adminLogin.TabIndex = 4;
            this.adminLogin.Text = "Login";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // adminPasswordText
            // 
            this.adminPasswordText.Location = new System.Drawing.Point(68, 192);
            this.adminPasswordText.Name = "adminPasswordText";
            this.adminPasswordText.Size = new System.Drawing.Size(241, 22);
            this.adminPasswordText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // adminEmailText
            // 
            this.adminEmailText.Location = new System.Drawing.Point(68, 86);
            this.adminEmailText.Name = "adminEmailText";
            this.adminEmailText.Size = new System.Drawing.Size(241, 22);
            this.adminEmailText.TabIndex = 0;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(279, 638);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 17);
            this.warningLabel.TabIndex = 1;
            // 
            // warnLabel
            // 
            this.warnLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warnLabel.Location = new System.Drawing.Point(47, 591);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(938, 102);
            this.warnLabel.TabIndex = 2;
            this.warnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teacherLoginbtn);
            this.groupBox2.Controls.Add(this.teacherPasswordtxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.teacherEmailtxt);
            this.groupBox2.Location = new System.Drawing.Point(537, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 330);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher Login";
            // 
            // teacherLoginbtn
            // 
            this.teacherLoginbtn.Location = new System.Drawing.Point(143, 249);
            this.teacherLoginbtn.Name = "teacherLoginbtn";
            this.teacherLoginbtn.Size = new System.Drawing.Size(94, 38);
            this.teacherLoginbtn.TabIndex = 4;
            this.teacherLoginbtn.Text = "Login";
            this.teacherLoginbtn.UseVisualStyleBackColor = true;
            this.teacherLoginbtn.Click += new System.EventHandler(this.teacherLoginbtn_Click);
            // 
            // teacherPasswordtxt
            // 
            this.teacherPasswordtxt.Location = new System.Drawing.Point(68, 192);
            this.teacherPasswordtxt.Name = "teacherPasswordtxt";
            this.teacherPasswordtxt.Size = new System.Drawing.Size(241, 22);
            this.teacherPasswordtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // teacherEmailtxt
            // 
            this.teacherEmailtxt.Location = new System.Drawing.Point(68, 86);
            this.teacherEmailtxt.Name = "teacherEmailtxt";
            this.teacherEmailtxt.Size = new System.Drawing.Size(241, 22);
            this.teacherEmailtxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentLoginbtn);
            this.groupBox3.Controls.Add(this.studentPasswordtxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.studentEmailtxt);
            this.groupBox3.Location = new System.Drawing.Point(1019, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 330);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Login";
            // 
            // studentLoginbtn
            // 
            this.studentLoginbtn.Location = new System.Drawing.Point(143, 249);
            this.studentLoginbtn.Name = "studentLoginbtn";
            this.studentLoginbtn.Size = new System.Drawing.Size(94, 38);
            this.studentLoginbtn.TabIndex = 4;
            this.studentLoginbtn.Text = "Login";
            this.studentLoginbtn.UseVisualStyleBackColor = true;
            this.studentLoginbtn.Click += new System.EventHandler(this.studentLoginbtn_Click);
            // 
            // studentPasswordtxt
            // 
            this.studentPasswordtxt.Location = new System.Drawing.Point(68, 192);
            this.studentPasswordtxt.Name = "studentPasswordtxt";
            this.studentPasswordtxt.Size = new System.Drawing.Size(241, 22);
            this.studentPasswordtxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            // 
            // studentEmailtxt
            // 
            this.studentEmailtxt.Location = new System.Drawing.Point(68, 86);
            this.studentEmailtxt.Name = "studentEmailtxt";
            this.studentEmailtxt.Size = new System.Drawing.Size(241, 22);
            this.studentEmailtxt.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 730);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminEmailText;
        private System.Windows.Forms.TextBox adminPasswordText;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button teacherLoginbtn;
        private System.Windows.Forms.TextBox teacherPasswordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherEmailtxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button studentLoginbtn;
        private System.Windows.Forms.TextBox studentPasswordtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentEmailtxt;
    }
}

