
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Team
    {
        public Team()
        {
            this.Features = new HashSet<Feature>();
            this.Timetables = new HashSet<Timetable>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Info { get; set; }
    
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
