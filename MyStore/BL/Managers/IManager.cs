﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Models;

namespace MyStore.BL.Managers
{
    public interface IManager
    {
        IEnumerable<Product> GetProductByAccountType(int userId);
    }
}
