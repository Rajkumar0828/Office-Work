using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using LoginDemo1.Model;

namespace LoginDemo1.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
