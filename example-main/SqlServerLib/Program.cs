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
            var vendor = ssl.VendorGetByPK(1);


            ssl.Disconnect();
            Console.Write("Connection Successful!");
        }
    }
}
