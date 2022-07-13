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

namespace KinderGarten.Entities.UI
{
    public partial class AdminPage : Form
    {
        private EfAdminDal _adminDal;
        private EfClassDal _classDal;
        private EfStudentDal _studentDal;
        public AdminPage()
        {
            InitializeComponent();

            _adminDal = new EfAdminDal();
            _classDal = new EfClassDal();
            _studentDal = new EfStudentDal();
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
            updateComboboxes();
        }

        private int getClassId(string className)
        {
            var thisClass = _classDal.Get(c => c.Name == className);
            var classId = thisClass.Id;
            return classId;
        }

        private void updateComboboxes()
        {
            studentClasscmb.Items.Clear();

            var classes = _classDal.GetAll();

            foreach (var c in classes)
            {
                studentClasscmb.Items.Add(c.Name);
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
    }
}
