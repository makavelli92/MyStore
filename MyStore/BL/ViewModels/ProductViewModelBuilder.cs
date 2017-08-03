using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.Models;

namespace MyStore.BL.ViewModels
{
    public class ProductViewModelBuilder : IProductViewModelBuilder
    {
        public ProductViewModel GetViewModel(Product product)
        {
            return new ProductViewModel { Product = product };
        }

        public ProductListViewModel GetListViewModel(List<Product> products)
        {
            return new ProductListViewModel
            {
                Products = products.Select(e => GetViewModel(e)).ToList()
            };
        }
    }
}