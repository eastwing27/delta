using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delta.Data.Models
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public int? OrganisationId { get; set; }

        [ForeignKey("OrganisationId")]
        public virtual Organisation Organisation { get; set; }
    }
}
