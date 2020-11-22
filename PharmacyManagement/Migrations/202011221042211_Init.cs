namespace PharmacyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commodities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        Provider = c.String(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        BaseUnit = c.String(nullable: false, maxLength: 255),
                        BaseUnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        ReferenceLink = c.String(nullable: false),
                        Created = c.DateTime(nullable: false, storeType: "date"),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CommodityTypes", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.CommodityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 64),
                        PasswordHash = c.String(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 300),
                        Address = c.String(),
                        Gender = c.Boolean(nullable: false),
                        Image = c.String(),
                        Birthday = c.DateTime(nullable: false, storeType: "date"),
                        Created = c.DateTime(nullable: false, storeType: "date"),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Commodities", "Type_Id", "dbo.CommodityTypes");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.CommodityTypes", new[] { "Name" });
            DropIndex("dbo.Commodities", new[] { "Type_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.CommodityTypes");
            DropTable("dbo.Commodities");
        }
    }
}
