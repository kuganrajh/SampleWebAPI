namespace Sample.App.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ini : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "App.Batch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "App.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        DOB = c.DateTime(nullable: false),
                        BatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("App.Batch", t => t.BatchId)
                .Index(t => t.BatchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("App.Student", "BatchId", "App.Batch");
            DropIndex("App.Student", new[] { "BatchId" });
            DropTable("App.Student");
            DropTable("App.Batch");
        }
    }
}
