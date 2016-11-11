
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Training
    {
        public Training()
        {
            this.Journals = new HashSet<Journal>();
        }
    
        public int Id { get; set; }
        public System.DateTime TimeStart { get; set; }
        public System.DateTime TimeEnd { get; set; }
    
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual Timetable Timetable { get; set; }
    }
}
