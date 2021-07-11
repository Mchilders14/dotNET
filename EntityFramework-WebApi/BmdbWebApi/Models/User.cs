using System;
using System.ComponentModel.DataAnnotations;

namespace BmdbWebApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(20), Required]
        public string Username { get; set; }

        [StringLength(20), Required]
        public string Password { get; set; }

        [StringLength(30), Required]
        public string FirstName { get; set; }

        [StringLength(30), Required]
        public string LastName { get; set; }

        [StringLength(50), Required]
        public string Email { get; set; }
    }
}
