namespace PawelOsajdaZadanieDomowe3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                        DeliveryTime = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GraphicsCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(nullable: false),
                        VRamAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProcessorId = c.Int(nullable: false),
                        GraphicsCardId = c.Int(nullable: false),
                        Model = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        RamAmount = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GraphicsCards", t => t.GraphicsCardId, cascadeDelete: true)
                .ForeignKey("dbo.Processors", t => t.ProcessorId, cascadeDelete: true)
                .Index(t => t.ProcessorId)
                .Index(t => t.GraphicsCardId);
            
            CreateTable(
                "dbo.Processors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(nullable: false),
                        NumberOfThreds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserInformationsId = c.Int(nullable: false),
                        DeliveryId = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.DeliveryId, cascadeDelete: true)
                .ForeignKey("dbo.UserInformations", t => t.UserInformationsId, cascadeDelete: true)
                .Index(t => t.UserInformationsId)
                .Index(t => t.DeliveryId);
            
            CreateTable(
                "dbo.Suborders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        LaptopId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.UserInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserInformationsId = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInformations", t => t.UserInformationsId, cascadeDelete: true)
                .Index(t => t.UserInformationsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserInformationsId", "dbo.UserInformations");
            DropForeignKey("dbo.Users", "UserInformationsId", "dbo.UserInformations");
            DropForeignKey("dbo.Suborders", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "DeliveryId", "dbo.Deliveries");
            DropForeignKey("dbo.Laptops", "ProcessorId", "dbo.Processors");
            DropForeignKey("dbo.Laptops", "GraphicsCardId", "dbo.GraphicsCards");
            DropIndex("dbo.Users", new[] { "UserInformationsId" });
            DropIndex("dbo.Suborders", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "DeliveryId" });
            DropIndex("dbo.Orders", new[] { "UserInformationsId" });
            DropIndex("dbo.Laptops", new[] { "GraphicsCardId" });
            DropIndex("dbo.Laptops", new[] { "ProcessorId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserInformations");
            DropTable("dbo.Suborders");
            DropTable("dbo.Orders");
            DropTable("dbo.Processors");
            DropTable("dbo.Laptops");
            DropTable("dbo.GraphicsCards");
            DropTable("dbo.Deliveries");
        }
    }
}
