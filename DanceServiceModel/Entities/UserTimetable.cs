
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public class UserTimetable
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdTimetable { get; set; }
    
        public virtual Timetable Timetable { get; set; }
        public virtual User User { get; set; }
    }
}
