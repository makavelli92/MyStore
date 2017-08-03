using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Models;

namespace MyStore.BL.ViewModels
{
    public interface IProductViewModelBuilder
    {
        ProductViewModel GetViewModel(Product product);

        ProductListViewModel GetListViewModel(List<Product> products);
    }
}
