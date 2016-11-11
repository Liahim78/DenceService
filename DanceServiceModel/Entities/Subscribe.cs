
namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Subscribe
    {
        public int Id { get; set; }
    
        public virtual User UserFrom { get; set; }
        public virtual User UserTo { get; set; }
    }
}
