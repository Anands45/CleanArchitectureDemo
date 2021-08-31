using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CleanArch.Data
{
    public class SQLDBContext : DbContext
    {

        public DbSet<Course> Course { get; set; }

        public SQLDBContext(DbContextOptions<SQLDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
