using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadImage;
using UploadImage.Business.Abstract;
using UploadImage.Entities;

namespace WebApiFileUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("add")]
        public void Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] Product product)
        {
            _productService.Add(file, product);
        }

        [HttpGet("getall")]
        [Authorize(Roles ="Product.List")]
        public List<Product>GetAll()
        {
            return _productService.GetAll();

        }

        [HttpPost("delete")]
        public void Delete(int id)
        {
             _productService.Delete(id);
        }

        [HttpPost("update")]
        public void Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm]  Product product)
        {
          /*  var updatedProduct = _productService.Get(product.id);
            _productService.Update(file, updatedProduct);*/ 

            var productImage = _productService.Get(product.ProductId);
            _productService.Update(file, product);
        }

        [HttpGet("getByid")]
        public List<Product> GetByid(int id)
        {
            return _productService.GetAllById(id);
        }

    }
}
