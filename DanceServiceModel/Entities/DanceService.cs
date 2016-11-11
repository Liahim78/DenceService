namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class DanceCenter
    {
        public DanceCenter()
        {
            this.Schools = new HashSet<School>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    
        public virtual ICollection<School> Schools { get; set; }
    }
}
