using Microsoft.EntityFrameworkCore;

namespace PersonAPITest.Model.Context
{
    public class PgContext : DbContext
    {
        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          //  => optionsBuilder.UseNpgsql("Server = localhost;Database=aspnet_api;User Id = developer; Password=root;");

        public DbSet<Person> Person { get; set; }

    }
}
