namespace Team5_FinalProject_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Description = c.String(),
                        Industry = c.String(),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PostitionType = c.String(),
                        Location = c.String(),
                        Deadline = c.DateTime(nullable: false),
                        Company_CompanyID = c.Int(),
                    })
                .PrimaryKey(t => t.PositionID)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyID)
                .Index(t => t.Company_CompanyID);
            
            CreateTable(
                "dbo.Recruiters",
                c => new
                    {
                        RecruiterID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Company_CompanyID = c.Int(),
                    })
                .PrimaryKey(t => t.RecruiterID)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyID)
                .Index(t => t.Company_CompanyID);
            
            CreateTable(
                "dbo.CSOes",
                c => new
                    {
                        CSOID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CSOID);
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        InterviewID = c.Int(nullable: false, identity: true),
                        InterviewTimeSlot = c.Int(nullable: false),
                        InterviewDate = c.DateTime(nullable: false),
                        Position_PositionID = c.Int(),
                        Room_RoomID = c.Int(),
                    })
                .PrimaryKey(t => t.InterviewID)
                .ForeignKey("dbo.Positions", t => t.Position_PositionID)
                .ForeignKey("dbo.Rooms", t => t.Room_RoomID)
                .Index(t => t.Position_PositionID)
                .Index(t => t.Room_RoomID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        Slot1 = c.Boolean(nullable: false),
                        Slot2 = c.Boolean(nullable: false),
                        Slot3 = c.Boolean(nullable: false),
                        Slot4 = c.Boolean(nullable: false),
                        Slot5 = c.Boolean(nullable: false),
                        Slot6 = c.Boolean(nullable: false),
                        Slot7 = c.Boolean(nullable: false),
                        Slot8 = c.Boolean(nullable: false),
                        Slot9 = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Major = c.Int(nullable: false),
                        PositionType = c.Int(nullable: false),
                        GradDate = c.DateTime(nullable: false),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentID);
            
            AddColumn("dbo.AspNetUsers", "Major", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interviews", "Room_RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Interviews", "Position_PositionID", "dbo.Positions");
            DropForeignKey("dbo.Recruiters", "Company_CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Positions", "Company_CompanyID", "dbo.Companies");
            DropIndex("dbo.Interviews", new[] { "Room_RoomID" });
            DropIndex("dbo.Interviews", new[] { "Position_PositionID" });
            DropIndex("dbo.Recruiters", new[] { "Company_CompanyID" });
            DropIndex("dbo.Positions", new[] { "Company_CompanyID" });
            DropColumn("dbo.AspNetUsers", "Major");
            DropTable("dbo.Students");
            DropTable("dbo.Rooms");
            DropTable("dbo.Interviews");
            DropTable("dbo.CSOes");
            DropTable("dbo.Recruiters");
            DropTable("dbo.Positions");
            DropTable("dbo.Companies");
        }
    }
}
