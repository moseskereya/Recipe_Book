namespace Moses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImgUrl = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.Category_CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pies", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Pies", new[] { "Category_CategoryId" });
            DropTable("dbo.Pies");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
