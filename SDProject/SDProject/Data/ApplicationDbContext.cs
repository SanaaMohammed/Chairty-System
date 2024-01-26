using Microsoft.EntityFrameworkCore;
using SDProject.Models;
namespace SDProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<CaseInspector> Inspectors { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
