using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarten.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Medicine { get; set; }
        public int ClassId { get; set; }
        public string Email { get; set; }
    }
}
