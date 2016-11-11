namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class DanceCenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanceCenter()
        {
            this.Schools = new HashSet<School>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<School> Schools { get; set; }
    }
}
