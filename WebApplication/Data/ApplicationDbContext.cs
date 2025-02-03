using WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Producer> Producer { get; set; }

    }
}
