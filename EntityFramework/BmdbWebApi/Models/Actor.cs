using System;
using System.ComponentModel.DataAnnotations;

namespace BmdbWebApi.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [StringLength(30), Required]
        public string FirstName { get; set; }

        [StringLength(30), Required]
        public string LastName { get; set; }

        [StringLength(1), Required]
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }

}
