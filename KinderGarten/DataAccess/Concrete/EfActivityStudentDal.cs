using System.Collections.Generic;
using System.Linq;
using KinderGarten.DataAccess.Abstract;
using KinderGarten.DataAccess.EntityFramework;
using KinderGarten.Entities;

namespace KinderGarten.DataAccess.Concrete
{
    public class EfActivityStudentDal : EfEntityRepositoryBase<ActivityStudent, KinderGartenContext>, IActivityStudentDal
    {
        public List<StudentInActivityDto> GetStudentsInActivity()
        {
            using (KinderGartenContext context = new KinderGartenContext())
            {
                var result = from stu in context.ActivitiesStudents
                    join s in context.Students
                        on stu.StudentId equals s.Id
                    select new StudentInActivityDto()
                    {
                        StudentName = s.Name,
                        StudentLastName = s.LastName,
                    };
                return result.ToList();
            }
        }
    }
}