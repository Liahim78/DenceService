
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
            this.Subscribes1 = new HashSet<Subscribe>();
            this.UserMeetings = new HashSet<UserMeeting>();
            this.UserSchools = new HashSet<UserSchool>();
            this.UserTeams = new HashSet<UserTeam>();
            this.UserTimetables = new HashSet<UserTimetable>();
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Journal> Journals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscribe> Subscribes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscribe> Subscribes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMeeting> UserMeetings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSchool> UserSchools { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTeam> UserTeams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTimetable> UserTimetables { get; set; }
    }
}
