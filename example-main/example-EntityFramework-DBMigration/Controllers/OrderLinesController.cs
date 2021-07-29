using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreDB_Example.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDB_Example.Controllers
{
    public class OrderLinesController
    {
        readonly AppDbContext _context; // readonly allows for non-implemented method.

        public OrderLinesController()
        {
            _context = new AppDbContext();  // Creating NEW Database Instance
        }

        public List<OrderLine> GetAll() // Reads all OrderLines
        {
            return _context.OrderLines.ToList();
        }

        public OrderLine GetById(int Id)  // Reads OrderLines by ID
        {
            return _context.OrderLines.Find(Id);
        }

        public OrderLine Add(OrderLine orderLine)   // Add(s) to Order Table
        {
            if (orderLine == null)
            {
                return null;
            }

            _context.OrderLines.Add(orderLine);
            var rowAffected = _context.SaveChanges();

            if (rowAffected != 1)
            {
                return null;
            }

            return orderLine;
        }

        public bool Update(OrderLine orderLine) // Update(s) to Order Table
        {
            if (orderLine == null)
            {
                return false;
            }

            _context.Entry(orderLine).State = EntityState.Modified;
            var rowChanged = _context.SaveChanges();

            if (rowChanged != 1)
            {
                return false;
            }
            return true;
        }

        public OrderLine Delete(int Id) // Delete(s) to Order Table
        {
            var findOrderLine = _context.OrderLines.Find(Id);

            if (findOrderLine == null)
            {
                return null;
            }

            _context.OrderLines.Remove(findOrderLine);
            var rowAffected = _context.SaveChanges();

            if (rowAffected != 1)
            {
                return null;
            }

            return findOrderLine;
        }
    }
}
