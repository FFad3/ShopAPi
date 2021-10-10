using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class ShoppingFullInfoDto : IMap
    {
        public int Id { get; set; }
        public List<ProductDto> Products { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Shopping, ShoppingFullInfoDto>();
        }
    }
}
