using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceServiceModel.Entities;

namespace DanceServiceModel.Context
{
    public class DanceServiceInitializer: DropCreateDatabaseIfModelChanges<ServiceDbEntities>
    {
        protected override void Seed(ServiceDbEntities context)
        {
            context.Users.Add(new User()
            {
                Name = "Misha",
                Birthday = DateTime.Now.Date,
                City = "Харьков",
                Country = "Ukrain",
                LastName = "Kharchnko",
                Nick = "Liahim",
                Stiles = "Breaking",
                Phone = "0972589877",
                Password = "qwerty",
                email = "awerr78@gmail.com",
                Info = "BBoy"
            });
            context.SaveChanges();
        }
    }
}
