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
using KinderGarten.UI;

namespace KinderGarten.Entities.UI
{
    public partial class AdminPage : Form
    {
        private EfAdminDal _adminDal;
        private EfClassDal _classDal;
        private EfStudentDal _studentDal;
        private EfTeacherDal _teacherDal;
        private EfActivityDal _activityDal;
        public AdminPage()
        {
            InitializeComponent();

            _teacherDal = new EfTeacherDal();
            _adminDal = new EfAdminDal();
            _classDal = new EfClassDal();
            _studentDal = new EfStudentDal();
            _activityDal = new EfActivityDal();
        }

        private void addStudentbtn_Click(object sender, EventArgs e)
        {

            var student = new Entities.Student
            {
                Name = studentNametxt.Text,
                ParentName = studentParentnametxt.Text,
                LastName = studentLastnametxt.Text,
                Address = studentAddresstxt.Text,
                PhoneNumber = studentPhonetxt.Text,
                BirthDate = studentBirthdatetxt.Text,
                Password = studentPasswordtxt.Text,
                Age = ageCalculator(studentBirthdatetxt.Text),
                Medicine = studentMedicinetxt.Text,
                ClassId = getClassId(studentClasscmb.Text),
                Email = studentEmailtxt.Text
            };

            _studentDal.Add(student);
            
        }

       

        private void addTeacherbtn_Click(object sender, EventArgs e)
        {
            var teacher = new Entities.Teacher
            {
                Name = teacherNametxt.Text,
                LastName = teacherLastnametxt.Text,
                Address = teacherAddresstxt.Text,
                PhoneNumber = teacherPhonetxt.Text,
                BirthDate = teacherBirthdatetxt.Text,
                Password = teacherPasswordtxt.Text,
                Email = teacherEmailtxt.Text
            };

            _teacherDal.Add(teacher);
            updateClassCombobox();
        }


        

        private void addAdminbtn_Click(object sender, EventArgs e)
        {
            var admin = new Entities.Admin
            {
                Name = adminNametxt.Text,
                LastName = adminLastnametxt.Text,
                Address = adminAddresstxt.Text,
                PhoneNumber = adminPhonetxt.Text,
                BirthDate = adminBirthdatetxt.Text,
                Password = adminPasswordtxt.Text,
                Email = adminEmailtxt.Text
            };

            _adminDal.Add(admin);
        }


       

        private void addActivitybtn_Click(object sender, EventArgs e)
        {
            var activity = new Entities.Activity
            {
                Content = activityContenttxt.Text,
                AgeGroup = activityAgeGrouptxt.Text,
                Period = activityPeriodtxt.Text
            };

            _activityDal.Add(activity);
        }

        

        private void addClassbtn_Click(object sender, EventArgs e)
        {
            var addingClass = new Entities.Class
            {
                Name = classNametxt.Text,
                TeacherId = getTeacherId(classLehrernamecmb.Text)
            };

            _classDal.Add(addingClass);
            updateStudentCombobox();

        }


        private int getClassId(string className)
        {
            var thisClass = _classDal.Get(c => c.Name  == className);
            var classId = thisClass.Id;
            return classId;
        }

        private int getTeacherId(string teacherName)
        {
            var thisTeacher = _teacherDal.Get(t => t.Name + " " + t.LastName == teacherName);
            var teacherId = thisTeacher.Id;
            return teacherId;
        }

        private void updateStudentCombobox()
        {
            studentClasscmb.Items.Clear();

            var classes = _classDal.GetAll();

            foreach (var c in classes)
            {
                studentClasscmb.Items.Add(c.Name);
            }
        }

        private void updateClassCombobox()
        {
            classLehrernamecmb.Items.Clear();

            var teachers = _teacherDal.GetAll();

            foreach (var teacher in teachers)
            {
                var totalName = teacher.Name + " " + teacher.LastName;
                classLehrernamecmb.Items.Add(totalName);
            }
        }


        private int ageCalculator(string birthDate)
        {
            bool success = Int32.TryParse(birthDate, out int date);

            if (success)
            {
                int age = 2022 - date;
                return age;
            }
            else
            {
                Console.WriteLine("Input string is invalid.");
                return -1;
            }
        }

        private void studentDetailbtn_Click(object sender, EventArgs e)
        {
            var form = new StudentDetailPage();
            form.Show();
            this.Hide();
        }

        private void teacherDetailbtn_Click(object sender, EventArgs e)
        {
            var form = new TeacherDetailPage();
            form.Show();
            this.Hide();
        }

        private void adminDetailbtn_Click(object sender, EventArgs e)
        {
            var form = new AdminDetailPage();
            form.Show();
            this.Hide();
        }

        private void activityDetailbtn_Click(object sender, EventArgs e)
        {
            var form = new ActivityDetailPage();
            form.Show();
            this.Hide();
        }

        private void classDetailbtn_Click(object sender, EventArgs e)
        {
            var form = new ClassDetailPage();
            form.Show();
            this.Hide();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            updateClassCombobox();
            updateStudentCombobox();
        }
    }
}
