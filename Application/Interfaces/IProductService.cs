using Application.DTO;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts();
        ProductDto GetProductById(int id);
        ProductDto GetPoductByName(string name);
        ProductDto AddNewProduct(CreateProductDto newProduct);       
        void UpdateProduct(UpdateProductDto updateProduct);
        void DeleteProduct(int id);
        
    }
}
