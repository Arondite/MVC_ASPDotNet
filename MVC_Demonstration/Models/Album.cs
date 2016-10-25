using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment4.Models
{
	public class Album
	{
		public int Id { get; set; }
		[Required]
		public string Artist { get; set; }
		[Display(Name = "Album's Title")]
		public string Title { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = true)]
		[Display(Name = "Album's Release Date")]
		public DateTime ReleaseDate { get; set; }
		[Display(Name = "Biography of Album")]
		public string ArtistBio { get; set; }

		public ICollection<MusicGenre> MusicGenre { get; set; }
	}
}