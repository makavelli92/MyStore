using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyStore.DAL.EF;

namespace MyStore.Models
{
    public class Account
    {
        public int UserId { get; set; }
        public AccountType AccountType { get; set; }

        public Account(AccountDto dto)
        {
            UserId = dto.UserId;
            AccountType = (AccountType)dto.AccountType;
        }
    }
}