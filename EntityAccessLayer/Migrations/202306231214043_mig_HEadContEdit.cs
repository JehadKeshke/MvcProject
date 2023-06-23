namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_HEadContEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentStatus", c => c.Boolean(nullable:false));
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contents", "ContentStatus");
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}
