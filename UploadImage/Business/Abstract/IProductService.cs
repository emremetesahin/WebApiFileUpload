using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Entities;

namespace UploadImage.Business.Abstract
{
    public interface IProductService
    {
        public void Add(IFormFile file, Product product);
        public void Delete(int id);
        public void Update(IFormFile file, Product product);
        public List<Product> GetAll();
        public List<Product> GetAllById(int id);
        public Product Get(int id);
    }
}
