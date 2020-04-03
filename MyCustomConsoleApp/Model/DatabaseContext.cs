using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MyCustomConsoleApp.Model
{
    public class DatabaseContext: DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-GGPJPJP;Database=TestDb;Trusted_Connection=True";
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Staff> Staffs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
