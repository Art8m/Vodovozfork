
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RoutesAtDayDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Label label1;
		
		private global::Gamma.Widgets.yDatePicker ydateForRoutes;
		
		private global::Gtk.HBox hbox1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.RoutesAtDayDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.RoutesAtDayDlg";
			// Container child Vodovoz.RoutesAtDayDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ydateForRoutes = new global::Gamma.Widgets.yDatePicker ();
			this.ydateForRoutes.Events = ((global::Gdk.EventMask)(256));
			this.ydateForRoutes.Name = "ydateForRoutes";
			this.ydateForRoutes.WithTime = false;
			this.ydateForRoutes.Date = new global::System.DateTime (0);
			this.ydateForRoutes.IsEditable = false;
			this.ydateForRoutes.AutoSeparation = false;
			this.table1.Add (this.ydateForRoutes);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.ydateForRoutes]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w3.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w4.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
