namespace Team_Five_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appuserID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AppUserID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AppUserID");
        }
    }
}
