namespace Timely.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taskEventID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Task_ID", "dbo.Tasks");
            DropIndex("dbo.Events", new[] { "Task_ID" });
            RenameColumn(table: "dbo.Events", name: "Task_ID", newName: "TaskID");
            AlterColumn("dbo.Events", "TaskID", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "TaskID");
            AddForeignKey("dbo.Events", "TaskID", "dbo.Tasks", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "TaskID", "dbo.Tasks");
            DropIndex("dbo.Events", new[] { "TaskID" });
            AlterColumn("dbo.Events", "TaskID", c => c.Int());
            RenameColumn(table: "dbo.Events", name: "TaskID", newName: "Task_ID");
            CreateIndex("dbo.Events", "Task_ID");
            AddForeignKey("dbo.Events", "Task_ID", "dbo.Tasks", "ID");
        }
    }
}
