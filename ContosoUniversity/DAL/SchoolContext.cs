using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        //You can omit the DbSet<Enrollment> and DbSet<Course> statements
        //and it would work the same. Entity Framework would include them
        //implicitly because the Student entity references the Enrollment
        //entity and the Enrollment entity references the Course entity.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //prevents table names from being pluralized.
        }
    }
}