
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters
{
	public partial class PotentialFreePromosetsReport
	{
		private global::Gtk.VBox vboxMainMastersReport;

		private global::Gtk.HBox hboxPeriod;

		private global::Gtk.Label labelPeriod;

		private global::QS.Widgets.GtkUI.DateRangePicker dateperiodpicker;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeview1;

		private global::Gtk.Button buttonCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.PotentialFreePromosetsReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.PotentialFreePromosetsReport";
			// Container child Vodovoz.ReportsParameters.PotentialFreePromosetsReport.Gtk.Container+ContainerChild
			this.vboxMainMastersReport = new global::Gtk.VBox();
			this.vboxMainMastersReport.Name = "vboxMainMastersReport";
			this.vboxMainMastersReport.Spacing = 6;
			// Container child vboxMainMastersReport.Gtk.Box+BoxChild
			this.hboxPeriod = new global::Gtk.HBox();
			this.hboxPeriod.Name = "hboxPeriod";
			this.hboxPeriod.Spacing = 6;
			// Container child hboxPeriod.Gtk.Box+BoxChild
			this.labelPeriod = new global::Gtk.Label();
			this.labelPeriod.Name = "labelPeriod";
			this.labelPeriod.Xalign = 0F;
			this.labelPeriod.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.hboxPeriod.Add(this.labelPeriod);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxPeriod[this.labelPeriod]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hboxPeriod.Gtk.Box+BoxChild
			this.dateperiodpicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker.Name = "dateperiodpicker";
			this.dateperiodpicker.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker.EndDate = new global::System.DateTime(0);
			this.hboxPeriod.Add(this.dateperiodpicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxPeriod[this.dateperiodpicker]));
			w2.Position = 1;
			this.vboxMainMastersReport.Add(this.hboxPeriod);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxMainMastersReport[this.hboxPeriod]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vboxMainMastersReport.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeview1 = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeview1.CanFocus = true;
			this.ytreeview1.Name = "ytreeview1";
			this.GtkScrolledWindow.Add(this.ytreeview1);
			this.vboxMainMastersReport.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxMainMastersReport[this.GtkScrolledWindow]));
			w5.Position = 1;
			// Container child vboxMainMastersReport.Gtk.Box+BoxChild
			this.buttonCreateReport = new global::Gtk.Button();
			this.buttonCreateReport.CanFocus = true;
			this.buttonCreateReport.Name = "buttonCreateReport";
			this.buttonCreateReport.UseUnderline = true;
			this.buttonCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vboxMainMastersReport.Add(this.buttonCreateReport);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxMainMastersReport[this.buttonCreateReport]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vboxMainMastersReport);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}