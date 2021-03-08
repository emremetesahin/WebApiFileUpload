using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Business.Abstract;
using UploadImage.DataAccess;
using UploadImage.DataAccess.Abstract;
using UploadImage.Entities;

namespace UploadImage.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(IFormFile file, Product product)
        {
            product.FilePath = FileHelper.Add(file);
            product.Date = DateTime.Now;
            _productDal.Add(product);
        }

        public void Delete(int id)
        {
            var product = Get(id);
            FileHelper.Delete(product.FilePath);
            _productDal.Delete(product);

        }

        public List<Product> GetAll()
        {
            var result = _productDal.GetAll();
            if (result != null)
            {
                return result;
            }
            return new List<Product> { new Product { CategoryId = 1, Date = null, FilePath = null, ProductId = 1, id = 0, ProductName = "Elma Şekeri", QuanityPerUnit = "Kutuda 5 adet", UnitPrice = 0, UnitsInStock = 0 } };
        }
        public Product Get(int id)
        {
            return _productDal.Get(p => p.id == id);
        }
        public List<Product> GetAllById(int id)
        {
            return _productDal.GetAll(p => p.ProductId == id);
        }

        public void Update(IFormFile file, Product product)
        {
            product.FilePath = FileHelper.Update(_productDal.Get(p => p.id == product.id).FilePath, file);
            product.Date = DateTime.Now;
            _productDal.Update(product);
        }


    }
}
