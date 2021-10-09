using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class ShoppingRepository : IShoppingRepository
    {
        private readonly ShopContext _context;

        public ShoppingRepository(ShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Shopping> GetAll()
        {
            return _context.Shoppings;
        }

        public Shopping GetById(int id)
        {
            return _context.Shoppings.FirstOrDefault(x=>x.Id==id);
        }

        public Shopping Add(Shopping ob)
        {
            _context.Shoppings.Add(ob);
            _context.SaveChanges();
            return ob;
        }

        public void Update(Shopping ob)
        {
            _context.Shoppings.Update(ob);
            _context.SaveChanges();
        }

        public void Delete(Shopping ob)
        {
            _context.Shoppings.Remove(ob);
            _context.SaveChanges();
        }            
    }
}
