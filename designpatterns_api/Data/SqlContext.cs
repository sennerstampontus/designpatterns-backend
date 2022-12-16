using designpatterns_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace designpatterns_api.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        // Jag valde att se detta som att SqlContext gör en sak, Enligt SRP, skapar tabeller.
        // Ansåg att det inte är värt mödan att göra flera Contexts. 

        public DbSet<WatchEntity> Watches { get; set; }
        public DbSet<ShoeEntity> Shoes { get; set; }
    }
}
