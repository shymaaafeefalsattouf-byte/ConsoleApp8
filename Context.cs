using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp8.Entities
{
    internal class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<Section> Sections {  get; set; }
        public DbSet<ImportanceLevel> ImportanceLevels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=UsersDb1;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
