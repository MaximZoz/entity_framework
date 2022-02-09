namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenerals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Generals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Comment = c.String(),
                        Rating = c.String(),
                        Product_Id = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Generals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Generals", "Product_Id", "dbo.Products");
            DropIndex("dbo.Generals", new[] { "User_Id" });
            DropIndex("dbo.Generals", new[] { "Product_Id" });
            DropTable("dbo.Generals");
        }
    }
}
