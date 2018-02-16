﻿using Flarine.Database.Entity;
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
            modelBuilder.Entity<Hero>()
                .HasOne(h => h.ParentAccount)
                .WithMany(a => a.AccountHeros);
        }

        protected DatabaseConfiguration Configuration { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Hero> Heros { get; set; }
    }
}