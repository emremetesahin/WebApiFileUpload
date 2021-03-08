using System;
using System.IO;
using UploadImage.Business.Abstract;
using UploadImage.Business.Concrete;
using UploadImage.DataAccess;
using UploadImage.DataAccess.Concrete;
using UploadImage.Entities;

namespace UploadImage
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string filename = "default.jpg";
            string oldPath = Path.Combine(Environment.CurrentDirectory, "Images/");
            var fullName = Path.Combine(oldPath, filename);
            string tempName = Path.GetTempFileName();
            FileStream fileStream1 = new FileStream(tempName,FileMode.Create);
            FileStream fileStream2 = new FileStream(fullName,FileMode.Create);
            */



        }

        private static void DosyaKopyalama()
        {
            string filename = "default.jpg";
            string oldPath = Path.Combine(Environment.CurrentDirectory, "Images/");
            string newPath = Path.Combine(Environment.CurrentDirectory, "imaj/");
            if (!File.Exists(oldPath + filename))
            {
                Console.WriteLine("Dosya Mevcut değil");
            }
            else
            {
                Directory.CreateDirectory(newPath);
                File.Copy(Path.Combine(oldPath, filename), Path.Combine(newPath));
                Console.WriteLine("Kopyalama işlemi başarılı");
            }
        }

        private static void AddandGetAll()
        {
            IProductService productService = new ProductManager(new EfProductDal());
            Product product = new Product { ProductName = "Elma", UnitPrice = 500 };
            //productService.Add(product);
          /*  foreach (var item in productService.GetAll())
            {
                Console.WriteLine(item.ProductId + " " + item.ProductName + " " + item.UnitPrice + " " + item.Date);
            }*/
        }
    }
}
