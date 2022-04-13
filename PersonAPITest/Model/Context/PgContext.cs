using Microsoft.EntityFrameworkCore;

namespace PersonAPITest.Model.Context
{
    public class PgContext : DbContext
    {
        public PgContext()
        {

        }

        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

    }
}
