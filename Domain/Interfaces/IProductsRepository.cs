using Domain.Common;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductsRepository:IUniversalInterface<Product>
    {
        //implementation of specific methods for defined type
        Product GetByName(string name);
    }
}
