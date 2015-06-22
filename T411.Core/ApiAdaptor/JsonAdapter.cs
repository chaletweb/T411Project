using System;
using Newtonsoft.Json;

namespace T411.Core
{
	public static class JsonAdapter
	{
		public static Authorization GetAuthorisation(string response)
		{
			var auth = JsonConvert.DeserializeObject<Authorization> (response);
			return auth;
		}

		public static SearchResult GetSearch(string response)
		{
			var search = JsonConvert.DeserializeObject<SearchResult> (response);
			return search;
		}

		public static TorrentDetails GetDetail(string response)
		{
			var detail = JsonConvert.DeserializeObject<TorrentDetails> (response);
			return detail;
		}

		public static SearchResult GetTorrents(string response)
		{
			Torrent[] torrents;
			SearchResult search;
			try
			{
				search = new SearchResult ();
				torrents = JsonConvert.DeserializeObject<Torrent[]> (response);
				search.Torrents = torrents;

			}
			catch(JsonException) 
			{
				search = JsonConvert.DeserializeObject<SearchResult> (response);
			}
				

			return search;
		}
	}
}

