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
        public Product Add(Product ob)
        {
            _context.Products.Add(ob);
            _context.SaveChanges();
            return ob;
        }

        public int ClearTable()
        {
            int counter = 0;
            var productstable = _context.Products;
            foreach (var product in productstable)
            {
                _context.Products.Remove(product);
                counter++;
            }
            return counter;
        }

        public void Delete(Product ob)
        {
            _context.Products.Remove(ob);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(int id)
        {
            return _context.Products.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Product ob)
        {
            _context.Products.Update(ob);
            _context.SaveChanges();
        }
    }
}
