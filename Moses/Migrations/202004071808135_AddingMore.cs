namespace Moses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMore : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
