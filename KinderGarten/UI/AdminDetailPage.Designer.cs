
namespace KinderGarten.UI
{
    partial class AdminDetailPage
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
            this.closebtn = new System.Windows.Forms.Button();
            this.adminsdgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.adminNachnametxt = new System.Windows.Forms.TextBox();
            this.adminNametxt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminEmailtxt = new System.Windows.Forms.TextBox();
            this.adminBirthdatetxt = new System.Windows.Forms.TextBox();
            this.adminAddresstxt = new System.Windows.Forms.TextBox();
            this.adminPhonetxt = new System.Windows.Forms.TextBox();
            this.adminPasswordtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminsdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(43, 21);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(143, 42);
            this.closebtn.TabIndex = 4;
            this.closebtn.Text = "Verlassen";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // adminsdgv
            // 
            this.adminsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminsdgv.Location = new System.Drawing.Point(43, 84);
            this.adminsdgv.Name = "adminsdgv";
            this.adminsdgv.RowHeadersWidth = 51;
            this.adminsdgv.RowTemplate.Height = 24;
            this.adminsdgv.Size = new System.Drawing.Size(1060, 447);
            this.adminsdgv.TabIndex = 5;
            this.adminsdgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.adminsdgv_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adminPasswordtxt);
            this.groupBox1.Controls.Add(this.adminPhonetxt);
            this.groupBox1.Controls.Add(this.adminAddresstxt);
            this.groupBox1.Controls.Add(this.adminBirthdatetxt);
            this.groupBox1.Controls.Add(this.adminEmailtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.adminNachnametxt);
            this.groupBox1.Controls.Add(this.adminNametxt);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(43, 587);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(748, 134);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(218, 67);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "Löschen";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(748, 31);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(218, 74);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Aktualisieren";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // adminNachnametxt
            // 
            this.adminNachnametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminNachnametxt.Location = new System.Drawing.Point(200, 82);
            this.adminNachnametxt.Name = "adminNachnametxt";
            this.adminNachnametxt.Size = new System.Drawing.Size(144, 22);
            this.adminNachnametxt.TabIndex = 7;
            // 
            // adminNametxt
            // 
            this.adminNametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminNametxt.Location = new System.Drawing.Point(200, 32);
            this.adminNametxt.Name = "adminNametxt";
            this.adminNametxt.Size = new System.Drawing.Size(144, 22);
            this.adminNametxt.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(25, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 23);
            this.label30.TabIndex = 3;
            this.label30.Text = "Nachname";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(25, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(147, 23);
            this.label31.TabIndex = 2;
            this.label31.Text = "Name";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Geburtsdatum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(391, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adresse";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(391, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefonnummer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(391, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminEmailtxt
            // 
            this.adminEmailtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminEmailtxt.Location = new System.Drawing.Point(200, 134);
            this.adminEmailtxt.Name = "adminEmailtxt";
            this.adminEmailtxt.Size = new System.Drawing.Size(144, 22);
            this.adminEmailtxt.TabIndex = 17;
            // 
            // adminBirthdatetxt
            // 
            this.adminBirthdatetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminBirthdatetxt.Location = new System.Drawing.Point(200, 179);
            this.adminBirthdatetxt.Name = "adminBirthdatetxt";
            this.adminBirthdatetxt.Size = new System.Drawing.Size(144, 22);
            this.adminBirthdatetxt.TabIndex = 18;
            // 
            // adminAddresstxt
            // 
            this.adminAddresstxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminAddresstxt.Location = new System.Drawing.Point(544, 32);
            this.adminAddresstxt.Name = "adminAddresstxt";
            this.adminAddresstxt.Size = new System.Drawing.Size(144, 22);
            this.adminAddresstxt.TabIndex = 19;
            // 
            // adminPhonetxt
            // 
            this.adminPhonetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminPhonetxt.Location = new System.Drawing.Point(544, 81);
            this.adminPhonetxt.Name = "adminPhonetxt";
            this.adminPhonetxt.Size = new System.Drawing.Size(144, 22);
            this.adminPhonetxt.TabIndex = 20;
            // 
            // adminPasswordtxt
            // 
            this.adminPasswordtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.adminPasswordtxt.Location = new System.Drawing.Point(544, 134);
            this.adminPasswordtxt.Name = "adminPasswordtxt";
            this.adminPasswordtxt.Size = new System.Drawing.Size(144, 22);
            this.adminPasswordtxt.TabIndex = 21;
            // 
            // AdminDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 870);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminsdgv);
            this.Controls.Add(this.closebtn);
            this.Name = "AdminDetailPage";
            this.Text = "AdminDetailPage";
            this.Load += new System.EventHandler(this.AdminDetailPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminsdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.DataGridView adminsdgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox adminNachnametxt;
        private System.Windows.Forms.TextBox adminNametxt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox adminPasswordtxt;
        private System.Windows.Forms.TextBox adminPhonetxt;
        private System.Windows.Forms.TextBox adminAddresstxt;
        private System.Windows.Forms.TextBox adminBirthdatetxt;
        private System.Windows.Forms.TextBox adminEmailtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}