
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DanceServiceModel.Entities;

namespace DanceServiceModel.Context
{
    
    public class ServiceDbEntities : DbContext
    {
        public ServiceDbEntities()
            : base("DanceServiceContext")
        {
        }
    
       
    
        public virtual DbSet<DanceService> DanceCenters { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Subscribe> Subscribes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
