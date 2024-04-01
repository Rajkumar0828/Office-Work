using LoginSignup.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginSignup.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserSignUpModel> Signup { get; set; }
    }

}
