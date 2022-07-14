using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinderGarten.DataAccess.Concrete;

namespace KinderGarten.UI
{
    public partial class TeacherDetailPage : Form
    {
        private EfTeacherDal _teacherDal;
        private int tempId;
        public TeacherDetailPage()
        {
            InitializeComponent();
            _teacherDal = new EfTeacherDal();
        }

        private void PopulateTable()
        {
            teachersdgv.DataSource = _teacherDal.GetAll();
        }

        private void TeacherDetailPage_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void teachersdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            teacherNametxt.Text = teachersdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            teacherNachnametxt.Text = teachersdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            teacherAddresstxt.Text = teachersdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            teacherPhonetxt.Text = teachersdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            teacherBirthdatetxt.Text = teachersdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            teacherPasswordtxt.Text = teachersdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            teacherEmailtxt.Text = teachersdgv.Rows[e.RowIndex].Cells[7].Value.ToString();

            tempId = Int32.Parse(teachersdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var thisTeacher = _teacherDal.Get(t => t.Id == tempId);
                thisTeacher.Name = teacherNametxt.Text;
                thisTeacher.LastName = teacherNachnametxt.Text;
                thisTeacher.Address = teacherAddresstxt.Text;
                thisTeacher.PhoneNumber = teacherPhonetxt.Text;
                thisTeacher.BirthDate = teacherBirthdatetxt.Text;
                thisTeacher.Password = teacherPasswordtxt.Text;
                thisTeacher.Email = teacherEmailtxt.Text;


                _teacherDal.Update(thisTeacher);

                PopulateTable();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                _teacherDal.Delete(_teacherDal.Get(t => t.Id == tempId));

                PopulateTable();
            }
        }
    }
}
