using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumperShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumperShop.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            // Ok => makes the serializer
            return Ok(_productRepository.GetAllWithUsers());
        }

        
    }
}
