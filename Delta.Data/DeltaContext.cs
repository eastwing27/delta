using Delta.Shared.Models;
using System.Data.Entity;

namespace Delta.Data
{
    internal class DeltaContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
    }
}
