using Microsoft.EntityFrameworkCore;

namespace az_web_app_learn.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }

        public DbSet<Person> Persons { get; set; }
    }
}
