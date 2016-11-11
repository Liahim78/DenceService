
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Journal
    {
        public int Id { get; set; }
        public bool Visit { get; set; }
        public bool Protect { get; set; }
    
        public virtual Training Training { get; set; }
        public virtual User User { get; set; }
    }
}
