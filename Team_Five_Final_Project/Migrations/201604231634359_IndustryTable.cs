namespace Team_Five_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IndustryTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Interviews", "Company_CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Interviews", "Room_InterviewRoomID", "dbo.InterviewRooms");
            DropForeignKey("dbo.Interviews", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Positions", "Company_CompanyID", "dbo.Companies");
            DropIndex("dbo.Interviews", new[] { "Company_CompanyID" });
            DropIndex("dbo.Interviews", new[] { "Room_InterviewRoomID" });
            DropIndex("dbo.Interviews", new[] { "Student_StudentID" });
            DropIndex("dbo.Positions", new[] { "Company_CompanyID" });
            AddColumn("dbo.Companies", "Industry", c => c.String());
            DropColumn("dbo.Companies", "Industry2");
            DropColumn("dbo.Companies", "Industry3");
            DropTable("dbo.Interviews");
            DropTable("dbo.InterviewRooms");
            DropTable("dbo.Positions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PositionType = c.Int(nullable: false),
                        Industry = c.Int(nullable: false),
                        Location = c.String(),
                        ApplicableMajors = c.Int(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        Description = c.String(),
                        Company_CompanyID = c.Int(),
                    })
                .PrimaryKey(t => t.PositionID);
            
            CreateTable(
                "dbo.InterviewRooms",
                c => new
                    {
                        InterviewRoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InterviewRoomID);
            
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
                .PrimaryKey(t => t.InterviewID);
            
            AddColumn("dbo.Companies", "Industry3", c => c.Int(nullable: false));
            AddColumn("dbo.Companies", "Industry2", c => c.Int(nullable: false));
            DropColumn("dbo.Companies", "Industry");
            CreateIndex("dbo.Positions", "Company_CompanyID");
            CreateIndex("dbo.Interviews", "Student_StudentID");
            CreateIndex("dbo.Interviews", "Room_InterviewRoomID");
            CreateIndex("dbo.Interviews", "Company_CompanyID");
            AddForeignKey("dbo.Positions", "Company_CompanyID", "dbo.Companies", "CompanyID");
            AddForeignKey("dbo.Interviews", "Student_StudentID", "dbo.Students", "StudentID");
            AddForeignKey("dbo.Interviews", "Room_InterviewRoomID", "dbo.InterviewRooms", "InterviewRoomID");
            AddForeignKey("dbo.Interviews", "Company_CompanyID", "dbo.Companies", "CompanyID");
        }
    }
}
