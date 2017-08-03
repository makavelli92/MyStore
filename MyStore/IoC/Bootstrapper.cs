using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using System.Web.Mvc;

namespace MyStore.IoC
{
    public static class Bootstrapper
    {
        public static void ConfigureStructureMap(Action<ConfigurationExpression> conf)
        {
            IContainer container = new Container(conf);
            StructureMapControllerFactory controllerFactory = new StructureMapControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}