
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Timetable
    {
        public Timetable()
        {
            this.Trainings = new HashSet<Training>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string Stile { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual School School { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<Training> Trainings { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
