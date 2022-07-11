using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarten.Entities
{
    public class ActivityStudent
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int StudentId { get; set; }
    }
}
