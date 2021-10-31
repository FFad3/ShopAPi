using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

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

            if (product is null)
                throw new ArgumentOutOfRangeException("No product with current id");

            return _mapper.Map<ProductFullInfoDto>(product);
        }
        public ProductFullInfoDto GetPoductByName(string name)
        {
            var product = _productsRepository.GetByName(name);

            if (product == null)
                throw new ArgumentOutOfRangeException("No product with current name");

            return _mapper.Map<ProductFullInfoDto>(product);
        }        
        public ProductFullInfoDto AddNewProduct(CreateProductDto newProdcut)
        {
            var product = _mapper.Map<Product>(newProdcut);

            if (product.Name==null || product.Price< 0 ||product.Count < 0)
                throw new ArgumentOutOfRangeException("All field need to be correct");

            product.LastModified = DateTime.UtcNow;
            _productsRepository.Add(product);
            return _mapper.Map<ProductFullInfoDto>(product);
        }
        public void UpdateProduct(UpdateProductDto updateProduct)
        {
            var existingProduct = _productsRepository.GetById(updateProduct.Id);
            var product = _mapper.Map(updateProduct, existingProduct);

            if (product.Name == null || product.Price < 0 || product.Count < 0)
                throw new ArgumentOutOfRangeException("All field need to be correct");

            _productsRepository.Update(product);
        }
        public void DeleteProduct(int id)
        {
            var product = _productsRepository.GetById(id);
            if (product is null)
                throw new ArgumentOutOfRangeException("No product with current id");

            _productsRepository.Delete(product);
        }
    }
}
