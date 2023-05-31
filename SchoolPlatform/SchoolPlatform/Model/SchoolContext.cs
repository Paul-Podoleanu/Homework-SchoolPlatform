using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Model
{
    public class SchoolContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=MVPdatabase;Integrated Security=SSPI;TrustServerCertificate=True");
        }
    }
}
