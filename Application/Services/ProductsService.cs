using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductsService : IProductService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
        public ProductsService(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }           
        public IEnumerable<ProductFullInfoDto> GetAllProducts()
        {
            var products = _productsRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductFullInfoDto>>(products);
        }
        public ProductFullInfoDto GetProductById(int id)
        {
            var product = _productsRepository.GetById(id);
            return _mapper.Map<ProductFullInfoDto>(product);
        }
        public ProductFullInfoDto GetPoductByName(string name)
        {
            var product = _productsRepository.GetByName(name);
            return _mapper.Map<ProductFullInfoDto>(product);
        }        
        public ProductFullInfoDto AddNewProduct(CreateProductDto newProdcut)
        {
            var product = _mapper.Map<Product>(newProdcut);
            product.LastModified = DateTime.UtcNow;
            _productsRepository.Add(product);
            return _mapper.Map<ProductFullInfoDto>(product);
        }
        public void UpdateProduct(UpdateProductDto updateProduct)
        {
            var existingProduct = _productsRepository.GetById(updateProduct.Id);
            var product = _mapper.Map(updateProduct, existingProduct);
            _productsRepository.Update(product);
        }
        public void DeleteProduct(int id)
        {
            var product = _productsRepository.GetById(id);
            _productsRepository.Delete(product);
        }
    }
}
