namespace Team_Five_Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringindustries : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Industry2", c => c.String());
            AddColumn("dbo.Companies", "Industry3", c => c.String());
            AlterColumn("dbo.Companies", "Industry1", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Industry1", c => c.Int(nullable: false));
            DropColumn("dbo.Companies", "Industry3");
            DropColumn("dbo.Companies", "Industry2");
        }
    }
}
