namespace PizzeriaDomen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createusertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);






            CreateTable(
                "dbo.Orders",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    OrderComp = c.DateTime(nullable: false),
                    OrderDate = c.String(nullable: false, maxLength: 500),
                    OrderStatus = c.String(nullable: false, maxLength: 200),
                })
                .PrimaryKey(t => t.ID);


        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
        }
    }
}
