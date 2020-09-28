
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters
{
	public partial class CashBookReport
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label2;

		private global::QS.Widgets.GtkUI.DateRangePicker dateperiodpicker;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hboxCash;

		private global::Gtk.Label label7;

		private global::Gamma.Widgets.ySpecComboBox yspeccomboboxCashSubdivision;

		private global::Gtk.Button buttonCreateRepot;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.CashBookReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.CashBookReport";
			// Container child Vodovoz.ReportsParameters.CashBookReport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.WidthRequest = 50;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.hbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.dateperiodpicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker.Name = "dateperiodpicker";
			this.dateperiodpicker.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker.EndDate = new global::System.DateTime(0);
			this.hbox3.Add(this.dateperiodpicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.dateperiodpicker]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hboxCash = new global::Gtk.HBox();
			this.hboxCash.Name = "hboxCash";
			this.hboxCash.Spacing = 6;
			// Container child hboxCash.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Касса:");
			this.hboxCash.Add(this.label7);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxCash[this.label7]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hboxCash.Gtk.Box+BoxChild
			this.yspeccomboboxCashSubdivision = new global::Gamma.Widgets.ySpecComboBox();
			this.yspeccomboboxCashSubdivision.Name = "yspeccomboboxCashSubdivision";
			this.yspeccomboboxCashSubdivision.AddIfNotExist = false;
			this.yspeccomboboxCashSubdivision.DefaultFirst = false;
			this.yspeccomboboxCashSubdivision.ShowSpecialStateAll = false;
			this.yspeccomboboxCashSubdivision.ShowSpecialStateNot = false;
			this.hboxCash.Add(this.yspeccomboboxCashSubdivision);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxCash[this.yspeccomboboxCashSubdivision]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox2.Add(this.hboxCash);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hboxCash]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonCreateRepot = new global::Gtk.Button();
			this.buttonCreateRepot.CanFocus = true;
			this.buttonCreateRepot.Name = "buttonCreateRepot";
			this.buttonCreateRepot.UseUnderline = true;
			this.buttonCreateRepot.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox1.Add(this.buttonCreateRepot);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonCreateRepot]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
