
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class User: IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
        public User()
        {
            this.Features = new HashSet<Feature>();
            this.Journals = new HashSet<Journal>();
            this.Subscribes = new HashSet<Subscribe>();
            this.Meetings = new HashSet<Meeting>();
            this.Schools = new HashSet<School>();
            this.Teams = new HashSet<Team>();
            this.Timetables = new HashSet<Timetable>();
        }
    
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Nick { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Stiles { get; set; }
        public string Password { get; set; }
        public string Info { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Subscribe> Subscribes { get; set; }
        public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}
