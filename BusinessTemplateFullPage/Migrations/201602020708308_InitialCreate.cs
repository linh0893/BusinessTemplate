namespace BusinessTemplateFullPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Category_id = c.Int(nullable: false),
                        Category_name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Category_id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Product_id = c.Int(nullable: false),
                        Product_name = c.String(maxLength: 100),
                        Price = c.Int(),
                        Status = c.String(maxLength: 50, unicode: false),
                        Quantity = c.Int(),
                        Descriptions = c.String(maxLength: 1000),
                        Image_id = c.Int(),
                        IsDisplay = c.String(maxLength: 50, unicode: false),
                        TopView = c.Int(),
                        Discount = c.Int(),
                        Discount_Start = c.DateTime(storeType: "date"),
                        Category_Id = c.Int(),
                        Discount_End = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Product_id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .ForeignKey("dbo.Image", t => t.Image_id)
                .Index(t => t.Image_id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        Image_Id = c.Int(nullable: false),
                        Image_link = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Image_Id);
            
            CreateTable(
                "dbo.KeyWord",
                c => new
                    {
                        Key_id = c.Int(nullable: false),
                        Keyword = c.String(maxLength: 100),
                        KeywordEN = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Key_id);
            
            CreateTable(
                "dbo.Topic",
                c => new
                    {
                        Topic_id = c.Int(nullable: false),
                        Topic_Title = c.String(maxLength: 200),
                        Topic_Content = c.String(maxLength: 3500),
                        Created = c.DateTime(),
                    })
                .PrimaryKey(t => t.Topic_id);
            
            CreateTable(
                "dbo.CompanyInfor",
                c => new
                    {
                        CompanyId = c.Int(nullable: false),
                        Company_name = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 50),
                        Account_Admin = c.String(maxLength: 50, unicode: false),
                        Account_password = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 200),
                        location_lat = c.Double(),
                        lacation_lng = c.Double(),
                        link_logo = c.String(maxLength: 100, unicode: false),
                        About = c.String(maxLength: 4000),
                        Company_image = c.String(maxLength: 100, unicode: false),
                        Company_video = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.Product_Image",
                c => new
                    {
                        Image_Id = c.Int(nullable: false),
                        Product_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Image_Id, t.Product_id })
                .ForeignKey("dbo.Image", t => t.Image_Id, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Product_id, cascadeDelete: true)
                .Index(t => t.Image_Id)
                .Index(t => t.Product_id);
            
            CreateTable(
                "dbo.Product_Keyword",
                c => new
                    {
                        Key_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Key_Id, t.Product_Id })
                .ForeignKey("dbo.KeyWord", t => t.Key_Id, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Key_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Topic_Keyword",
                c => new
                    {
                        Keyword_id = c.Int(nullable: false),
                        Topic_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Keyword_id, t.Topic_Id })
                .ForeignKey("dbo.KeyWord", t => t.Keyword_id, cascadeDelete: true)
                .ForeignKey("dbo.Topic", t => t.Topic_Id, cascadeDelete: true)
                .Index(t => t.Keyword_id)
                .Index(t => t.Topic_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topic_Keyword", "Topic_Id", "dbo.Topic");
            DropForeignKey("dbo.Topic_Keyword", "Keyword_id", "dbo.KeyWord");
            DropForeignKey("dbo.Product_Keyword", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.Product_Keyword", "Key_Id", "dbo.KeyWord");
            DropForeignKey("dbo.Product_Image", "Product_id", "dbo.Product");
            DropForeignKey("dbo.Product_Image", "Image_Id", "dbo.Image");
            DropForeignKey("dbo.Product", "Image_id", "dbo.Image");
            DropForeignKey("dbo.Product", "Category_Id", "dbo.Category");
            DropIndex("dbo.Topic_Keyword", new[] { "Topic_Id" });
            DropIndex("dbo.Topic_Keyword", new[] { "Keyword_id" });
            DropIndex("dbo.Product_Keyword", new[] { "Product_Id" });
            DropIndex("dbo.Product_Keyword", new[] { "Key_Id" });
            DropIndex("dbo.Product_Image", new[] { "Product_id" });
            DropIndex("dbo.Product_Image", new[] { "Image_Id" });
            DropIndex("dbo.Product", new[] { "Category_Id" });
            DropIndex("dbo.Product", new[] { "Image_id" });
            DropTable("dbo.Topic_Keyword");
            DropTable("dbo.Product_Keyword");
            DropTable("dbo.Product_Image");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.CompanyInfor");
            DropTable("dbo.Topic");
            DropTable("dbo.KeyWord");
            DropTable("dbo.Image");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
