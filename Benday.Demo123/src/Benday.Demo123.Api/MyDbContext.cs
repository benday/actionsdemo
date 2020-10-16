using Microsoft.EntityFrameworkCore;

namespace Benday.Demo123.Api
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

    }
}
