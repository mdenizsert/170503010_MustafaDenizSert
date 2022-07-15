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
    public partial class AdminDetailPage : Form
    {
        private EfAdminDal _adminDal;
        private int tempId;
        public AdminDetailPage()
        {
            InitializeComponent();
            _adminDal = new EfAdminDal();
        }

        private void PopulateTable()
        {
            adminsdgv.DataSource = _adminDal.GetAll();
        }

        private void AdminDetailPage_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void adminsdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adminNametxt.Text = adminsdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            adminNachnametxt.Text = adminsdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            adminAddresstxt.Text = adminsdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            adminPhonetxt.Text = adminsdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            adminBirthdatetxt.Text = adminsdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            adminPasswordtxt.Text = adminsdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            adminEmailtxt.Text = adminsdgv.Rows[e.RowIndex].Cells[7].Value.ToString();

            tempId = Int32.Parse(adminsdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var thisAdmin = _adminDal.Get(a => a.Id == tempId);
                thisAdmin.Name = adminNametxt.Text;
                thisAdmin.LastName = adminNachnametxt.Text;
                thisAdmin.Address = adminAddresstxt.Text;
                thisAdmin.PhoneNumber = adminPhonetxt.Text;
                thisAdmin.BirthDate = adminBirthdatetxt.Text;
                thisAdmin.Password = adminPasswordtxt.Text;
                thisAdmin.Email = adminEmailtxt.Text;


                _adminDal.Update(thisAdmin);

                PopulateTable();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                _adminDal.Delete(_adminDal.Get(a => a.Id == tempId));

                PopulateTable();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }
    }
}
