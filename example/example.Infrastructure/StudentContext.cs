using example.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace example.Infrastructure
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDB;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>();
            builder.Entity<Subject>();
            builder.Entity<Teacher>();
        }
    }
}
