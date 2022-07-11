using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarten.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AgeGroup { get; set; }
        public string Period { get; set; }
    }
}
