using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingService _shoppingService;

        public ShoppingController(IShoppingService shoppingService, IMapper mapper)
        {
            _shoppingService = shoppingService;
        }
        [SwaggerOperation(Summary ="Show all shoppings")]
        [HttpGet]
        public IActionResult GetShoppings()
        {
            var shoppings = _shoppingService.GetAllShoppings();
            return Ok(shoppings);
        }
        [SwaggerOperation(Summary ="Show shopping with selected id")]
        [HttpGet("{id}")]
        public IActionResult GetShoppingById(int id)
        {
            var shopping = _shoppingService.GetShoppingById(id);
            return Ok(shopping);
        }
        [SwaggerOperation(Summary ="Create new shopping")]
        [HttpPost]
        public IActionResult CreateShopping(Shopping newShopping)
        {
            var shopping = _shoppingService.AddShopping(newShopping);
            return Ok(shopping);
        }
    }
}
