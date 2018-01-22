using Flarine.Database.Entity;
using Microsoft.EntityFrameworkCore;

namespace Flarine.Database
{
    public abstract class DatabaseContext : DbContext
    {
        protected DatabaseContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(h => h.AccountHeros)
                .WithOne();
        }

        protected DatabaseConfiguration Configuration { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Hero> Heros { get; set; }
    }
}