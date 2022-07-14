
namespace KinderGarten.UI
{
    partial class ClassDetailPage
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
            this.classesdgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.teacherNametxt = new System.Windows.Forms.TextBox();
            this.classNametxt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classesdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(59, 21);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(143, 42);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "Verlassen";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // classesdgv
            // 
            this.classesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classesdgv.Location = new System.Drawing.Point(59, 86);
            this.classesdgv.Name = "classesdgv";
            this.classesdgv.RowHeadersWidth = 51;
            this.classesdgv.RowTemplate.Height = 24;
            this.classesdgv.Size = new System.Drawing.Size(1060, 426);
            this.classesdgv.TabIndex = 4;
            this.classesdgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classesdgv_RowHeaderMouseClick);
            this.classesdgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.classesdgv_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.teacherNametxt);
            this.groupBox1.Controls.Add(this.classNametxt);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(59, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 233);
            this.groupBox1.TabIndex = 5;
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
            // teacherNametxt
            // 
            this.teacherNametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.teacherNametxt.Location = new System.Drawing.Point(303, 156);
            this.teacherNametxt.Name = "teacherNametxt";
            this.teacherNametxt.Size = new System.Drawing.Size(144, 22);
            this.teacherNametxt.TabIndex = 7;
            // 
            // classNametxt
            // 
            this.classNametxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.classNametxt.Location = new System.Drawing.Point(303, 57);
            this.classNametxt.Name = "classNametxt";
            this.classNametxt.Size = new System.Drawing.Size(144, 22);
            this.classNametxt.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(25, 156);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 23);
            this.label30.TabIndex = 3;
            this.label30.Text = "Lehrer Name";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(25, 56);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(147, 23);
            this.label31.TabIndex = 2;
            this.label31.Text = "Klasse Name";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 806);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.classesdgv);
            this.Controls.Add(this.closebtn);
            this.Name = "ClassDetailPage";
            this.Text = "ClassDetailPage";
            this.Load += new System.EventHandler(this.ClassDetailPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classesdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.DataGridView classesdgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox teacherNametxt;
        private System.Windows.Forms.TextBox classNametxt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
    }
}