using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DanceServiceModel.Context;

namespace DanceServiceWebApi.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            string result;
            using (var context = new ServiceDbEntities())
            {
                var list = context.Users.ToList();
                result = list.Count.ToString();
            }
            return result;
        }
    }
}
