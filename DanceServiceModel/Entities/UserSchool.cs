
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class UserSchool
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdSchool { get; set; }
        public Nullable<bool> Type { get; set; }
    
        public virtual School School { get; set; }
        public virtual User User { get; set; }
    }
}
