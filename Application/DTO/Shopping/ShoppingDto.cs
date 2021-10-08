using Application.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO
{
    public class ShoppingDto : IMap
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Shopping, ShoppingDto>();
        }
    }
}
