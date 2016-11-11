
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DanceServiceModel.Entities;

namespace DanceServiceModel.Context
{
    
    public class CommunityBDEntities : DbContext
    {
        public CommunityBDEntities()
            : base("name=CommunityBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DanceCenter> DanceCenters { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Subscribe> Subscribes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserMeeting> UserMeetings { get; set; }
        public virtual DbSet<UserSchool> UserSchools { get; set; }
        public virtual DbSet<UserTeam> UserTeams { get; set; }
        public virtual DbSet<UserTimetable> UserTimetables { get; set; }
    }
}
