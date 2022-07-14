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
    public partial class OneClassDetailPage : Form
    {
        private ClassDetailPage classDetailPage;
        private int classId;
        private EfClassDal _classDal;
        private EfTeacherDal _teacherDal;
        private EfStudentDal _studentDal;
        public OneClassDetailPage(ClassDetailPage detailPage)
        {
            InitializeComponent();

            this.classDetailPage = detailPage;
            _classDal = new EfClassDal();
            _teacherDal = new EfTeacherDal();
            _studentDal = new EfStudentDal();
        }

        private void OneClassDetailPage_Load(object sender, EventArgs e)
        {
            classId = classDetailPage.passingId;

            var thisClass = _classDal.Get(c => c.Id == classId);
            classNamelbl.Text = thisClass.Name;

            int teacherId = thisClass.TeacherId;
            var thisTeacher = _teacherDal.Get(t => t.Id == teacherId);
            teacherNamelbl.Text = thisTeacher.Name + " " + thisTeacher.LastName;
            PopulateTable();

        }

        private void PopulateTable()
        {
            var students = _studentDal.GetAll(s => s.ClassId == classId);

            studentListdgv.DataSource = students;
        }
    }
}
