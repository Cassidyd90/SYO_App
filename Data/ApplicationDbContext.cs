using Microsoft.EntityFrameworkCore;
using SYO_App.Models;

namespace SYO_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Question> QuestionsAll { get; set; }

        public DbSet<User> Users { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
