using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delta.Shared.Models
{
    public class Character
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        public int? OrganisationId { get; set; }

        [ForeignKey("OrganisationId")]
        public virtual Organisation Organisation { get; set; }
    }
}
