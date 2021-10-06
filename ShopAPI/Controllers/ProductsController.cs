using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        
        [SwaggerOperation(Summary ="Get all products")]
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [SwaggerOperation(Summary = "Get product by id")]
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [SwaggerOperation(Summary = "Get product by name")]
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            var product = _productService.GetPoductByName(name);
            if (product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }       

        [SwaggerOperation(Summary = "Create product")]
        [HttpPost]
        public IActionResult Create(CreateProductDto newProduct)
        {
            var product = _productService.AddNewProduct(newProduct);
            return Created($"api/Product/{product.Id}", product);
        }

        [SwaggerOperation(Summary ="Update product")]
        [HttpPut]
        public IActionResult Update(UpdateProductDto updateProduct)
        {
            _productService.UpdateProduct(updateProduct);
            return NoContent();
        }

        [SwaggerOperation(Summary ="Delete product")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {            
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}
