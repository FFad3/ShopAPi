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

        public ProductDto AddNewProduct(CreateProductDto newProdcut)
        {
            var product = _mapper.Map<Product>(newProdcut);
            _productsRepository.Add(product);
            return _mapper.Map<ProductDto>(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _productsRepository.GetById(id);
            _productsRepository.Delete(product);
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _productsRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public ProductDto GetProductById(int id)
        {
            var product = _productsRepository.GetById(id);
            return _mapper.Map<ProductDto>(product);
        }

        public void UpdateProduct(UpdateProductDto updateProduct)
        {
            var existingProduct = _productsRepository.GetById(updateProduct.Id);
            var product = _mapper.Map(updateProduct, existingProduct);
            _productsRepository.Update(product);
        }
        public int ClearProducts()
        {
            return _productsRepository.ClearTable();
        }
    }
}
