namespace Wardrobe_Take2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WHoKnows : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bottoms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tops");
            DropTable("dbo.Shoes");
            DropTable("dbo.Bottoms");
        }
    }
}
