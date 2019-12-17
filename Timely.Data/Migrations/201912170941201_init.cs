namespace Timely.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(),
                        Ticks = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Task_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tasks", t => t.Task_ID)
                .Index(t => t.Task_ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TotalTicks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Task_ID", "dbo.Tasks");
            DropIndex("dbo.Events", new[] { "Task_ID" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Events");
        }
    }
}
