namespace PizzeriaDomen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegister : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderComp = c.String(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Roles");
            DropTable("dbo.Orders");
        }
    }
}
