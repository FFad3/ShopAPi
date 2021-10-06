using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ShopContext _context;
        public ProductsRepository(ShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
        public Product GetById(int id)
        {
            return _context.Products.SingleOrDefault(x => x.Id == id);
        }
        public Product GetByName(string name)
        {
            return _context.Products.FirstOrDefault(x => x.Name == name);
        }
        public Product Add(Product ob)
        {
            _context.Products.Add(ob);
            _context.SaveChanges();
            return ob;
        }
        public void Update(Product ob)
        {
            _context.Products.Update(ob);
            _context.SaveChanges();
        }
        public void Delete(Product ob)
        {
            _context.Products.Remove(ob);
            _context.SaveChanges();
        }       
    }
}
