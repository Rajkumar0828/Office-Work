using System.Formats.Tar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VehicleManagement.data;
using VehicleManagementSystem;
namespace VehicleManagement.data
{

    public class VehicleDbContext : DbContext
    {
        string constr = Program.GetDbConnection();
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(constr,new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }

}