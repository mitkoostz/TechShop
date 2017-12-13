namespace Tech_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        clientName = c.String(nullable: false),
                        clientPhone = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                        City = c.String(nullable: false),
                        OrderedProducts = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
