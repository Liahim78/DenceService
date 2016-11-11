
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class UserTeam
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdTeam { get; set; }
        public Nullable<bool> Type { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
