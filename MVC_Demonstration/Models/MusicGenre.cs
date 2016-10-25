using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Assignment4.Models
{
	public class MusicGenre
	{
		public int MusicGenreId { get; set; }
		[StringLength(50, MinimumLength = 1)]
		[Required]
		public string GenreType { get; set; }
		public virtual Album Album { get; set; }
	}
}