using Application.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO
{
    public class CreateProductDto:IMap
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductDto, Product>();
        }
    }
}
