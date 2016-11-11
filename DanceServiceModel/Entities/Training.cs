
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Training
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Training()
        {
            this.Journals = new HashSet<Journal>();
        }
    
        public int Id { get; set; }
        public int IdTimetable { get; set; }
        public System.DateTime TimeStart { get; set; }
        public System.DateTime TimeEnd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual Timetable Timetable { get; set; }
    }
}
