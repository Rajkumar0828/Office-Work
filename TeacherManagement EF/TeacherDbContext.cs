using System.Formats.Tar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TeacherManagementSystem;
namespace TeacherManagement.data
{

    public class TeacherDbContext : DbContext
    {
        string constr = Program.GetDbConnection();
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(constr,new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }

}