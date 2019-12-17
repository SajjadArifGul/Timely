namespace Timely.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taskCreatedOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "CreatedOn");
        }
    }
}
