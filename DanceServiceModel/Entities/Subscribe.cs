
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Subscribe
    {
        public int Id { get; set; }
        public int IdUserOnWhom { get; set; }
        public int IdUserWho { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
