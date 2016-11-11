
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            this.Features = new HashSet<Feature>();
            this.Timetables = new HashSet<Timetable>();
            this.UserTeams = new HashSet<UserTeam>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Info { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Features { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Timetable> Timetables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTeam> UserTeams { get; set; }
    }
}
