namespace MVC_Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalizedAllAttributesOnDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Album", "Artist", c => c.String(nullable: false));
            AlterColumn("dbo.MusicGenre", "GenreType", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MusicGenre", "GenreType", c => c.String());
            AlterColumn("dbo.Album", "Artist", c => c.String());
        }
    }
}
