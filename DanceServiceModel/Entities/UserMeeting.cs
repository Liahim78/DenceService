
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class UserMeeting
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdMeeting { get; set; }
        public Nullable<bool> Type { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual User User { get; set; }
    }
}
