using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly ShopContext _context;
        public CustomersRepository(ShopContext context)
        {
            _context = context;
        }
        public Customer Add(Customer ob)
        {
            _context.Add(ob);
            return ob;
        }

        public void Delete(Customer ob)
        {
            _context.Customers.Remove(ob);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public Customer GetById(int id)
        {
            return _context.Customers.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Customer ob)
        {
            ob.LastModified = DateTime.UtcNow;
        }
    }
}
