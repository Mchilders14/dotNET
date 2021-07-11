using System;
using System.ComponentModel.DataAnnotations;

namespace BmdbWebApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int Year { get; set; }

        [StringLength(30), Required]
        public string Title { get; set; }

        [StringLength(5), Required]
        public string Rating { get; set; }

        [StringLength(50), Required]
        public string Director { get; set; }
    }
}
