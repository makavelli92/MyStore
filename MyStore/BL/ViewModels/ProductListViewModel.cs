using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyStore.BL.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; } 
    }
}