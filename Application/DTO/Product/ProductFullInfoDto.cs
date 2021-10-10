using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;

namespace Application.DTO
{
    public class ProductFullInfoDto : IMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductFullInfoDto>();
        }
    }
}
