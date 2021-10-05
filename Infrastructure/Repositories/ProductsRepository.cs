using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
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
            return ob;
        }

        public void Delete(Product ob)
        {
            _context.Products.Remove(ob);
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
            throw new NotImplementedException();
        }
    }
}
