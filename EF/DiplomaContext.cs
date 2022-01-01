using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diploma.Models;
using Microsoft.EntityFrameworkCore;

namespace Diploma.EF
{
    class DiplomaContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Decease> Deceases { get; set; }

        public DiplomaContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=Password12;database=diploma;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            
        }
        
    }
}
