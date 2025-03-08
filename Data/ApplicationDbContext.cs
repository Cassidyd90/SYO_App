using Microsoft.EntityFrameworkCore;
using SYO_App.Models;

namespace SYO_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        // DbSets represent tables in your database
        public DbSet<Question> Questions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
