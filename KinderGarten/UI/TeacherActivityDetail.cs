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
    public partial class TeacherActivityDetail : Form
    {
        private EfActivityDal _activityDal;
        private EfActivityTeacherDal _activityTeacherDal;
        private EfActivityStudentDal _activityStudentDal;
        private EfTeacherDal _teacherDal;
        private EfStudentDal _studentDal;
        private Teacher _currentTeacher;
        private int tempId;
        
        public TeacherActivityDetail()
        {
            InitializeComponent();

            _activityDal = new EfActivityDal();
            _activityStudentDal = new EfActivityStudentDal();
            _activityTeacherDal = new EfActivityTeacherDal();
            _currentTeacher = _teacherDal.Get(t => t.Email == Login.currentTeacherEmail);
        }

        private void TeacherActivityDetail_Load(object sender, EventArgs e)
        {
            PopulateTable();
            UpdateStudentCombobox();
        }

        private void PopulateTable()
        {
            var activities = new List<Activity>();
            var activityTeachers = _activityTeacherDal.GetAll(at => at.TeacherId == _currentTeacher.Id);
            foreach (var at in activityTeachers)
            {
                var activityId = at.ActivityId;
                activities.Add(_activityDal.Get(a=> a.Id == activityId));
            }
            

            activitiesdvg.DataSource = activities;
        }

        private void addActivitybtn_Click(object sender, EventArgs e)
        {
            var activity = new Entities.Activity
            {
                Content = contexttxt.Text,
                AgeGroup = ageGrouptxt.Text,
                Period = periodtxt.Text
            };

            _activityDal.Add(activity);
            PopulateTable();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if(tempId > 0)
            {
             var activity = _activityDal.Get(a => a.Id == tempId);
             activity.Content = contexttxt.Text;
             activity.AgeGroup = ageGrouptxt.Text;
             activity.Period = periodtxt.Text;

             _activityDal.Update(activity);

             PopulateTable();
            }
        }

        private void activitiesdvg_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contexttxt.Text = activitiesdvg.Rows[e.RowIndex].Cells[1].Value.ToString();
            ageGrouptxt.Text = activitiesdvg.Rows[e.RowIndex].Cells[2].Value.ToString();
            periodtxt.Text = activitiesdvg.Rows[e.RowIndex].Cells[3].Value.ToString();

            tempId = Int32.Parse(activitiesdvg.Rows[e.RowIndex].Cells[0].Value.ToString());

            PopulateStudentTable();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                _activityDal.Delete(_activityDal.Get(a => a.Id == tempId));

                PopulateTable();
            }
        }


        private void UpdateStudentCombobox()
        {
            addstudentcmb.Items.Clear();

            var students = _studentDal.GetAll();

            foreach (var student in students)
            {
                var totalName = student.Name + " " + student.LastName;
                addstudentcmb.Items.Add(totalName);
            }
        }

        private void PopulateStudentTable()
        {
            var activityStudents = _activityStudentDal.GetAll(x => x.ActivityId == tempId);

            var students = new List<Student>();
            foreach (var acstu in activityStudents)
            {
                var student = _studentDal.Get(s => s.Id == acstu.StudentId);
                students.Add(student);
            }

            studentListdgv.DataSource = students;
        }

        private void addStudentbtn_Click(object sender, EventArgs e)
        {
            var studentInActivity = new Entities.ActivityStudent()
            {
                ActivityId = tempId,
                StudentId = getStudentId(addstudentcmb.Text)
            };

            _activityStudentDal.Add(studentInActivity);
            PopulateStudentTable();
        }

        private int getStudentId(string studentName)
        {
            var thisStudent = _studentDal.Get(s => s.Name + " " + s.LastName == studentName);
            var studentId = thisStudent.Id;
            return studentId;
        }
    }
}
