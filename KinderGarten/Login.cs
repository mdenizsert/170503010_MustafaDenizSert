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

namespace KinderGarten
{
    public partial class Login : Form
    {
        private EfAdminDal _adminDal;
        private EfStudentDal _studentDal;
        private EfTeacherDal _teacherDal;
        public Login()
        {
            InitializeComponent();
            _adminDal = new EfAdminDal();
            _studentDal = new EfStudentDal();
            _teacherDal = new EfTeacherDal();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            var email = adminEmailText.Text;
            var password = adminPasswordText.Text;
            var user = _adminDal.Get(x => x.Email == email);
            if (user is null)
            {
                warnLabel.BackColor = Color.Crimson;
                warnLabel.Text = "Bitte überprüfen Sie Ihre Eingaben";
                return;

            }

            if (user.Password != password)
            {
                warnLabel.BackColor = Color.Crimson;
                warnLabel.Text = "Ihr Passwort ist falsch";
                return;
            }

            warnLabel.Text = "Success";

            var adminForm = new AdminPage();
            adminForm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
