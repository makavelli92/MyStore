using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.Models;
using MyStore.DAL.EF;

namespace MyStore.BL.Repository.Mocs
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductDto> products = new List<ProductDto>()
        {
            new ProductDto()
            {
                ProductId = 1,
                Name = "Nokia",
                Price = 1000,
                IsPremium = false
            },
            new ProductDto()
            {
                ProductId = 2,
                Name = "Xiomi",
                Price = 2000,
                IsPremium = false
            }
        };

        private List<ProductDto> premiumProducts = new List<ProductDto>()
        {
            new ProductDto()
            {
                ProductId = 3,
                Name = "Meizu",
                Price = 5000,
                IsPremium = true
            }
        };

        public IEnumerable<Product> GetProducts()
        {

            return products.Select(e => new Product(e, e.IsPremium)).ToList();
        }

        public IEnumerable<Product> GetProductsPremium()
        {
            return premiumProducts.Select(e => new Product(e, e.IsPremium)).ToList();
        }
    }
}