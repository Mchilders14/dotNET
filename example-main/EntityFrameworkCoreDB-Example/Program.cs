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
            Console.WriteLine("Application Start ->");

            //TestCustomers();
            //TestOrders();
            //TestOrderLines();

            Console.WriteLine("<- Application End");
        }

        public static void TestCustomers()
        { 
            var customersController = new CustomersController();

            // Add Customer
            var newCustomer = new Customer()
            {
                Id = 0,
                Name = "Nike",
                Sales = 10000000,
                Active = true
            };
            //var rowChange = customersController.Add(newCustomer);

            //Update Customer
            var customer = customersController.GetById(2);
            customer.Sales = 999999;
            var rowChange = customersController.Update(customer);

            // Get Customer by ID
            customer = customersController.GetById(2);
            Console.WriteLine($"{customer.Id} | {customer.Name} | {customer.Sales}");

            // Delete Customer
            //var removeCustomer = customersController.Delete(customer.Id);
            //Console.WriteLine($"DELETED: {removeCustomer.Id} | {removeCustomer.Name} | {removeCustomer.Sales}");

            var customers = customersController.GetAll();

            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Id} | {c.Name} | {c.Sales}");
            }
        }

        public static void TestOrders()
        {
            var ordersController = new OrdersController();

            // Add Order
            var newOrder = new Order()
            {
                Id = 0,
                Date = new DateTime(2012,12,12),
                Description = "A New Description 2",
                CustomerId = 2
            };
            //var rowChange = ordersController.Add(newOrder);

            //Update Order
            var order = ordersController.GetById(3);
            order.Description = "An Updated Description";
            var rowChange = ordersController.Update(order);

            // Get Order by ID
            order = ordersController.GetById(3);
            Console.WriteLine($"{order.Id} | {order.Date} | {order.Description} | {order.CustomerId}");

            // Delete Order
            //var removeOrder = ordersController.Delete(order.Id);
            //Console.WriteLine($"DELETED: {order.Id} | {order.Date} | {order.Description} | {order.CustomerId}");

            var orders = ordersController.GetAll();

            foreach (var o in orders)
            {
                Console.WriteLine($"{o.Id} | {o.Date} | {o.Description} | {o.CustomerId}");
            }
        }

        public static void TestOrderLines()
        {
            var orderLinesController = new OrderLinesController();

            // Add OrderLine
            var newOrderLine = new OrderLine()
            {
                Id = 0,
                Product = "Corn",
                Quantity = 100,
                Description = "Stalk of Corn",
                Price = 100.00m,
                OrderId = 1
            };
            //var rowChange = orderLinesController.Add(newOrderLine);

            //Update OrderLine
            var orderLine = orderLinesController.GetById(4);
            orderLine.Price = 123.99m;
            var rowChange = orderLinesController.Update(orderLine);

            // Get OrderLine by ID
            orderLine = orderLinesController.GetById(4);
            Console.WriteLine($"{orderLine.Id} | {orderLine.Product} | {orderLine.Quantity} | {orderLine.Description} | {orderLine.Price} | {orderLine.OrderId}");

            // Delete OrderLine
            //var removeOrderLine = orderLinesController.Delete(orderLine.Id);
            //Console.WriteLine($"DELETED: {removeOrderLine.Id} | {removeOrderLine.Product} | {removeOrderLine.Quantity} | {removeOrderLine.Description} | {removeOrderLine.Price} | {removeOrderLine.OrderId}");

            var orderLines = orderLinesController.GetAll();

            foreach (var ol in orderLines)
            {
                Console.WriteLine($"{ol.Id} | {ol.Product} | {ol.Quantity} | {ol.Description} | {ol.Price} | {ol.OrderId}");
            }
        }
    }
}