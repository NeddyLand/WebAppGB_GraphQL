﻿using Microsoft.AspNetCore.Mvc;
using WebAppGB_GraphQL.Abstractions;
using WebAppGB_GraphQL.Data;
using WebAppGB_GraphQL.Dto;
using WebAppGB_GraphQL.Models;

namespace WebAppGB_GraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpPost]
        public ActionResult<int> AddProduct(ProductDto productDto)
        {
            try
            {
                int id = _productRepository.AddProduct(productDto);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(409);
            }
        }

        [HttpGet]
        public ActionResult GetProducts()
        {
            var list = _productRepository.GetProducts();
            return Ok(list);
        }

        [HttpDelete]
        public ActionResult DeleteProduct(int id)
        {
            using (Context context = new Context())
            {
                Product product = context.Products.Find(id);
                if (product == null)
                {
                    return NotFound();
                }
                context.Products.Remove(product);
                context.SaveChanges();
                return Ok($"Товар {product.ProductName} удален");
            }
        }
    }
}
