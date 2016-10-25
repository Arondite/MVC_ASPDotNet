namespace MVC_Assignment4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using MVC_Assignment4.Models;
	using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Assignment4.DAL.AlbumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_Assignment4.DAL.AlbumContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
		//	var genre = new List<MusicGenre>
		//	{
		//		new MusicGenre() { GenreType = "Rock", Album = context.Album.Where(a => a.Id == 1).Single() },
		//		new Models.MusicGenre() {GenreType ="Post Hardcore Rock", Album = context.Album.Where(a => a.Id == 1).Single()}
		//	};
		//	genre.ForEach(g => context.MusicGenre.AddOrUpdate(g));
		//	context.SaveChanges();

		//	var genreTwo = new List<MusicGenre>
		//	{
		//		new MusicGenre() { GenreType = "Rock", Album = context.Album.Where(a => a.Id == 2).Single() },
		//		new MusicGenre() { GenreType = "Post Hardcore Rock", Album = context.Album.Where(a => a.Id == 2).Single() },
		//		new MusicGenre() { GenreType = "Rock", Album = context.Album.Where(a => a.Id == 3).Single() },
		//		new MusicGenre() { GenreType = "Post Hardcore Rock", Album = context.Album.Where(a => a.Id == 3).Single() },
		//		new MusicGenre() { GenreType = "Rock", Album = context.Album.Where(a => a.Id == 4).Single() },
		//		new MusicGenre() { GenreType = "Post Hardcore Rock", Album = context.Album.Where(a => a.Id == 4).Single() }
		//	};
		//	genreTwo.ForEach(g => context.MusicGenre.AddOrUpdate(g));
		//	context.SaveChanges();

		//	var album = new List<Album>
		//	{
		//		new Album() { Artist = "Johnny Cash", ReleaseDate = DateTime.Parse("1997-01-01"), Title = "Late Years", ArtistBio = @"In 1997, Cash was diagnosed with the neurodegenerative disease Shy–Drager syndrome, a form of multiple system atrophy; according to biographer Robert Hilburn, the disease was originally misdiagnosed as Parkinson's disease, and Cash even announced to a concert audience that he had Parkinson's during a show in Flint, Michigan, on October 25, 1997, after he nearly collapsed on stage; soon after his diagnosis was changed to Shy–Drager and Cash was told he had approximately 18 months to live.[84] The diagnosis was later again altered to autonomic neuropathy associated with diabetes. The illness forced Cash to curtail his touring. He was hospitalized in 1998 with severe pneumonia, which damaged his lungs. Later, he released the albums American III: Solitary Man (2000) and American IV: The Man Comes Around (2002). The video for ""Hurt,"" a cover of the song by Nine Inch Nails, from American IV, received particular critical and popular acclaim[citation needed]. June Carter Cash died on May 15, 2003, at the age of 73.[85] June had told Cash to keep working, so he continued to record, completing 60 more songs in the last four months of his life, and even performed a couple of surprise shows at the Carter Family Fold outside Bristol, Virginia. At the July 5, 2003, concert (his last public performance), before singing ""Ring of Fire,"" Cash read a statement about his late wife that he had written shortly before taking the stage:
		//								The spirit of June Carter overshadows me tonight with the love she had for me and the love I have for her.We connect somewhere between here and heaven.She came down for a short visit, I guess, from heaven to visit with me tonight to give me courage and inspiration like she always has.
		//								Cash continued to record until shortly before his death.His final recordings were made on August 21, 2003, and consisted of ""Like the 309,"" which would appear on American V: A Hundred Highways in 2006, and the final song he completed, ""Engine 143,"" which was recorded for his son John Carter Cash for a planned Carter Family tribute album.[86]"},
		//		new Album(){ Artist = "Bill Withers", ReleaseDate = DateTime.Parse("1971-06-02"), Title = "Just As I Am", ArtistBio = @"Withers was inspired to write this song after watching the 1962 movie Days of Wine and Roses. He explained, in reference to the characters played by Lee Remick and Jack Lemmon, ""They were both alcoholics who were alternately weak and strong. It's like going back for seconds on rat poison. Sometimes you miss things that weren't particularly good for you.It's just something that crossed my mind from watching that movie, and probably something else that happened in my life that I'm not aware of.""[3]
		//					For the song's third verse, Withers had intended to write more lyrics instead of repeating the phrase ""I know"" 26 times, but then followed the advice of the other musicians to leave it that way: ""I was this factory worker puttering around,"" Withers said. ""So when they said to leave it like that, I left it.""[4]
		//					Withers, then thirty - one years old, was working at a factory making toilet seats for 747s at the time he wrote the song.[4] On the American Top 40 program of November 6, 1976, Casey Kasem reported that when the song went gold, the record company presented Withers with a golden toilet, marking the start of his new career.[citation needed] ""Ain't No Sunshine"" was the first of Withers' three gold records in the U.S.
		//					The song was originally released as the B - side to another song called ""Harlem"".Disc jockeys played ""Ain't No Sunshine"" as the single instead, and it became a huge hit,[3] the first for Withers.[4] ""Harlem"" was subsequently covered by The 5th Dimension, which was featured on their Soul and Inspiration album and released as a single.
		//					Withers performed the song on The Old Grey Whistle Test.[5]""Ain't No Sunshine"" is ranked 285th on Rolling Stone's list of the 500 Greatest Songs of All Time.[6] The song won the Grammy for Best R&B Song in 1972.[3]"}
		//	};
		//	album.ForEach(a => context.Album.AddOrUpdate(a));
		//	context.SaveChanges();

		//	var genreThree = new List<MusicGenre>
		//	{
		//		new MusicGenre() { GenreType = "Classic", Album = context.Album.Where(a => a.Id == 5).Single()},
		//		new MusicGenre() { GenreType = "Classic", Album = context.Album.Where(a => a.Id == 6).Single() },
		//		new MusicGenre() { GenreType = "Blues", Album = context.Album.Where(a => a.Id == 6).Single() }
		//	};
		//	genreThree.ForEach(g => context.MusicGenre.AddOrUpdate(g));
		//	context.SaveChanges();
		}
    }
}
