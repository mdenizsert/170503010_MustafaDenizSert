using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinderGarten.DataAccess.Abstract;
using KinderGarten.DataAccess.EntityFramework;
using KinderGarten.Entities;

namespace KinderGarten.DataAccess.Concrete
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, KinderGartenContext>, IAdminDal
    {
    }
}
