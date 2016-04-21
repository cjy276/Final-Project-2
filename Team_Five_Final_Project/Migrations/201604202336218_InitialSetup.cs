namespace Team_Five_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.CSOes",
                c => new
                    {
                        CSOID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CSOID);
            
            CreateTable(
                "dbo.Recruiters",
                c => new
                    {
                        RecruiterID = c.Int(nullable: false, identity: true),
                        Company_CompanyID = c.Int(),
                    })
                .PrimaryKey(t => t.RecruiterID)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyID)
                .Index(t => t.Company_CompanyID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Email = c.String(),
                        Industry = c.String(),
                        Description = c.String(),
                        Industry1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        GraduationDate = c.DateTime(nullable: false),
                        PositionType = c.Int(nullable: false),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        FName = c.String(),
                        LName = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        CSO_CSOID = c.Int(),
                        Recruiter_RecruiterID = c.Int(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CSOes", t => t.CSO_CSOID)
                .ForeignKey("dbo.Recruiters", t => t.Recruiter_RecruiterID)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.CSO_CSOID)
                .Index(t => t.Recruiter_RecruiterID)
                .Index(t => t.Student_StudentID);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Recruiter_RecruiterID", "dbo.Recruiters");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CSO_CSOID", "dbo.CSOes");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Recruiters", "Company_CompanyID", "dbo.Companies");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Student_StudentID" });
            DropIndex("dbo.AspNetUsers", new[] { "Recruiter_RecruiterID" });
            DropIndex("dbo.AspNetUsers", new[] { "CSO_CSOID" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Recruiters", new[] { "Company_CompanyID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Students");
            DropTable("dbo.Companies");
            DropTable("dbo.Recruiters");
            DropTable("dbo.CSOes");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
