using System;
using System.Collections.Generic;

namespace T411.Core
{
	public class SearchResult
	{
		public string Query { get; set;}
		public int Total { get; set;}
		public int Offset { get; set;}
		public int Limit { get; set;}
		public Torrent[] Torrents { get; set;}

		public string Error { get; set;}
		public int Code { get; set;}
	}
}

