using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreDB_Example.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [StringLength(80), Required]
        public string Description { get; set; }


        public int? CustomerId { get; set; }             // Must be foreign table + Id (CustomerId : Customer + Id)
        public virtual Customer Customer { get; set; }  // Must create virtual customer for CustomerId foreign key
    }
}
