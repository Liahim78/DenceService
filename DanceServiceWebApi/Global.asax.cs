using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using DanceServiceModel.Context;

namespace DanceServiceWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<ServiceDbEntities>(new DanceServiceInitializer());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
