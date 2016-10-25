namespace MVC_Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Artist = c.String(),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        ArtistBio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Album");
        }
    }
}
