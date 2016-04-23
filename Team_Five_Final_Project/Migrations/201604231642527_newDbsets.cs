namespace Team_Five_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDbsets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Industries",
                c => new
                    {
                        IndustryID = c.Int(nullable: false, identity: true),
                        IndustryName = c.String(),
                    })
                .PrimaryKey(t => t.IndustryID);
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        InterviewID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Company_CompanyID = c.Int(),
                        Room_InterviewRoomID = c.Int(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.InterviewID)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyID)
                .ForeignKey("dbo.InterviewRooms", t => t.Room_InterviewRoomID)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Company_CompanyID)
                .Index(t => t.Room_InterviewRoomID)
                .Index(t => t.Student_StudentID);
            
            CreateTable(
                "dbo.InterviewRooms",
                c => new
                    {
                        InterviewRoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InterviewRoomID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PositionType = c.String(),
                        Industry = c.String(),
                        Location = c.String(),
                        ApplicableMajors = c.Int(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        Description = c.String(),
                        Company_CompanyID = c.Int(),
                    })
                .PrimaryKey(t => t.PositionID)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyID)
                .Index(t => t.Company_CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Positions", "Company_CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Interviews", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Interviews", "Room_InterviewRoomID", "dbo.InterviewRooms");
            DropForeignKey("dbo.Interviews", "Company_CompanyID", "dbo.Companies");
            DropIndex("dbo.Positions", new[] { "Company_CompanyID" });
            DropIndex("dbo.Interviews", new[] { "Student_StudentID" });
            DropIndex("dbo.Interviews", new[] { "Room_InterviewRoomID" });
            DropIndex("dbo.Interviews", new[] { "Company_CompanyID" });
            DropTable("dbo.Positions");
            DropTable("dbo.InterviewRooms");
            DropTable("dbo.Interviews");
            DropTable("dbo.Industries");
        }
    }
}
