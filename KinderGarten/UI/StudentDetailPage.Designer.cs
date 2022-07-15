
namespace KinderGarten.UI
{
    partial class StudentDetailPage
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
            this.studentsdgv = new System.Windows.Forms.DataGridView();
            this.closebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentClasscmb = new System.Windows.Forms.ComboBox();
            this.labelll = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentParentNametxt = new System.Windows.Forms.TextBox();
            this.studentMedicinetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentPasswordtxt = new System.Windows.Forms.TextBox();
            this.studentPhonetxt = new System.Windows.Forms.TextBox();
            this.studentAddresstxt = new System.Windows.Forms.TextBox();
            this.studentBirthdatetxt = new System.Windows.Forms.TextBox();
            this.studentEmailtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.studentNachnametxt = new System.Windows.Forms.TextBox();
            this.studentNametxt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsdgv
            // 
            this.studentsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsdgv.Location = new System.Drawing.Point(46, 85);
            this.studentsdgv.Name = "studentsdgv";
            this.studentsdgv.RowHeadersWidth = 51;
            this.studentsdgv.RowTemplate.Height = 24;
            this.studentsdgv.Size = new System.Drawing.Size(1060, 447);
            this.studentsdgv.TabIndex = 6;
            this.studentsdgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentsdgv_RowHeaderMouseClick);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(46, 25);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(143, 42);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "Verlassen";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentClasscmb);
            this.groupBox1.Controls.Add(this.labelll);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.studentParentNametxt);
            this.groupBox1.Controls.Add(this.studentMedicinetxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.studentPasswordtxt);
            this.groupBox1.Controls.Add(this.studentPhonetxt);
            this.groupBox1.Controls.Add(this.studentAddresstxt);
            this.groupBox1.Controls.Add(this.studentBirthdatetxt);
            this.groupBox1.Controls.Add(this.studentEmailtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.studentNachnametxt);
            this.groupBox1.Controls.Add(this.studentNametxt);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(46, 562);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 297);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // studentClasscmb
            // 
            this.studentClasscmb.FormattingEnabled = true;
            this.studentClasscmb.Location = new System.Drawing.Point(544, 232);
            this.studentClasscmb.Name = "studentClasscmb";
            this.studentClasscmb.Size = new System.Drawing.Size(144, 24);
            this.studentClasscmb.TabIndex = 29;
            // 
            // labelll
            // 
            this.labelll.Location = new System.Drawing.Point(391, 232);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(147, 23);
            this.labelll.TabIndex = 28;
            this.labelll.Text = "Class";
            this.labelll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(391, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Elternname";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentParentNametxt
            // 
            this.studentParentNametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentParentNametxt.Location = new System.Drawing.Point(544, 179);
            this.studentParentNametxt.Name = "studentParentNametxt";
            this.studentParentNametxt.Size = new System.Drawing.Size(144, 22);
            this.studentParentNametxt.TabIndex = 26;
            // 
            // studentMedicinetxt
            // 
            this.studentMedicinetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentMedicinetxt.Location = new System.Drawing.Point(200, 232);
            this.studentMedicinetxt.Name = "studentMedicinetxt";
            this.studentMedicinetxt.Size = new System.Drawing.Size(144, 22);
            this.studentMedicinetxt.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Medizin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentPasswordtxt
            // 
            this.studentPasswordtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentPasswordtxt.Location = new System.Drawing.Point(544, 134);
            this.studentPasswordtxt.Name = "studentPasswordtxt";
            this.studentPasswordtxt.Size = new System.Drawing.Size(144, 22);
            this.studentPasswordtxt.TabIndex = 21;
            // 
            // studentPhonetxt
            // 
            this.studentPhonetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentPhonetxt.Location = new System.Drawing.Point(544, 81);
            this.studentPhonetxt.Name = "studentPhonetxt";
            this.studentPhonetxt.Size = new System.Drawing.Size(144, 22);
            this.studentPhonetxt.TabIndex = 20;
            // 
            // studentAddresstxt
            // 
            this.studentAddresstxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentAddresstxt.Location = new System.Drawing.Point(544, 32);
            this.studentAddresstxt.Name = "studentAddresstxt";
            this.studentAddresstxt.Size = new System.Drawing.Size(144, 22);
            this.studentAddresstxt.TabIndex = 19;
            // 
            // studentBirthdatetxt
            // 
            this.studentBirthdatetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentBirthdatetxt.Location = new System.Drawing.Point(200, 179);
            this.studentBirthdatetxt.Name = "studentBirthdatetxt";
            this.studentBirthdatetxt.Size = new System.Drawing.Size(144, 22);
            this.studentBirthdatetxt.TabIndex = 18;
            // 
            // studentEmailtxt
            // 
            this.studentEmailtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentEmailtxt.Location = new System.Drawing.Point(200, 134);
            this.studentEmailtxt.Name = "studentEmailtxt";
            this.studentEmailtxt.Size = new System.Drawing.Size(144, 22);
            this.studentEmailtxt.TabIndex = 17;
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(391, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefonnummer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Geburtsdatum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // studentNachnametxt
            // 
            this.studentNachnametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentNachnametxt.Location = new System.Drawing.Point(200, 82);
            this.studentNachnametxt.Name = "studentNachnametxt";
            this.studentNachnametxt.Size = new System.Drawing.Size(144, 22);
            this.studentNachnametxt.TabIndex = 7;
            // 
            // studentNametxt
            // 
            this.studentNametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.studentNametxt.Location = new System.Drawing.Point(200, 32);
            this.studentNametxt.Name = "studentNametxt";
            this.studentNametxt.Size = new System.Drawing.Size(144, 22);
            this.studentNametxt.TabIndex = 6;
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
            // StudentDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 869);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.studentsdgv);
            this.Name = "StudentDetailPage";
            this.Text = "StudentDetailPage";
            this.Load += new System.EventHandler(this.StudentDetailPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsdgv;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox studentPasswordtxt;
        private System.Windows.Forms.TextBox studentPhonetxt;
        private System.Windows.Forms.TextBox studentAddresstxt;
        private System.Windows.Forms.TextBox studentBirthdatetxt;
        private System.Windows.Forms.TextBox studentEmailtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox studentNachnametxt;
        private System.Windows.Forms.TextBox studentNametxt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox studentClasscmb;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentParentNametxt;
        private System.Windows.Forms.TextBox studentMedicinetxt;
        private System.Windows.Forms.Label label6;
    }
}