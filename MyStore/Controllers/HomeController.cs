using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyStore.BL.Repository.EF;
using MyStore.Models;
using MyStore.BL.Managers;
using MyStore.BL.ViewModels;

namespace MyStore.Controllers
{
    public class HomeController : Controller
    {
        private IManager manager;
        private IProductViewModelBuilder builder;

        public HomeController(IManager manager, IProductViewModelBuilder builder)
        {
            this.manager = manager;
            this.builder = builder;

        }
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Product> product = manager.GetProductByAccountType(1);
            var pr = builder.GetListViewModel(product.ToList());
            return View(pr);
        }
    }
}