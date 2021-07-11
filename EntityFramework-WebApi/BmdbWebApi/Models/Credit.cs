using System;
using System.ComponentModel.DataAnnotations;

namespace BmdbWebApi.Models
{
    public class Credit
    {
        public int Id { get; set; }

        [StringLength(50), Required]
        public string Role { get; set; }

        // ActorId foreign key
        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }

        // MovieId foreign key
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
