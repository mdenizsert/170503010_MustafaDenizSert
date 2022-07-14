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
using KinderGarten.Entities.UI;

namespace KinderGarten.UI
{
    public partial class ClassDetailPage : Form
    {
        private EfClassDal _classDal;
        private EfTeacherDal _teacherDal;
        private int tempId;
        private int tempTeacherId;
        public int passingId;
        public ClassDetailPage()
        {
            InitializeComponent();

            _classDal = new EfClassDal();
            _teacherDal = new EfTeacherDal();
        }



        private void PopulateTable()
        {
            classesdgv.DataSource = _classDal.GetAll();
        }

        private void ClassDetailPage_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void classesdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            classNametxt.Text = classesdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            tempTeacherId = Int32.Parse(classesdgv.Rows[e.RowIndex].Cells[2].Value.ToString());

            var teacher = _teacherDal.Get(t => t.Id == tempTeacherId);

            var tempName = teacher.Name + " " + teacher.LastName;

            teacherNametxt.Text = tempName;

            tempId = Int32.Parse(classesdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var thisClass = _classDal.Get(c => c.Id == tempId);
                thisClass.Name = classNametxt.Text;
                thisClass.TeacherId = tempTeacherId;
                

                _classDal.Update(thisClass);

                PopulateTable();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                _classDal.Delete(_classDal.Get(c => c.Id == tempId));

                PopulateTable();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }

        private void classesdgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            passingId = Int32.Parse(classesdgv.Rows[e.RowIndex].Cells[0].Value.ToString());


            var form = new OneClassDetailPage(this);
            form.ShowDialog();
        }
    }
}
