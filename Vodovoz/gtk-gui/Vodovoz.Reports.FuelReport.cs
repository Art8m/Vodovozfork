
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Reports
{
	public partial class FuelReport
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::QSWidgetLib.DatePeriodPicker dateperiodpicker;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VBox vbox2;

		private global::Gtk.RadioButton radioDriver;

		private global::Gtk.RadioButton radioCar;

		private global::Gtk.RadioButton radioSumm;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hboxDriver;

		private global::Gtk.Label labelDriver;

		private global::Gamma.Widgets.yEntryReferenceVM yentryreferenceDriver;

		private global::Gtk.HBox hboxCar;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.yEntryReference yentryreferenceCar;

		private global::Gtk.HBox hboxAuthor;

		private global::Gtk.Label labelAuthor;

		private global::Gamma.Widgets.yEntryReferenceVM yentryAuthor;

		private global::Gtk.Button buttonCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Reports.FuelReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Reports.FuelReport";
			// Container child Vodovoz.Reports.FuelReport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.dateperiodpicker = new global::QSWidgetLib.DatePeriodPicker();
			this.dateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker.Name = "dateperiodpicker";
			this.dateperiodpicker.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker.EndDate = new global::System.DateTime(0);
			this.hbox1.Add(this.dateperiodpicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.dateperiodpicker]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioDriver = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Баланс по водителям"));
			this.radioDriver.CanFocus = true;
			this.radioDriver.Name = "radioDriver";
			this.radioDriver.DrawIndicator = true;
			this.radioDriver.UseUnderline = true;
			this.radioDriver.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.vbox2.Add(this.radioDriver);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radioDriver]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioCar = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Баланс по автомобилям"));
			this.radioCar.CanFocus = true;
			this.radioCar.Name = "radioCar";
			this.radioCar.DrawIndicator = true;
			this.radioCar.UseUnderline = true;
			this.radioCar.Group = this.radioDriver.Group;
			this.vbox2.Add(this.radioCar);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radioCar]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioSumm = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Суммарный отчет по топливу"));
			this.radioSumm.CanFocus = true;
			this.radioSumm.Name = "radioSumm";
			this.radioSumm.DrawIndicator = true;
			this.radioSumm.UseUnderline = true;
			this.radioSumm.Group = this.radioDriver.Group;
			this.vbox2.Add(this.radioSumm);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radioSumm]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox5.Add(this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox2]));
			w7.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.hbox5.Add(this.vbox3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox3]));
			w8.Position = 1;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxDriver = new global::Gtk.HBox();
			this.hboxDriver.Name = "hboxDriver";
			this.hboxDriver.Spacing = 6;
			// Container child hboxDriver.Gtk.Box+BoxChild
			this.labelDriver = new global::Gtk.Label();
			this.labelDriver.Name = "labelDriver";
			this.labelDriver.LabelProp = global::Mono.Unix.Catalog.GetString("Водитель:");
			this.hboxDriver.Add(this.labelDriver);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxDriver[this.labelDriver]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hboxDriver.Gtk.Box+BoxChild
			this.yentryreferenceDriver = new global::Gamma.Widgets.yEntryReferenceVM();
			this.yentryreferenceDriver.Events = ((global::Gdk.EventMask)(256));
			this.yentryreferenceDriver.Name = "yentryreferenceDriver";
			this.hboxDriver.Add(this.yentryreferenceDriver);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxDriver[this.yentryreferenceDriver]));
			w11.Position = 1;
			this.vbox1.Add(this.hboxDriver);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxDriver]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxCar = new global::Gtk.HBox();
			this.hboxCar.Name = "hboxCar";
			this.hboxCar.Spacing = 6;
			// Container child hboxCar.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Автомобиль:");
			this.hboxCar.Add(this.label2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxCar[this.label2]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hboxCar.Gtk.Box+BoxChild
			this.yentryreferenceCar = new global::Gamma.Widgets.yEntryReference();
			this.yentryreferenceCar.Events = ((global::Gdk.EventMask)(256));
			this.yentryreferenceCar.Name = "yentryreferenceCar";
			this.hboxCar.Add(this.yentryreferenceCar);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxCar[this.yentryreferenceCar]));
			w14.Position = 1;
			this.vbox1.Add(this.hboxCar);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxCar]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxAuthor = new global::Gtk.HBox();
			this.hboxAuthor.Name = "hboxAuthor";
			this.hboxAuthor.Spacing = 6;
			// Container child hboxAuthor.Gtk.Box+BoxChild
			this.labelAuthor = new global::Gtk.Label();
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.LabelProp = global::Mono.Unix.Catalog.GetString("Автор:");
			this.hboxAuthor.Add(this.labelAuthor);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hboxAuthor[this.labelAuthor]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hboxAuthor.Gtk.Box+BoxChild
			this.yentryAuthor = new global::Gamma.Widgets.yEntryReferenceVM();
			this.yentryAuthor.Events = ((global::Gdk.EventMask)(256));
			this.yentryAuthor.Name = "yentryAuthor";
			this.hboxAuthor.Add(this.yentryAuthor);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hboxAuthor[this.yentryAuthor]));
			w17.Position = 1;
			this.vbox1.Add(this.hboxAuthor);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxAuthor]));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonCreateReport = new global::Gtk.Button();
			this.buttonCreateReport.CanFocus = true;
			this.buttonCreateReport.Name = "buttonCreateReport";
			this.buttonCreateReport.UseUnderline = true;
			this.buttonCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox1.Add(this.buttonCreateReport);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonCreateReport]));
			w19.Position = 6;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.hboxCar.Hide();
			this.hboxAuthor.Hide();
			this.Hide();
			this.radioDriver.Toggled += new global::System.EventHandler(this.OnRadioDriverToggled);
			this.radioCar.Toggled += new global::System.EventHandler(this.OnRadioCarToggled);
			this.radioSumm.Toggled += new global::System.EventHandler(this.OnRadioSummToggled);
			this.buttonCreateReport.Clicked += new global::System.EventHandler(this.OnButtonCreateReportClicked);
		}
	}
}
