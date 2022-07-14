
namespace KinderGarten.UI
{
    partial class OneClassDetailPage
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
            this.studentListdgv = new System.Windows.Forms.DataGridView();
            this.classNamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherNamelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListdgv
            // 
            this.studentListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListdgv.Location = new System.Drawing.Point(187, 98);
            this.studentListdgv.Name = "studentListdgv";
            this.studentListdgv.RowHeadersWidth = 51;
            this.studentListdgv.RowTemplate.Height = 24;
            this.studentListdgv.Size = new System.Drawing.Size(831, 644);
            this.studentListdgv.TabIndex = 4;
            // 
            // classNamelbl
            // 
            this.classNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classNamelbl.Location = new System.Drawing.Point(179, 22);
            this.classNamelbl.Name = "classNamelbl";
            this.classNamelbl.Size = new System.Drawing.Size(299, 64);
            this.classNamelbl.TabIndex = 5;
            this.classNamelbl.Text = "label1";
            this.classNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(694, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lehrer";
            // 
            // teacherNamelbl
            // 
            this.teacherNamelbl.AutoSize = true;
            this.teacherNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherNamelbl.Location = new System.Drawing.Point(808, 45);
            this.teacherNamelbl.Name = "teacherNamelbl";
            this.teacherNamelbl.Size = new System.Drawing.Size(81, 29);
            this.teacherNamelbl.TabIndex = 7;
            this.teacherNamelbl.Text = "label2";
            // 
            // OneClassDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 766);
            this.Controls.Add(this.teacherNamelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classNamelbl);
            this.Controls.Add(this.studentListdgv);
            this.Name = "OneClassDetailPage";
            this.Text = "OneClassDetailPage";
            this.Load += new System.EventHandler(this.OneClassDetailPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentListdgv;
        private System.Windows.Forms.Label classNamelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teacherNamelbl;
    }
}