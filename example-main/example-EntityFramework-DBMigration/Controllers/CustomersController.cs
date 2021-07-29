using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreDB_Example.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreDB_Example.Controllers
{
    public class CustomersController
    {
        readonly AppDbContext _context; // readonly allows for non-implemented method.

        public CustomersController()
        {
            _context = new AppDbContext();  // Creating NEW Database Instance
        }

        public List<Customer> GetAll()  // Reads ALL Customer(s) from Customer Table
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int Id) // Reads Customer(s) from Customer Table by ID
        {
            return _context.Customers.Find(Id);

        }

        public Customer Add(Customer customer)  // Add to Customer Table
        {
            if (customer == null)
            {
                return null;
            }
            _context.Customers.Add(customer);
            var rowsAffected = _context.SaveChanges();

            if (rowsAffected != 1)
            {
                return null;
            }
            return customer;
        }

        public bool Update(Customer customer)   // Update to Customer Table
        {
            if (customer == null)
            {
                return false;
            }
            _context.Entry(customer).State = EntityState.Modified;
            var rc = _context.SaveChanges();
            if (rc != 1)
            {
                return false;
            }
            return true;
        }

        public Customer Delete(int Id)  // Delete to Customer Table
        {
            var cust = _context.Customers.Find(Id);
            if (cust == null)
            {
                return null;
            }
            _context.Remove(cust);
            var rc = _context.SaveChanges();
            if (rc != 1)
            {
                return null;
            }
            return cust;
        }
    }
}
