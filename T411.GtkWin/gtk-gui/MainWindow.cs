
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HPaned hpaned1;
	
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Entry searchEntry;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.NodeView TorrentNodevView;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 165;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.searchEntry = new global::Gtk.Entry ();
		this.searchEntry.CanFocus = true;
		this.searchEntry.Name = "searchEntry";
		this.searchEntry.IsEditable = true;
		this.searchEntry.InvisibleChar = '●';
		this.fixed1.Add (this.searchEntry);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.searchEntry]));
		w1.X = 4;
		w1.Y = 12;
		this.hpaned1.Add (this.fixed1);
		global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.fixed1]));
		w2.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.TorrentNodevView = new global::Gtk.NodeView ();
		this.TorrentNodevView.CanFocus = true;
		this.TorrentNodevView.Name = "TorrentNodevView";
		this.TorrentNodevView.Reorderable = true;
		this.TorrentNodevView.SearchColumn = 0;
		this.GtkScrolledWindow.Add (this.TorrentNodevView);
		this.hpaned1.Add (this.GtkScrolledWindow);
		this.Add (this.hpaned1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 500;
		this.DefaultHeight = 468;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}