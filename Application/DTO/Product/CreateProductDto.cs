﻿using Application.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO
{
    public class CreateProductDto:IMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductDto, Product>();
        }
    }
}
