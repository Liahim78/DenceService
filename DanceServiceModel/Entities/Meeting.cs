
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Meeting
    {
        public Meeting()
        {
            this.Features = new HashSet<Feature>();
            this.Timetables = new HashSet<Timetable>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Info { get; set; }
    
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
