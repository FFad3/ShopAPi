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


        public IEnumerable<Shopping> GetAllShoppings()
        {
            return _shoppingRepository.GetAll();
        }

        public Shopping GetShoppingById(int id)
        {
            return _shoppingRepository.GetById(id);
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
