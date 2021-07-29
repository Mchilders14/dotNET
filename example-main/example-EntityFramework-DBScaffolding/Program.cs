using System;
using System.Linq;
using EntityFramework_Example.Model;
/*
    For MAC and Linux: Must execute BELOW to install EntityFramework terminal tools(IF NOT ALREADY INSTALLED in Terminal):

    [dotnet tool install --global dotnet-ef] OR [dotnet tool install --global dotnet-ef --version <version number>]

    LOGIN COMMAND: [dotnet ef dbcontext Scaffold "Server=localhost;Initial Catalog=salesdb;Persist Security Info=False;User ID=<username>;Password=<password>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -o Model]
    
 */
namespace EntityFramework_Example   // Installed EntityFramework.SqlServer && EntityFramework.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new salesdbContext();
            var custOrders = from o in _context.Orders
                             join c in _context.Customers
                             on o.CustomerId equals c.Id
                             select new
                             {
                                 o,
                                 c.Name
                             };
            //foreach (var oc in custOrders)
            //{
            //    Console.WriteLine($"{oc.o.Description} | {oc.Name}");
            //}
            var customers = _context.Customers
                                    .Where(c => c.City == "Cincinnati" && c.Sales >= 50000)
                                    .OrderByDescending(c => c.Name)
                                    .ToList();
            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Name}|{c.City}|{c.State}|{c.Sales}");
            }
        }
    }
}