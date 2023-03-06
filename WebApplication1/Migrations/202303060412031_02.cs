namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LectureID = c.String(nullable: false, maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 250),
                        DateTime = c.DateTime(nullable: false),
                        categoryID = c.Byte(nullable: false),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.LectureID, cascadeDelete: true)
                .Index(t => t.LectureID)
                .Index(t => t.category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LectureID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "category_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "category_Id" });
            DropIndex("dbo.Courses", new[] { "LectureID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
