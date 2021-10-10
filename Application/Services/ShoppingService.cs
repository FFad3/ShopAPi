using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _mapper.Map<ShoppingFullInfoDto>(shopping);
        }

        public Shopping AddShopping(Shopping newShopping)
        {
            _shoppingRepository.Add(newShopping);
            return newShopping;
        }

        public void UpdateShopping(Shopping shopping)
        {
            throw new NotImplementedException();
        }
        public void DeleteShopping(int id)
        {
            throw new NotImplementedException();
        }
    }
}
