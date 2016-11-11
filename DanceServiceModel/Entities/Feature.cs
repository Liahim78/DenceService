
using System.ComponentModel.DataAnnotations;

namespace DanceServiceModel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public  class Feature
    {
        public int Id { get; set; }
        public string UrlVideoContent { get; set; }
        public string UrlPhotoContent { get; set; }
        public bool PrivatePublic { get; set; }
        public bool TypeNew { get; set; }
        public string Style { get; set; }
        public string TypeOfStyle { get; set; }
    
        public virtual Meeting Meeting { get; set; }
        public virtual School School { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
