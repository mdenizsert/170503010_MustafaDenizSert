using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinderGarten.DataAccess.EntityFramework;
using KinderGarten.Entities;

namespace KinderGarten.DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
    }
}
