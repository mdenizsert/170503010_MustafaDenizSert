using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarten.Entities
{
    public class ActivityTeacher
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int TeacherId { get; set; }
    }
}
