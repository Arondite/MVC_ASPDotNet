using System;
using MVC_Assignment4.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assignment4.ViewModels
{
	public class ArtistGenre
	{
		public string Artist { get; set; }
		public IEnumerable<MusicGenre> Genre { get; set; }
	}
}