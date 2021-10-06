using Domain.Common;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductsRepository:IUniversalInterface<Product>
    {
        Product GetByName(string name);
    }
}
