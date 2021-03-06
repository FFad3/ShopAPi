using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Application.DTO
{
    public class ShoppingDto : IMap
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Shopping, ShoppingDto>();
        }
    }
}
