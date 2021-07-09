using System;
using EntityFrameworkCoreDB_Example.Controllers;
using EntityFrameworkCoreDB_Example.Models;
/*
 
    For MAC and Linux: Must execute BELOW to install EntityFramework terminal tools(IF NOT ALREADY INSTALLED in Terminal):

    [dotnet tool install--global dotnet - ef] OR [dotnet tool install --global dotnet-ef --version<version number>]

    USING MIGRATIONS TO CREATE DATABASE USING [DbContextOptionsBuilder]  

    *[Terminal], change directory to EntityFrameworkCoreDB-Example then run <dotnet ef migrations add initial>   <- Adds INITIAL migration
    *[Terminal], change directory to EntityFrameworkCoreDB-Example then run <dotnet ef migrations add "migration name">   <- Add subsequent migration(s)
    *[Terminal], change directory to EntityFrameworkCoreDB-Example then run <dotnet ef migrations remove (-f)>    <- Removes migration (-f <force>)
    *[Terminal], change directory to EntityFrameworkCoreDB-Example then run <dotnet ef database update>    <- Create/Push database

*/
namespace EntityFrameworkCoreDB_Example
{
    class Program 
    {
        static void Main(string[] args)
        {
            var customerController = new CustomersController();
            var customers = customerController.GetAll();

            var newCust = new Customer()
            {
                Id = 0,
                Name = "Kroger",
                Sales = 100000,
                Active = true
            };
            var rc = customerController.Add(newCust);

        }
    }
}
