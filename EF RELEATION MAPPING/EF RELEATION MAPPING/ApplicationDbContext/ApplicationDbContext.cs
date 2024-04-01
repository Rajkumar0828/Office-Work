
using EFRELEATIONMAPPING;

using Microsoft.EntityFrameworkCore;

namespace EFRELEATIONMAPPING
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Department> Departements { get; set; }
        public DbSet<Employee> Employess { get; set; }

        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }



    } 
}
    

