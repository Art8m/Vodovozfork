
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class StockBalanceView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Vodovoz.StockBalanceFilter stockbalancefilter1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::QSOrmProject.RepresentationTreeView datatreeviewBalance;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.StockBalanceView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.StockBalanceView";
			// Container child Vodovoz.StockBalanceView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.stockbalancefilter1 = new global::Vodovoz.StockBalanceFilter ();
			this.stockbalancefilter1.Events = ((global::Gdk.EventMask)(256));
			this.stockbalancefilter1.Name = "stockbalancefilter1";
			this.hbox2.Add (this.stockbalancefilter1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.stockbalancefilter1]));
			w1.Position = 1;
			w1.Expand = false;
			w1.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.datatreeviewBalance = new global::QSOrmProject.RepresentationTreeView ();
			this.datatreeviewBalance.CanFocus = true;
			this.datatreeviewBalance.Name = "datatreeviewBalance";
			this.GtkScrolledWindow.Add (this.datatreeviewBalance);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w4.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
