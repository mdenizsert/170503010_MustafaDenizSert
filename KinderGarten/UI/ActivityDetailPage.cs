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
    public partial class ActivityDetailPage : Form
    {
        private EfActivityDal _activityDal;
        private int tempId;
        public int passingId;
        public ActivityDetailPage()
        {
            InitializeComponent();

            _activityDal = new EfActivityDal();
        }

        private void activitiesdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contexttxt.Text = activitiesdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            ageGrouptxt.Text = activitiesdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            periodtxt.Text = activitiesdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
           

            tempId = Int32.Parse(activitiesdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void ActivityDetailPage_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void PopulateTable()
        {
            activitiesdgv.DataSource = _activityDal.GetAll();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                _activityDal.Delete(_activityDal.Get(a => a.Id == tempId));

                PopulateTable();
            }

            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var activity = _activityDal.Get(a => a.Id == tempId);
                activity.Content = contexttxt.Text;
                activity.AgeGroup = ageGrouptxt.Text;
                activity.Period = periodtxt.Text;

                _activityDal.Update(activity);

                PopulateTable();
            }

            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }

        private void activitiesdgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            passingId = Int32.Parse(activitiesdgv.Rows[e.RowIndex].Cells[0].Value.ToString());


            var form = new OneActivityDetail(this);
            form.ShowDialog();
            
        }
    }
}
