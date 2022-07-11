using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinderGarten.Entities;
using Microsoft.EntityFrameworkCore;

namespace KinderGarten.DataAccess
{
    public class KinderGartenContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KinderGarten;Trusted_Connection=true");

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityTeacher> ActivitiesTeachers { get; set; }
        public DbSet<ActivityStudent> ActivitiesStudents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
