namespace MVC_Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTheSecondTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusicGenre",
                c => new
                    {
                        MusicGenreId = c.Int(nullable: false, identity: true),
                        GenreType = c.String(),
                        Album_Id = c.Int(),
                    })
                .PrimaryKey(t => t.MusicGenreId)
                .ForeignKey("dbo.Album", t => t.Album_Id)
                .Index(t => t.Album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MusicGenre", "Album_Id", "dbo.Album");
            DropIndex("dbo.MusicGenre", new[] { "Album_Id" });
            DropTable("dbo.MusicGenre");
        }
    }
}
