namespace Wardrobe_Take2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
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
            DropTable("dbo.Accessories");
        }
    }
}
