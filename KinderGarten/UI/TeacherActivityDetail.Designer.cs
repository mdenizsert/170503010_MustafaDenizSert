
namespace KinderGarten.UI
{
    partial class TeacherActivityDetail
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
            this.activitiesdvg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addActivitybtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.ageGrouptxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.contexttxt = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addStudentbtn = new System.Windows.Forms.Button();
            this.addstudentcmb = new System.Windows.Forms.ComboBox();
            this.studentListdgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesdvg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // activitiesdvg
            // 
            this.activitiesdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesdvg.Location = new System.Drawing.Point(22, 36);
            this.activitiesdvg.Name = "activitiesdvg";
            this.activitiesdvg.RowHeadersWidth = 51;
            this.activitiesdvg.RowTemplate.Height = 24;
            this.activitiesdvg.Size = new System.Drawing.Size(917, 535);
            this.activitiesdvg.TabIndex = 0;
            this.activitiesdvg.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.activitiesdvg_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addActivitybtn);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.ageGrouptxt);
            this.groupBox1.Controls.Add(this.periodtxt);
            this.groupBox1.Controls.Add(this.contexttxt);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(22, 614);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // addActivitybtn
            // 
            this.addActivitybtn.Location = new System.Drawing.Point(748, 229);
            this.addActivitybtn.Name = "addActivitybtn";
            this.addActivitybtn.Size = new System.Drawing.Size(218, 67);
            this.addActivitybtn.TabIndex = 11;
            this.addActivitybtn.Text = "Hinzufügen";
            this.addActivitybtn.UseVisualStyleBackColor = true;
            this.addActivitybtn.Click += new System.EventHandler(this.addActivitybtn_Click);
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
            // ageGrouptxt
            // 
            this.ageGrouptxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ageGrouptxt.Location = new System.Drawing.Point(303, 179);
            this.ageGrouptxt.Name = "ageGrouptxt";
            this.ageGrouptxt.Size = new System.Drawing.Size(144, 22);
            this.ageGrouptxt.TabIndex = 8;
            // 
            // periodtxt
            // 
            this.periodtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.periodtxt.Location = new System.Drawing.Point(303, 106);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(144, 22);
            this.periodtxt.TabIndex = 7;
            // 
            // contexttxt
            // 
            this.contexttxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contexttxt.Location = new System.Drawing.Point(303, 30);
            this.contexttxt.Name = "contexttxt";
            this.contexttxt.Size = new System.Drawing.Size(144, 22);
            this.contexttxt.TabIndex = 6;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(25, 178);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 23);
            this.label29.TabIndex = 5;
            this.label29.Text = "Altersgruppe";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(25, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 23);
            this.label30.TabIndex = 3;
            this.label30.Text = "Zeitraum";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(25, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(147, 23);
            this.label31.TabIndex = 2;
            this.label31.Text = "Inhalt";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addStudentbtn);
            this.groupBox2.Controls.Add(this.addstudentcmb);
            this.groupBox2.Location = new System.Drawing.Point(1342, 614);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 421);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Hinzufügen";
            // 
            // addStudentbtn
            // 
            this.addStudentbtn.Location = new System.Drawing.Point(54, 255);
            this.addStudentbtn.Name = "addStudentbtn";
            this.addStudentbtn.Size = new System.Drawing.Size(200, 117);
            this.addStudentbtn.TabIndex = 2;
            this.addStudentbtn.Text = "Hinzufügen";
            this.addStudentbtn.UseVisualStyleBackColor = true;
            this.addStudentbtn.Click += new System.EventHandler(this.addStudentbtn_Click);
            // 
            // addstudentcmb
            // 
            this.addstudentcmb.FormattingEnabled = true;
            this.addstudentcmb.Location = new System.Drawing.Point(54, 85);
            this.addstudentcmb.Name = "addstudentcmb";
            this.addstudentcmb.Size = new System.Drawing.Size(200, 24);
            this.addstudentcmb.TabIndex = 1;
            // 
            // studentListdgv
            // 
            this.studentListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListdgv.Location = new System.Drawing.Point(1088, 36);
            this.studentListdgv.Name = "studentListdgv";
            this.studentListdgv.RowHeadersWidth = 51;
            this.studentListdgv.RowTemplate.Height = 24;
            this.studentListdgv.Size = new System.Drawing.Size(831, 535);
            this.studentListdgv.TabIndex = 4;
            // 
            // TeacherActivityDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.studentListdgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.activitiesdvg);
            this.Name = "TeacherActivityDetail";
            this.Text = "TeacherActivityDetail";
            this.Load += new System.EventHandler(this.TeacherActivityDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesdvg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentListdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView activitiesdvg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addActivitybtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox ageGrouptxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox contexttxt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addStudentbtn;
        private System.Windows.Forms.ComboBox addstudentcmb;
        private System.Windows.Forms.DataGridView studentListdgv;
    }
}