using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreDB_Example.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDB_Example.Controllers
{
    public class OrdersController
    {
        readonly AppDbContext _context; // readonly allows for non-implemented method.

        public OrdersController()
        {
            _context = new AppDbContext();  // Creating NEW Database Instance
        }

        public List<Order> GetAll() // Reads all ORDERS
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int Id) // Reads ORDER by ID
        {
            return _context.Orders.Find(Id);
        }

        public Order Add(Order order)  // Add(s) to Order Table
        {
            if (order == null)  // If nothing is passed in parameter, return null to ADD method
            {
                return null;
            }

            _context.Orders.Add(order);
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected != 1)  // If changes don't save, return null to ADD method
            {
                return null;
            }
            return order;
        }

        public bool Update(Order order) // Update(s) to Order Table
        {
            if (order == null)  // If nothing is passed in parameter, return false to UPDATE method
            {
                return false;
            }

            _context.Entry(order).State = EntityState.Modified;
            var rowChanged = _context.SaveChanges();

            if (rowChanged != 1)    // If rows changed is not 1, return false to UPDATE method
            {
                return false;
            }

            return true;
        }

        public Order Delete(int Id) // Delete(s) to Order Table
        {
            var findOrder = _context.Orders.Find(Id); // Finding Order for Deletion

            if (findOrder == null)  // If nothing is passed in parameter, return false to DELETE method
            {
                return null;
            }

            _context.Orders.Remove(findOrder);
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected != 1)
            {
                return null;    // If changes don't save, return null to DELETE method
            }

            return findOrder;
        }

    }
}
