using Delta.Data.Models;
using System.Data.Entity;

namespace Delta.Data
{
    public class DeltaContext : DbSet
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
    }
}
