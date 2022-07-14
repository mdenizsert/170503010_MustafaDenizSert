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
    public partial class TeacherPage : Form
    {
        private EfTeacherDal _teacherDal;
        private EfStudentDal _studentDal;
        private EfClassDal _classDal;
        private Teacher _currentTeacher;

        public TeacherPage()
        {
            InitializeComponent();
            _teacherDal = new EfTeacherDal();
            _studentDal = new EfStudentDal();
            _classDal = new EfClassDal();
            _currentTeacher = _teacherDal.Get(t => t.Email == Login.currentTeacherEmail);
        }



        private void PopulateTable()
        {
            var thisClass = _classDal.Get(c => c.TeacherId == _currentTeacher.Id);
            
            classesdgv.DataSource = _studentDal.GetAll(s=> s.ClassId == thisClass.Id);
        }

        private void GetTeacherInformation()
        {
            teacherNametxt.Text = _currentTeacher.Name;
            teacherNachnametxt.Text = _currentTeacher.LastName;
            teacherAddresstxt.Text = _currentTeacher.Address;
            teacherPhonetxt.Text = _currentTeacher.PhoneNumber;
            teacherBirthdatetxt.Text = _currentTeacher.BirthDate;
            teacherPasswordtxt.Text = _currentTeacher.Password;
            teacherEmailtxt.Text = _currentTeacher.Email;
        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {
            teacherHellotxt.Text = "Welcome " + _currentTeacher.Name + " " + _currentTeacher.LastName;
            PopulateTable();
            GetTeacherInformation();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var thisTeacher = _teacherDal.Get(t => t.Id == _currentTeacher.Id);
            thisTeacher.Name = teacherNametxt.Text;
            thisTeacher.LastName = teacherNachnametxt.Text;
            thisTeacher.Address = teacherAddresstxt.Text;
            thisTeacher.PhoneNumber = teacherPhonetxt.Text;
            thisTeacher.BirthDate = teacherBirthdatetxt.Text;
            thisTeacher.Password = teacherPasswordtxt.Text;
            thisTeacher.Email = teacherEmailtxt.Text;


            _teacherDal.Update(thisTeacher);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
