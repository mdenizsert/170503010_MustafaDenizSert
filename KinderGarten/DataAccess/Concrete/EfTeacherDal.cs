using KinderGarten.DataAccess.Abstract;
using KinderGarten.DataAccess.EntityFramework;
using KinderGarten.Entities;

namespace KinderGarten.DataAccess.Concrete
{
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, KinderGartenContext>, ITeacherDal
    {
    }
}