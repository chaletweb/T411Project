using System;
using Gtk;
using T411.Core;

namespace T411.GtkWin
{
	[TreeNode (ListOnly=true)]
	public class TorrentTreeNode : TreeNode
	{
		private Torrent torrent;

		public TorrentTreeNode (Torrent torrent)
		{
			this.torrent = torrent;
		}

		[TreeNodeValue (Column=0)]
		public string Name {get { return torrent.Name; } }

		[TreeNodeValue (Column=1)]
		public string Size {get { return torrent.Size; } }

		[TreeNodeValue (Column=2)]
		public string Seeders {get { return torrent.Seeders; } }

		[TreeNodeValue (Column=3)]
		public string Leechers {get { return torrent.Leechers; } }
			
	}
}

