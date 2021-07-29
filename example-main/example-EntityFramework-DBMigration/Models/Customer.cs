using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreDB_Example.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(30), Required]    // Setting Database field info for generation
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;

    }
}
