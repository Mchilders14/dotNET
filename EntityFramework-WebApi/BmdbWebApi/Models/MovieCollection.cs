using System;
namespace BmdbWebApi.Models
{
    public class MovieCollection
    {
        public int Id { get; set; }
        public decimal PurchasePrice { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
