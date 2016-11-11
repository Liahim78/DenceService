namespace DanceServiceModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanceServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stile = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Adress = c.String(),
                        IdDanceCentre = c.Int(nullable: false),
                        Links = c.String(),
                        DanceService_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DanceServices", t => t.DanceService_Id)
                .Index(t => t.DanceService_Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(),
                        IdSchool = c.Int(),
                        IdTeam = c.Int(),
                        IdMeeting = c.Int(),
                        UrlVideoContent = c.String(),
                        UrlPhotoContent = c.String(),
                        Private_Public = c.Boolean(nullable: false),
                        TypeNew = c.Boolean(nullable: false),
                        IdNew = c.Int(),
                        Style = c.String(),
                        TypeOfStyle = c.String(),
                        Meeting_Id = c.Int(),
                        Team_Id = c.Int(),
                        User_Id = c.Int(),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meetings", t => t.Meeting_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.Meeting_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.User_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Adress = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Timetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdSchool = c.Int(),
                        Stile = c.String(),
                        IdMeeting = c.Int(),
                        IdTeam = c.Int(),
                        Meeting_Id = c.Int(),
                        School_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meetings", t => t.Meeting_Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Meeting_Id)
                .Index(t => t.School_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stile = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdTeam = c.Int(nullable: false),
                        Type = c.Boolean(),
                        Team_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Nick = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Stiles = c.String(),
                        Password = c.String(),
                        Info = c.String(),
                        Birthday = c.DateTime(),
                        Phone = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdTraining = c.Int(nullable: false),
                        Visit = c.Boolean(nullable: false),
                        Protect = c.Boolean(nullable: false),
                        Training_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainings", t => t.Training_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Training_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdTimetable = c.Int(nullable: false),
                        TimeStart = c.DateTime(nullable: false),
                        TimeEnd = c.DateTime(nullable: false),
                        Timetable_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Timetables", t => t.Timetable_Id)
                .Index(t => t.Timetable_Id);
            
            CreateTable(
                "dbo.Subscribes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUserOnWhom = c.Int(nullable: false),
                        IdUserWho = c.Int(nullable: false),
                        User_Id = c.Int(),
                        User1_Id = c.Int(),
                        User_Id1 = c.Int(),
                        User_Id2 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User1_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .ForeignKey("dbo.Users", t => t.User_Id2)
                .Index(t => t.User_Id)
                .Index(t => t.User1_Id)
                .Index(t => t.User_Id1)
                .Index(t => t.User_Id2);
            
            CreateTable(
                "dbo.UserMeetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdMeeting = c.Int(nullable: false),
                        Type = c.Boolean(),
                        Meeting_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meetings", t => t.Meeting_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Meeting_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserSchools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdSchool = c.Int(nullable: false),
                        Type = c.Boolean(),
                        School_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.School_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserTimetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdTimetable = c.Int(nullable: false),
                        Timetable_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Timetables", t => t.Timetable_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Timetable_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Features", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.UserTimetables", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserTimetables", "Timetable_Id", "dbo.Timetables");
            DropForeignKey("dbo.UserTeams", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserSchools", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserSchools", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.UserMeetings", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserMeetings", "Meeting_Id", "dbo.Meetings");
            DropForeignKey("dbo.Subscribes", "User_Id2", "dbo.Users");
            DropForeignKey("dbo.Subscribes", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.Subscribes", "User1_Id", "dbo.Users");
            DropForeignKey("dbo.Subscribes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Journals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Trainings", "Timetable_Id", "dbo.Timetables");
            DropForeignKey("dbo.Journals", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.Features", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Timetables", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Features", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Timetables", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Timetables", "Meeting_Id", "dbo.Meetings");
            DropForeignKey("dbo.Features", "Meeting_Id", "dbo.Meetings");
            DropForeignKey("dbo.Schools", "DanceService_Id", "dbo.DanceServices");
            DropIndex("dbo.UserTimetables", new[] { "User_Id" });
            DropIndex("dbo.UserTimetables", new[] { "Timetable_Id" });
            DropIndex("dbo.UserSchools", new[] { "User_Id" });
            DropIndex("dbo.UserSchools", new[] { "School_Id" });
            DropIndex("dbo.UserMeetings", new[] { "User_Id" });
            DropIndex("dbo.UserMeetings", new[] { "Meeting_Id" });
            DropIndex("dbo.Subscribes", new[] { "User_Id2" });
            DropIndex("dbo.Subscribes", new[] { "User_Id1" });
            DropIndex("dbo.Subscribes", new[] { "User1_Id" });
            DropIndex("dbo.Subscribes", new[] { "User_Id" });
            DropIndex("dbo.Trainings", new[] { "Timetable_Id" });
            DropIndex("dbo.Journals", new[] { "User_Id" });
            DropIndex("dbo.Journals", new[] { "Training_Id" });
            DropIndex("dbo.UserTeams", new[] { "User_Id" });
            DropIndex("dbo.UserTeams", new[] { "Team_Id" });
            DropIndex("dbo.Timetables", new[] { "Team_Id" });
            DropIndex("dbo.Timetables", new[] { "School_Id" });
            DropIndex("dbo.Timetables", new[] { "Meeting_Id" });
            DropIndex("dbo.Features", new[] { "School_Id" });
            DropIndex("dbo.Features", new[] { "User_Id" });
            DropIndex("dbo.Features", new[] { "Team_Id" });
            DropIndex("dbo.Features", new[] { "Meeting_Id" });
            DropIndex("dbo.Schools", new[] { "DanceService_Id" });
            DropTable("dbo.UserTimetables");
            DropTable("dbo.UserSchools");
            DropTable("dbo.UserMeetings");
            DropTable("dbo.Subscribes");
            DropTable("dbo.Trainings");
            DropTable("dbo.Journals");
            DropTable("dbo.Users");
            DropTable("dbo.UserTeams");
            DropTable("dbo.Teams");
            DropTable("dbo.Timetables");
            DropTable("dbo.Meetings");
            DropTable("dbo.Features");
            DropTable("dbo.Schools");
            DropTable("dbo.DanceServices");
        }
    }
}
