
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RouteListTrackDlg
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::QSOrmProject.RepresentationTreeView yTreeViewDrivers;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonChat;

		private global::Gtk.VBox vboxRight;

		private global::Gtk.Label label2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::QSOrmProject.RepresentationTreeView yTreeAddresses;

		private global::Gtk.HBox hbox3;

		private global::Gtk.ToggleButton toggleButtonHideAddresses;

		private global::Gtk.Button buttonCleanTrack;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboMapType;

		private global::Gtk.Button buttonMapInWindow;

		private global::GMap.NET.GtkSharp.GMapControl gmapWidget;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.RouteListTrackDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.RouteListTrackDlg";
			// Container child Vodovoz.RouteListTrackDlg.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Водители в пути");
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.yTreeViewDrivers = new global::QSOrmProject.RepresentationTreeView ();
			this.yTreeViewDrivers.WidthRequest = 500;
			this.yTreeViewDrivers.CanFocus = true;
			this.yTreeViewDrivers.Name = "yTreeViewDrivers";
			this.GtkScrolledWindow.Add (this.yTreeViewDrivers);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w3.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonChat = new global::Gtk.Button ();
			this.buttonChat.CanFocus = true;
			this.buttonChat.Name = "buttonChat";
			this.buttonChat.UseUnderline = true;
			this.buttonChat.Label = global::Mono.Unix.Catalog.GetString ("Открыть чат");
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("chat-icon.png");
			this.buttonChat.Image = w4;
			this.hbox2.Add (this.buttonChat);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonChat]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxRight = new global::Gtk.VBox ();
			this.vboxRight.Name = "vboxRight";
			this.vboxRight.Spacing = 6;
			// Container child vboxRight.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Список адресов");
			this.vboxRight.Add (this.label2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.label2]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child vboxRight.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.yTreeAddresses = new global::QSOrmProject.RepresentationTreeView ();
			this.yTreeAddresses.WidthRequest = 600;
			this.yTreeAddresses.HeightRequest = 150;
			this.yTreeAddresses.CanFocus = true;
			this.yTreeAddresses.Name = "yTreeAddresses";
			this.GtkScrolledWindow1.Add (this.yTreeAddresses);
			this.vboxRight.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.GtkScrolledWindow1]));
			w10.Position = 1;
			// Container child vboxRight.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.toggleButtonHideAddresses = new global::Gtk.ToggleButton ();
			this.toggleButtonHideAddresses.TooltipMarkup = "Скрыть\\показать адреса.";
			this.toggleButtonHideAddresses.CanFocus = true;
			this.toggleButtonHideAddresses.Name = "toggleButtonHideAddresses";
			this.toggleButtonHideAddresses.UseUnderline = true;
			this.toggleButtonHideAddresses.Label = global::Mono.Unix.Catalog.GetString ("⇧⇩");
			this.hbox3.Add (this.toggleButtonHideAddresses);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.toggleButtonHideAddresses]));
			w11.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonCleanTrack = new global::Gtk.Button ();
			this.buttonCleanTrack.Sensitive = false;
			this.buttonCleanTrack.CanFocus = true;
			this.buttonCleanTrack.Name = "buttonCleanTrack";
			this.buttonCleanTrack.UseUnderline = true;
			this.buttonCleanTrack.Label = global::Mono.Unix.Catalog.GetString ("Убрать трек");
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.buttonCleanTrack.Image = w12;
			this.hbox3.Add (this.buttonCleanTrack);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonCleanTrack]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.yenumcomboMapType = new global::Gamma.Widgets.yEnumComboBox ();
			this.yenumcomboMapType.Name = "yenumcomboMapType";
			this.yenumcomboMapType.ShowSpecialStateAll = false;
			this.yenumcomboMapType.ShowSpecialStateNot = false;
			this.yenumcomboMapType.UseShortTitle = false;
			this.yenumcomboMapType.DefaultFirst = true;
			this.hbox3.Add (this.yenumcomboMapType);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.yenumcomboMapType]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonMapInWindow = new global::Gtk.Button ();
			this.buttonMapInWindow.CanFocus = true;
			this.buttonMapInWindow.Name = "buttonMapInWindow";
			this.buttonMapInWindow.UseUnderline = true;
			this.buttonMapInWindow.Label = global::Mono.Unix.Catalog.GetString ("Карта в окне");
			global::Gtk.Image w15 = new global::Gtk.Image ();
			w15.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Vodovoz.icons.buttons.window-new.png");
			this.buttonMapInWindow.Image = w15;
			this.hbox3.Add (this.buttonMapInWindow);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonMapInWindow]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			this.vboxRight.Add (this.hbox3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.hbox3]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vboxRight.Gtk.Box+BoxChild
			this.gmapWidget = new global::GMap.NET.GtkSharp.GMapControl ();
			this.gmapWidget.Name = "gmapWidget";
			this.gmapWidget.MaxZoom = 24;
			this.gmapWidget.MinZoom = 0;
			this.gmapWidget.MouseWheelZoomEnabled = true;
			this.gmapWidget.ShowTileGridLines = false;
			this.gmapWidget.GrayScaleMode = false;
			this.gmapWidget.NegativeMode = false;
			this.gmapWidget.HasFrame = false;
			this.gmapWidget.Bearing = 0F;
			this.gmapWidget.Zoom = 9;
			this.gmapWidget.RoutesEnabled = true;
			this.gmapWidget.PolygonsEnabled = false;
			this.gmapWidget.MarkersEnabled = true;
			this.gmapWidget.CanDragMap = true;
			this.vboxRight.Add (this.gmapWidget);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vboxRight [this.gmapWidget]));
			w18.Position = 3;
			this.hbox1.Add (this.vboxRight);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vboxRight]));
			w19.Position = 1;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.yTreeViewDrivers.RowActivated += new global::Gtk.RowActivatedHandler (this.OnYTreeViewDriversRowActivated);
			this.buttonChat.Clicked += new global::System.EventHandler (this.OnButtonChatClicked);
			this.toggleButtonHideAddresses.Toggled += new global::System.EventHandler (this.OnToggleButtonHideAddressesToggled);
			this.buttonCleanTrack.Clicked += new global::System.EventHandler (this.OnButtonCleanTrackClicked);
			this.yenumcomboMapType.ChangedByUser += new global::System.EventHandler (this.OnYenumcomboMapTypeChangedByUser);
			this.buttonMapInWindow.Clicked += new global::System.EventHandler (this.OnButtonMapInWindowClicked);
		}
	}
}
