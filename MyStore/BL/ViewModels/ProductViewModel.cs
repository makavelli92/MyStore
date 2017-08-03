using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.Models;

namespace MyStore.BL.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public string AccountTypeLabel
        {
            get
            {
                return Product.IsPremium ? "Premium" : "Basic";
            }
        }
    }
}