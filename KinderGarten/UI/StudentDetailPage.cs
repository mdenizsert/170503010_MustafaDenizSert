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
    public partial class StudentDetailPage : Form
    {
        private EfStudentDal _studentDal;
        private EfClassDal _classDal;
        private int tempId;
        private int tempAge;
        public StudentDetailPage()
        {
            InitializeComponent();

            _studentDal = new EfStudentDal();
            _classDal = new EfClassDal();
        }

        private void PopulateTable()
        {
            studentsdgv.DataSource = _studentDal.GetAll();
        }

        private void StudentDetailPage_Load(object sender, EventArgs e)
        {
            PopulateTable();
            updateClassCombobox();
        }

        private void studentsdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentNametxt.Text = studentsdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            studentParentNametxt.Text = studentsdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            studentNachnametxt.Text = studentsdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            studentAddresstxt.Text = studentsdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            studentPhonetxt.Text = studentsdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            studentBirthdatetxt.Text = studentsdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            studentPasswordtxt.Text = studentsdgv.Rows[e.RowIndex].Cells[7].Value.ToString();

            studentMedicinetxt.Text = studentsdgv.Rows[e.RowIndex].Cells[9].Value.ToString();
            studentClasscmb.Text = studentsdgv.Rows[e.RowIndex].Cells[10].Value.ToString();
            studentEmailtxt.Text = studentsdgv.Rows[e.RowIndex].Cells[11].Value.ToString();

            tempId = Int32.Parse(studentsdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            tempAge = ageCalculator(studentBirthdatetxt.Text);

        }

        

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var thisStudent = _studentDal.Get(s => s.Id == tempId);
                thisStudent.Name = studentNametxt.Text;
                thisStudent.ParentName = studentParentNametxt.Text;
                thisStudent.LastName = studentNachnametxt.Text;
                thisStudent.Address = studentAddresstxt.Text;
                thisStudent.PhoneNumber = studentPhonetxt.Text;
                thisStudent.BirthDate = studentBirthdatetxt.Text;
                thisStudent.Password = studentPasswordtxt.Text;
                thisStudent.Age = tempAge;
                thisStudent.Medicine = studentMedicinetxt.Text;
                thisStudent.ClassId = getClassId(studentClasscmb.Text);
                thisStudent.Email = studentEmailtxt.Text;

                _studentDal.Update(thisStudent);

                PopulateTable();
            }
        }


        private void updateClassCombobox()
        {
            studentClasscmb.Items.Clear();

            var classes = _classDal.GetAll();

            foreach (var c in classes)
            {
                studentClasscmb.Items.Add(c.Name);
            }
        }

        private int getClassId(string className)
        {
            var thisClass = _classDal.Get(c => c.Name == className);
            var classId = thisClass.Id;
            return classId;
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
