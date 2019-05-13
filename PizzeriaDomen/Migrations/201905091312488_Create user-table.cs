namespace PizzeriaDomen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createusertable : DbMigration
    {
        public override void Up()
        {


            CreateTable(
               "dbo.Roles",
               c => new
               {
                   ID = c.Int(nullable: false, identity: true),
                   Name = c.String(nullable: false),
               })
               .PrimaryKey(t => t.ID);






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
                   OrderComp = c.String(nullable: false),
                   OrderDate = c.DateTime(nullable: false),
                   OrderStatus = c.String(nullable: false),
                   RoleID = c.Int(nullable: false),
               })
              .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ID, cascadeDelete: true)
                .Index(t => t.RoleID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");

            DropTable("dbo.Users");
            DropTable("dbo.Orders");
        }
    }
}
