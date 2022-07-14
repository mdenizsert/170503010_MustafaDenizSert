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
    public partial class OneActivityDetail : Form
    {
        private EfActivityDal _activityDal;
        private EfTeacherDal _teacherDal;
        private EfStudentDal _studentDal;
        private EfActivityStudentDal _activityStudentDal;
        private EfActivityTeacherDal _activityTeacherDal;
        private int activityId;
        private int tempTeacherId;
        private int tempStudentId;

        private ActivityDetailPage activityDetailPage;
        public OneActivityDetail(ActivityDetailPage detailPage)
        {
            InitializeComponent();

            this.activityDetailPage = detailPage;
            _activityDal = new EfActivityDal();
            _studentDal = new EfStudentDal();
            _teacherDal = new EfTeacherDal();
            _activityStudentDal = new EfActivityStudentDal();
            _activityTeacherDal = new EfActivityTeacherDal();
        }

        private void OneActivityDetail_Load(object sender, EventArgs e)
        {
            activityId = activityDetailPage.passingId;
            updateStudentCombobox();
            updateTeacherCombobox();
            PopulateStudentTable();
            PopulateTeacherTable();

        }

        private void addStudentbtn_Click(object sender, EventArgs e)
        {
            var studentInActivity = new Entities.ActivityStudent()
            {
                ActivityId = activityId,
                StudentId = getStudentId(addstudentcmb.Text)
            };

            _activityStudentDal.Add(studentInActivity);
            PopulateStudentTable();
        }




        private int getTeacherId(string teacherName)
        {
            var thisTeacher = _teacherDal.Get(t => t.Name + " " + t.LastName == teacherName);
            var teacherId = thisTeacher.Id;
            return teacherId;
        }

        private int getStudentId(string studentName)
        {
            var thisStudent = _studentDal.Get(s => s.Name + " " + s.LastName == studentName);
            var studentId = thisStudent.Id;
            return studentId;
        }

        private void updateStudentCombobox()
        {
            addstudentcmb.Items.Clear();

            var students = _studentDal.GetAll();

            foreach (var student in students)
            {
                var totalName = student.Name + " " + student.LastName;
                addstudentcmb.Items.Add(totalName);
            }
        }


        private void updateTeacherCombobox()
        {
            addTeachercmb.Items.Clear();

            var teachers = _teacherDal.GetAll();

            foreach (var teacher in teachers)
            {
                var totalName = teacher.Name + " " + teacher.LastName;
                addTeachercmb.Items.Add(totalName);
            }
        }

        private void addTeacherbtn_Click(object sender, EventArgs e)
        {
            var teacherInActivity = new Entities.ActivityTeacher()
            {
                ActivityId = activityId,
                TeacherId= getTeacherId(addTeachercmb.Text)
            };

            _activityTeacherDal.Add(teacherInActivity);
            PopulateTeacherTable();
        }

        private void PopulateStudentTable()
        {
            var activityStudents= _activityStudentDal.GetAll(x => x.ActivityId == activityId);

            var students = new List<Student>();
            foreach (var acstu in activityStudents)
            {
                var student = _studentDal.Get(s => s.Id == acstu.StudentId);
                students.Add(student);
            }

            studentListdgv.DataSource = students;
        }

        private void PopulateTeacherTable()
        {
            var activityTeachers = _activityTeacherDal.GetAll(x => x.ActivityId == activityId);

            var teachers = new List<Teacher>();
            foreach (var actch in activityTeachers)
            {
                var teacher = _teacherDal.Get(s => s.Id == actch.TeacherId);
                teachers.Add(teacher);
            }

           teacherListdgv.DataSource = teachers;
        }

        private void deleteLehrerbtn_Click(object sender, EventArgs e)
        {
            if (tempTeacherId > 0)
            {

                _activityTeacherDal.Delete(_activityTeacherDal.Get(a => a.TeacherId == tempTeacherId));

                PopulateTeacherTable();
            }
        }

        private void teacherListdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tempTeacherId = Int32.Parse(teacherListdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void studentListdgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tempStudentId = Int32.Parse(studentListdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void deleteStudentbtn_Click(object sender, EventArgs e)
        {
            if (tempStudentId > 0)
            {
                _activityStudentDal.Delete(_activityStudentDal.Get(a => a.StudentId == tempStudentId));

                PopulateStudentTable();
            }
        }
    }
}
