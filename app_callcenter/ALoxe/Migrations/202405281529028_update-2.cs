namespace ALoxe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        ProvinceCode = c.String(),
                        ProvinceId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Province", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId, name: "IX_Street_DistrictId");
            
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Street",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        DistrictCode = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.District", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId, name: "IX_Street_DistrictId");
            
            CreateTable(
                "dbo.UserRemember",
                c => new
                    {
                        Phone = c.String(nullable: false, maxLength: 128),
                        Pasword = c.String(),
                    })
                .PrimaryKey(t => t.Phone);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Phone = c.String(),
                        Token = c.String(),
                        ReToken = c.String(),
                        UrlAvatar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Street", "DistrictId", "dbo.District");
            DropForeignKey("dbo.District", "ProvinceId", "dbo.Province");
            DropIndex("dbo.Street", "IX_Street_DistrictId");
            DropIndex("dbo.District", "IX_Street_DistrictId");
            DropTable("dbo.User");
            DropTable("dbo.UserRemember");
            DropTable("dbo.Street");
            DropTable("dbo.Province");
            DropTable("dbo.District");
        }
    }
}
