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

        // I choosed to see this as it has one job, create tables.
        // I did not see that it was worth the time to create different contexts.

        public DbSet<WatchEntity> Watches { get; set; }
        public DbSet<ShoeEntity> Shoes { get; set; }
    }
}
