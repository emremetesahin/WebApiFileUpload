using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Entities;

namespace UploadImage.Entities
{
    public class Product : IEntity
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuanityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? Date { get; set; }
        public string FilePath { get; set; }
    }
}
