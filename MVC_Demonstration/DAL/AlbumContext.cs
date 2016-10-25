using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Assignment4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC_Assignment4.DAL
{
	public class AlbumContext : DbContext
	{
		public AlbumContext() : base("AlbumContext")
		{ }
		public DbSet<Album> Album { get; set; }
		public DbSet<MusicGenre> MusicGenre { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			//This is the code if you were to have a many to many relationship. This will create the extra table for the database.
			//modelBuilder.Entity<Album>().HasMany(m => m.MusicGenre).WithMany(a => a.Album)
			//	.Map(t => t.MapLeftKey("AlbumID")
			//	.MapRightKey("MusicGenreID")
			//	.ToTable("AlbumMusicGenre"));
		}
	}
}