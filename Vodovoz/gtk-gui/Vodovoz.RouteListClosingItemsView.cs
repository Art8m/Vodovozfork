
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RouteListClosingItemsView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewItems;

		private global::Gtk.Label GtkLabel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.RouteListClosingItemsView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.RouteListClosingItemsView";
			// Container child Vodovoz.RouteListClosingItemsView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewItems = new global::Gamma.GtkWidgets.yTreeView ();
			this.ytreeviewItems.CanFocus = true;
			this.ytreeviewItems.Events = ((global::Gdk.EventMask)(256));
			this.ytreeviewItems.Name = "ytreeviewItems";
			this.GtkScrolledWindow.Add (this.ytreeviewItems);
			this.GtkAlignment.Add (this.GtkScrolledWindow);
			this.frame2.Add (this.GtkAlignment);
			this.GtkLabel = new global::Gtk.Label ();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Заказы</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel;
			this.hbox3.Add (this.frame2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frame2]));
			w4.Position = 0;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w5.Position = 0;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.ytreeviewItems.RowActivated += new global::Gtk.RowActivatedHandler (this.OnYtreeviewItemsRowActivated);
			this.ytreeviewItems.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnYtreeviewItemsButtonPressEvent);
		}
	}
}
