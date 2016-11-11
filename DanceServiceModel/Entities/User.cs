
using System.ComponentModel.DataAnnotations;

namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
    
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nick { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Stiles { get; set; }
        public string Password { get; set; }
        public string Info { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Subscribe> Subscribes { get; set; }
        public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}
