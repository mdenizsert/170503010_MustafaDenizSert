
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
            this.adminPasswordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminEmailText = new System.Windows.Forms.TextBox();
            this.adminLogin = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.warnLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 730);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

