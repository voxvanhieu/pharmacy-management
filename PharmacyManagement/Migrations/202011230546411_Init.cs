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
                        BaseUnitName = c.String(nullable: false, maxLength: 255),
                        BaseUnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        ReferenceLink = c.String(nullable: false),
                        Created = c.DateTime(nullable: false, storeType: "date"),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CommodityTypes", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.InvoiceCommodities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommodityQuantity = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                        CommodityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Commodities", t => t.CommodityId, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .Index(t => t.InvoiceID)
                .Index(t => t.CommodityId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        Created = c.DateTime(nullable: false, storeType: "date"),
                        Type_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InvoiceTypes", t => t.Type_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.InvoiceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
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
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SaleUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleUnitName = c.String(nullable: false, maxLength: 255),
                        SaleUnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        CommodityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Commodities", t => t.CommodityId, cascadeDelete: true)
                .Index(t => t.CommodityId);
            
            CreateTable(
                "dbo.CommodityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commodities", "Type_Id", "dbo.CommodityTypes");
            DropForeignKey("dbo.SaleUnits", "CommodityId", "dbo.Commodities");
            DropForeignKey("dbo.InvoiceCommodities", "InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Invoices", "Type_Id", "dbo.InvoiceTypes");
            DropForeignKey("dbo.InvoiceCommodities", "CommodityId", "dbo.Commodities");
            DropIndex("dbo.CommodityTypes", new[] { "Name" });
            DropIndex("dbo.SaleUnits", new[] { "CommodityId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.InvoiceTypes", new[] { "Name" });
            DropIndex("dbo.Invoices", new[] { "User_Id" });
            DropIndex("dbo.Invoices", new[] { "Type_Id" });
            DropIndex("dbo.InvoiceCommodities", new[] { "CommodityId" });
            DropIndex("dbo.InvoiceCommodities", new[] { "InvoiceID" });
            DropIndex("dbo.Commodities", new[] { "Type_Id" });
            DropTable("dbo.CommodityTypes");
            DropTable("dbo.SaleUnits");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.InvoiceTypes");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceCommodities");
            DropTable("dbo.Commodities");
        }
    }
}
