using Flarine.Database.Entity;
using Microsoft.EntityFrameworkCore;

namespace Flarine.Database
{
    public abstract class DatabaseContext : DbContext
    {
        protected DatabaseContext()
        {
        }

        protected DatabaseConfiguration Configuration { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}