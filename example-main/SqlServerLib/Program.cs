using System;
using SqlServerLibrary;

namespace SqlServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerLib ssl = new SqlServerLib();
            ssl.Connect("localhost", "PRS");

            //var users = ssl.UserGetAll();
            var user = ssl.UserGetByPK(1);

            //var vendors = ssl.VendorGetAll();
            //var vendor = ssl.VendorGetByPK(1);

            //var newUser = new User()
            //{
            //    Id = 0, Username = "gdoud", Password = "greg123", FirstName = "Greg",
            //    LastName = "Doud", Phone = "513-667-0998", Email = "gdoud@gmail.com",
            //    Reviewer = false, Admin = false
            //};
            //ssl.UserCreate(newUser);

            //var user = ssl.UserGetByPK(14);
            //user.Phone = "513-444-4444";
            //var returnCode = ssl.UserChange(user);
            //Console.WriteLine($"The change {(returnCode ? "Worked!": "Failed!" )}");

            //var vendor = ssl.VendorGetByPK(1);
            //vendor.State = "KY";
            //var returnCode = ssl.VendorChange(vendor);
            //Console.WriteLine($"The change {(returnCode ? "Worked!" : "Failed!")}");

            //var newVendor = new Vendor()
            //{
            //    Id = 0,
            //    Code = "GA-1001",
            //    Name = "Great American Insurance",
            //    Address = "49 E 4th Street",
            //    City = "Cincinnati",
            //    State = "OH",
            //    Zip = "45202",
            //    Phone = "513-667-0998",
            //    Email = "admin@gaic.com"
            //};
            //ssl.VendorCreate(newVendor);

            ssl.Disconnect();
            Console.Write("Connection Successful!");
        }
    }
}
