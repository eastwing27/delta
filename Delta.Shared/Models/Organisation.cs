using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Delta.Shared.Models
{
    public class Organisation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}