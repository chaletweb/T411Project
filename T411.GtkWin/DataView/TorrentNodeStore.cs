using System;
using Gtk;
using T411.Core;
using System.Linq;

namespace T411.GtkWin
{
	public class TorrentNodeStore : NodeStore
	{
		public TorrentNodeStore() : base(typeof(TorrentTreeNode))
		{
			
		}

		public void AddNode(Torrent[] torrents)
		{
			torrents.ToList ().ForEach (x => this.AddNode(new TorrentTreeNode(x))); 
		}
	}
}

