namespace PawelOsajdaZadanieDomowe3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuborderLaptopPatch : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Suborders", "LaptopId");
            AddForeignKey("dbo.Suborders", "LaptopId", "dbo.Laptops", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suborders", "LaptopId", "dbo.Laptops");
            DropIndex("dbo.Suborders", new[] { "LaptopId" });
        }
    }
}
