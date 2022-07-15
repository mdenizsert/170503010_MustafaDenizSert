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
using KinderGarten.Entities;

namespace KinderGarten.UI
{
    public partial class StudentPage : Form
    {
        private EfStudentDal _studentDal;
        private EfActivityDal _activityDal;
        private EfActivityStudentDal _activityStudentDal;
        private EfClassDal _classDal;
        private Student _currentStudent;

        public StudentPage()
        {
            InitializeComponent();

            _studentDal = new EfStudentDal();
            _activityDal = new EfActivityDal();
            _activityStudentDal = new EfActivityStudentDal();
            _classDal = new EfClassDal();
            _currentStudent = _studentDal.Get(s => s.Email == Login.currentStudentEmail);
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            studentHellotxt.Text = "Welcome " + _currentStudent.Name + " " + _currentStudent.LastName;

            namelbl.Text = _currentStudent.Name;
            lastnamelbl.Text = _currentStudent.LastName;
            parentNamelbl.Text = _currentStudent.ParentName;
            addresslbl.Text = _currentStudent.Address;
            phonelbl.Text = _currentStudent.PhoneNumber;
            birthDatelbl.Text = _currentStudent.BirthDate;
            medicinelbl.Text = _currentStudent.Medicine;
            emaillbl.Text = _currentStudent.Email;
            classlbl.Text = GetClassName(_currentStudent.ClassId);
            agelbl.Text = _currentStudent.Age.ToString();

            PopulateTable();
        }

        private string GetClassName(int id)
        {
            var thisClass = _classDal.Get(c => c.Id == id);
            return thisClass.Name;
        }

        private void PopulateTable()
        {
            var activityStudent = _activityStudentDal.GetAll(acstu => acstu.StudentId == _currentStudent.Id);
            var activities = new List<Activity>();

            foreach (var acstu in activityStudent)
            {
                var activity = _activityDal.Get(a => a.Id == acstu.ActivityId);
                activities.Add(activity);
            }

            activitiesdvg.DataSource = activities;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
