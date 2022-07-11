using KinderGarten.DataAccess.Abstract;
using KinderGarten.DataAccess.EntityFramework;
using KinderGarten.Entities;

namespace KinderGarten.DataAccess.Concrete
{
    public class EfClassDal : EfEntityRepositoryBase<Class, KinderGartenContext>, IClassDal
    {
    }
}