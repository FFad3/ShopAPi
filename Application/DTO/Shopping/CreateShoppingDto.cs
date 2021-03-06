using Application.Mappings;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class CreateShoppingDto : IMap
    {
        [Required]
        public List<CreateProductDto> Products { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateShoppingDto, Shopping>();
        }
    }
}
