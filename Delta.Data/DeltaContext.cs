using Delta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Delta.Data
{
    internal class DeltaContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Organisation> Organisations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=deltadb;Trusted_Connection=True;");
        }
    }
}
