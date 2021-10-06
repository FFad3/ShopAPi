using Application.DTO;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IProductService
    {
        ProductDto AddNewProduct(CreateProductDto newProduct);
        IEnumerable<ProductDto> GetAllProducts();
        ProductDto GetProductById(int id);
        void UpdateProduct(UpdateProductDto updateProduct);
        void DeleteProduct(int id);
        int ClearProducts();
    }
}
