using System;
using Newtonsoft.Json;

namespace T411.Core
{
	public class TorrentDetails
	{
		public string Id {get; set;}
		public string Name {get; set;}
		public string Category {get; set;}
		public string Categoryname {get; set;}
		public string Categoryimage {get; set;}
		public string Rewritename {get; set;}
		public string Owner {get; set;}
		public string Username {get; set;}
		public string Privacy {get; set;}
		public string Description {get; set;}
		public AdditionalInfo Terms {get; set;}

		public string Error { get; set;}
		public int Code { get; set;}
	}

	public class AdditionalInfo
	{
		public string Langue {get; set;}

		[JsonProperty("Jeu vidéo - Genre")]
		public string JeuVideoGenre {get; set;}

	}
}

