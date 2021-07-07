using System;
namespace SqlServerLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string VendorId { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Unit { get; set; } = "Each";
        public string PhotoPath { get; set; }
        public string VendorCode { get; set; }

    }
}
