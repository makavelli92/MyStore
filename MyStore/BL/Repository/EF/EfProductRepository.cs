using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.Models;
using MyStore.DAL.EF;

namespace MyStore.BL.Repository.EF
{
    public class EfProductRepository : IProductRepository
    {
        private List<ProductDto> products;
        private List<ProductDto> productsPremium;

        public EfProductRepository()
        {
            SetListProducts();
            SetListPremiumProducts();
        }
        private void SetListProducts()
        {
            using (StoreContext context = new StoreContext())
            {
                products = context.Products.Where(x => x.IsPremium == false).ToList();
            }
        }
        private void SetListPremiumProducts()
        {
            using(StoreContext context = new StoreContext())
            {
                productsPremium = context.Products.Where(x => x.IsPremium == true).ToList();
            }
        }
        public IEnumerable<Product> GetProducts()
        {
            return products.Select(e => new Product(e, e.IsPremium)).ToList();
        }

        public IEnumerable<Product> GetProductsPremium()
        {
            return productsPremium.Select(e => new Product(e, e.IsPremium)).ToList();
        }
    }
}