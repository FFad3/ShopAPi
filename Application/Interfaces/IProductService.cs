using Application.DTO;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductFullInfoDto> GetAllProducts();
        ProductFullInfoDto GetProductById(int id);
        ProductFullInfoDto GetPoductByName(string name);
        ProductFullInfoDto AddNewProduct(CreateProductDto newProduct);       
        void UpdateProduct(UpdateProductDto updateProduct);
        void DeleteProduct(int id);
        
    }
}
