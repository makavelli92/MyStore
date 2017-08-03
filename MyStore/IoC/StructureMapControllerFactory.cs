using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using System.Web.Routing;
using System.Web.Mvc;

namespace MyStore.IoC
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        private readonly IContainer container;

        public StructureMapControllerFactory(IContainer container)
        {
            this.container = container;
        }

        protected override IController GetControllerInstance(RequestContext context, Type controllerType)
        {
            if (context == null || controllerType == null)
                return null;
            return (IController)container.GetInstance(controllerType);
        }
    }
}