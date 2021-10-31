using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly IShoppingRepository _shoppingRepository;
        private readonly IMapper _mapper;

        public ShoppingService(IShoppingRepository shoppingRepository, IMapper mapper)
        {
            _shoppingRepository = shoppingRepository;
            _mapper = mapper;
        }

        public IEnumerable<ShoppingDto> GetAllShoppings()
        {
            var shoppings = _shoppingRepository.GetAll();
            return _mapper.Map<IEnumerable<ShoppingDto>>(shoppings);
        }

        public ShoppingFullInfoDto GetShoppingById(int id)
        {
            var shopping = _shoppingRepository.GetById(id);
            if(shopping==null)
                throw new ArgumentOutOfRangeException("No shopping with current id");

            return _mapper.Map<ShoppingFullInfoDto>(shopping);
        }

        public ShoppingFullInfoDto AddShopping(CreateShoppingDto newShopping)
        {
            var shopping = _mapper.Map<Shopping>(newShopping); //mapowanie

            if (shopping.Products.Count==0)
                throw new ArgumentOutOfRangeException("Cant be empty");

            shopping.LastModified = DateTime.UtcNow;
            _shoppingRepository.Add(shopping);
            return _mapper.Map<ShoppingFullInfoDto>(shopping);
        }

        public void UpdateShopping(Shopping shopping)
        {
            throw new NotImplementedException("No implemented functionality");
        }

        public void DeleteShopping(int id)
        {
            var shopping = _shoppingRepository.GetById(id);
            _shoppingRepository.Delete(shopping);
        }       
    }
}
