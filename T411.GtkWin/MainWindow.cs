using System;
using Gtk;
using T411.GtkWin;
using T411.Core;

public partial class MainWindow: Gtk.Window
{
	private IApiConnector apiConnector;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		IAuthorization auth = new Authorization ();
		auth.Token = "7827821:168:3fab3eb05a3cbf1f120607cf2a5656a5";
		apiConnector = new ApiConnector (auth);

		Build ();

		searchEntry.KeyReleaseEvent += SearchEntry_KeyReleaseEvent;

		TorrentNodevView.AppendColumn("Name", new Gtk.CellRendererText (), "text", 0);
		TorrentNodevView.AppendColumn("Size", new Gtk.CellRendererText (), "text", 1);
		TorrentNodevView.AppendColumn("Seeders", new Gtk.CellRendererText (), "text", 2);
		TorrentNodevView.AppendColumn("Leechers", new Gtk.CellRendererText (), "text", 3);
		TorrentNodevView.ShowAll ();
	}

	void SearchEntry_KeyReleaseEvent (object o, KeyReleaseEventArgs args)
	{
		if (args.Event.Key == Gdk.Key.Return) 
		{
			var searchResult = apiConnector.SearchQuery (searchEntry.Text);
			var nodestore = new TorrentNodeStore ();
			nodestore.AddNode (searchResult.Torrents);

			TorrentNodevView.NodeStore = nodestore;

			TorrentNodevView.ShowAll ();
		}
	}
		
		

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
