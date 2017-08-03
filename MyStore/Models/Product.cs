using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.DAL.EF;

namespace MyStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsPremium { get; set; }

        public Product(ProductDto dto, bool isPremium)
        {
            ProductId = dto.ProductId;
            Name = dto.Name;
            Price = dto.Price;
            IsPremium = isPremium;
        }
    }
}