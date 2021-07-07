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

            // var users = ssl.UserGetAll();
            // var user = ssl.UserGetByPK(1);

            // var vendors = ssl.VendorGetAll();
            // var vendor = ssl.VendorGetByPK(1);

            var newUser = new User()
            {
                Id = 0, Username = "gdoud", Password = "greg123", FirstName = "Greg",
                LastName = "Doud", Phone = "513-667-0998", Email = "gdoud@gmail.com",
                Reviewer = false, Admin = false
            };

            ssl.UserCreate(newUser);



            ssl.Disconnect();
            Console.Write("Connection Successful!");
        }
    }
}
