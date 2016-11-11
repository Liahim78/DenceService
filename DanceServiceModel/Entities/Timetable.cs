
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Timetable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Timetable()
        {
            this.Trainings = new HashSet<Training>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdSchool { get; set; }
        public string Stile { get; set; }
        public Nullable<int> IdMeeting { get; set; }
        public Nullable<int> IdTeam { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual School School { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<Training> Trainings { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
