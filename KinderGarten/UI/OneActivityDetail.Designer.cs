
namespace KinderGarten.UI
{
    partial class OneActivityDetail
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
            this.addStudentbtn = new System.Windows.Forms.Button();
            this.addstudentcmb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addTeacherbtn = new System.Windows.Forms.Button();
            this.addTeachercmb = new System.Windows.Forms.ComboBox();
            this.teacherListdgv = new System.Windows.Forms.DataGridView();
            this.studentListdgv = new System.Windows.Forms.DataGridView();
            this.deleteLehrerbtn = new System.Windows.Forms.Button();
            this.deleteStudentbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addStudentbtn);
            this.groupBox1.Controls.Add(this.addstudentcmb);
            this.groupBox1.Location = new System.Drawing.Point(59, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Hinzufügen";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addTeacherbtn);
            this.groupBox2.Controls.Add(this.addTeachercmb);
            this.groupBox2.Location = new System.Drawing.Point(438, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher hinzufügen";
            // 
            // addTeacherbtn
            // 
            this.addTeacherbtn.Location = new System.Drawing.Point(55, 255);
            this.addTeacherbtn.Name = "addTeacherbtn";
            this.addTeacherbtn.Size = new System.Drawing.Size(200, 117);
            this.addTeacherbtn.TabIndex = 1;
            this.addTeacherbtn.Text = "Hinzufügen";
            this.addTeacherbtn.UseVisualStyleBackColor = true;
            this.addTeacherbtn.Click += new System.EventHandler(this.addTeacherbtn_Click);
            // 
            // addTeachercmb
            // 
            this.addTeachercmb.FormattingEnabled = true;
            this.addTeachercmb.Location = new System.Drawing.Point(55, 85);
            this.addTeachercmb.Name = "addTeachercmb";
            this.addTeachercmb.Size = new System.Drawing.Size(200, 24);
            this.addTeachercmb.TabIndex = 0;
            // 
            // teacherListdgv
            // 
            this.teacherListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherListdgv.Location = new System.Drawing.Point(59, 497);
            this.teacherListdgv.Name = "teacherListdgv";
            this.teacherListdgv.RowHeadersWidth = 51;
            this.teacherListdgv.RowTemplate.Height = 24;
            this.teacherListdgv.Size = new System.Drawing.Size(719, 250);
            this.teacherListdgv.TabIndex = 2;
            this.teacherListdgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.teacherListdgv_RowHeaderMouseClick);
            // 
            // studentListdgv
            // 
            this.studentListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListdgv.Location = new System.Drawing.Point(818, 38);
            this.studentListdgv.Name = "studentListdgv";
            this.studentListdgv.RowHeadersWidth = 51;
            this.studentListdgv.RowTemplate.Height = 24;
            this.studentListdgv.Size = new System.Drawing.Size(831, 709);
            this.studentListdgv.TabIndex = 3;
            this.studentListdgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentListdgv_RowHeaderMouseClick);
            // 
            // deleteLehrerbtn
            // 
            this.deleteLehrerbtn.Location = new System.Drawing.Point(331, 794);
            this.deleteLehrerbtn.Name = "deleteLehrerbtn";
            this.deleteLehrerbtn.Size = new System.Drawing.Size(117, 64);
            this.deleteLehrerbtn.TabIndex = 4;
            this.deleteLehrerbtn.Text = "Lehrer Löschen";
            this.deleteLehrerbtn.UseVisualStyleBackColor = true;
            this.deleteLehrerbtn.Click += new System.EventHandler(this.deleteLehrerbtn_Click);
            // 
            // deleteStudentbtn
            // 
            this.deleteStudentbtn.Location = new System.Drawing.Point(1193, 794);
            this.deleteStudentbtn.Name = "deleteStudentbtn";
            this.deleteStudentbtn.Size = new System.Drawing.Size(117, 64);
            this.deleteStudentbtn.TabIndex = 5;
            this.deleteStudentbtn.Text = "Student Löschen";
            this.deleteStudentbtn.UseVisualStyleBackColor = true;
            this.deleteStudentbtn.Click += new System.EventHandler(this.deleteStudentbtn_Click);
            // 
            // OneActivityDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 892);
            this.Controls.Add(this.deleteStudentbtn);
            this.Controls.Add(this.deleteLehrerbtn);
            this.Controls.Add(this.studentListdgv);
            this.Controls.Add(this.teacherListdgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OneActivityDetail";
            this.Text = "OneActivityDetail";
            this.Load += new System.EventHandler(this.OneActivityDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherListdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addStudentbtn;
        private System.Windows.Forms.ComboBox addstudentcmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addTeacherbtn;
        private System.Windows.Forms.ComboBox addTeachercmb;
        private System.Windows.Forms.DataGridView teacherListdgv;
        private System.Windows.Forms.DataGridView studentListdgv;
        private System.Windows.Forms.Button deleteLehrerbtn;
        private System.Windows.Forms.Button deleteStudentbtn;
    }
}