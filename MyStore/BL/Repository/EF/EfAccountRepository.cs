using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.Models;
using MyStore.DAL.EF;

namespace MyStore.BL.Repository.EF
{
    public class EfAccountRepository : IAccountRepository
    {
        public Account GetById(int userId)
        {
            using (StoreContext context = new StoreContext())
            {
                AccountDto dto = context.Accounts.FirstOrDefault(e => e.UserId == userId);
                return dto != null ? new Account(dto) : null;
            }
            
        }
    }
}