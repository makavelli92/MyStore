using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using MyStore.BL.Repository;
using MyStore.BL.Managers;
using MyStore.BL.Repository.EF;
using MyStore.BL.Repository.Mocs;
using MyStore.BL.ViewModels;

namespace MyStore.IoC
{
    public class ConfigurationHelper
    {
        public static void ConfigureDependency(ConfigurationExpression temp)
        {
            temp.For<IAccountRepository>().Use<EfAccountRepository>();
            temp.For<IManager>().Use<Manager>();
            temp.For<IProductRepository>().Use<EfProductRepository>();
            temp.For<IProductViewModelBuilder>().Use<ProductViewModelBuilder>();
        }
    }
}