using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreDB_Example.Models
{
    public class OrderLine
    {
        public int  Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }

        [StringLength(80), Required]
        public string Description { get; set; }

        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }

        public int? OrderId { get; set; }   // int(?) <- '?' allows for int to be nullable
        public virtual Order Orders { get; set; }   // Allows for foreign key OrderId
    }
}
