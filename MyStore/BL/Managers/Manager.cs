using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.BL.Repository.EF;
using MyStore.Models;
using MyStore.BL.Repository;

namespace MyStore.BL.Managers
{
    public class Manager : IManager
    {
        private IAccountRepository accountRepository;
        private IProductRepository productRepository;
        
        public Manager(IAccountRepository account, IProductRepository product)
        {
            accountRepository = account;
            productRepository = product;
        }
        
        public IEnumerable<Product> GetProductByAccountType(int userId)
        {
            Account account = accountRepository.GetById(userId);
            if (account == null)
                return null;
            List<Product> products = new List<Product>();
            IEnumerable<Product> basicProducts = productRepository.GetProducts();
            if(basicProducts != null)
                products.AddRange(basicProducts);
            if(account.AccountType == AccountType.Premium)
            {
                IEnumerable<Product> premiumProducts = productRepository.GetProductsPremium();
                products.AddRange(premiumProducts);
            }
            return products;
        }
    }
}