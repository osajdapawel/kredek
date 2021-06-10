namespace PawelOsajdaZadanieDomowe3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableDeliveryidinorderpatch : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "DeliveryId", "dbo.Deliveries");
            DropIndex("dbo.Orders", new[] { "DeliveryId" });
            AlterColumn("dbo.Orders", "DeliveryId", c => c.Int());
            CreateIndex("dbo.Orders", "DeliveryId");
            AddForeignKey("dbo.Orders", "DeliveryId", "dbo.Deliveries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DeliveryId", "dbo.Deliveries");
            DropIndex("dbo.Orders", new[] { "DeliveryId" });
            AlterColumn("dbo.Orders", "DeliveryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "DeliveryId");
            AddForeignKey("dbo.Orders", "DeliveryId", "dbo.Deliveries", "Id", cascadeDelete: true);
        }
    }
}
