
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ViewWidgets
{
	public partial class DeliveryPriceView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label8;

		private global::Gtk.Label labelMinBottles;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label2;

		private global::Gtk.Label labelPrice;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label10;

		private global::Gtk.Label lblDistrict;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label11;

		private global::Gamma.GtkWidgets.yTextView yTxtWarehouses;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label9;

		private global::Gamma.GtkWidgets.yTextView ytextviewSchedule;

		private global::Gtk.HBox hboxTreeView;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewPrices;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ViewWidgets.DeliveryPriceView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ViewWidgets.DeliveryPriceView";
			// Container child Vodovoz.ViewWidgets.DeliveryPriceView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Минимальное\nколичество:");
			this.label8.Justify = ((global::Gtk.Justification)(1));
			this.hbox3.Add(this.label8);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label8]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelMinBottles = new global::Gtk.Label();
			this.labelMinBottles.Name = "labelMinBottles";
			this.hbox3.Add(this.labelMinBottles);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelMinBottles]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Цена на бутыль:");
			this.hbox5.Add(this.label2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.labelPrice = new global::Gtk.Label();
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.LabelProp = global::Mono.Unix.Catalog.GetString("По прайсу");
			this.labelPrice.Selectable = true;
			this.hbox5.Add(this.labelPrice);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.labelPrice]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox2.Add(this.hbox5);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Район дост.:");
			this.label10.Justify = ((global::Gtk.Justification)(1));
			this.hbox4.Add(this.label10);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label10]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.lblDistrict = new global::Gtk.Label();
			this.lblDistrict.Name = "lblDistrict";
			this.lblDistrict.LabelProp = global::Mono.Unix.Catalog.GetString("Unknown");
			this.hbox4.Add(this.lblDistrict);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.lblDistrict]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Часть гор.:");
			this.label11.Justify = ((global::Gtk.Justification)(1));
			this.hbox7.Add(this.label11);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label11]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.yTxtWarehouses = new global::Gamma.GtkWidgets.yTextView();
			this.yTxtWarehouses.CanFocus = true;
			this.yTxtWarehouses.Name = "yTxtWarehouses";
			this.yTxtWarehouses.Editable = false;
			this.yTxtWarehouses.AcceptsTab = false;
			this.yTxtWarehouses.WrapMode = ((global::Gtk.WrapMode)(2));
			this.hbox7.Add(this.yTxtWarehouses);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.yTxtWarehouses]));
			w11.Position = 1;
			this.vbox2.Add(this.hbox7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox7]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("График доставки:");
			this.hbox6.Add(this.label9);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label9]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox2.Add(this.hbox6);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox6]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.ytextviewSchedule = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewSchedule.CanFocus = true;
			this.ytextviewSchedule.Name = "ytextviewSchedule";
			this.ytextviewSchedule.Editable = false;
			this.ytextviewSchedule.AcceptsTab = false;
			this.ytextviewSchedule.WrapMode = ((global::Gtk.WrapMode)(2));
			this.vbox2.Add(this.ytextviewSchedule);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.ytextviewSchedule]));
			w15.Position = 5;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hboxTreeView = new global::Gtk.HBox();
			this.hboxTreeView.Name = "hboxTreeView";
			this.hboxTreeView.Spacing = 6;
			// Container child hboxTreeView.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewPrices = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewPrices.HeightRequest = 300;
			this.ytreeviewPrices.CanFocus = true;
			this.ytreeviewPrices.Name = "ytreeviewPrices";
			this.GtkScrolledWindow.Add(this.ytreeviewPrices);
			this.hboxTreeView.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hboxTreeView[this.GtkScrolledWindow]));
			w17.Position = 0;
			this.vbox2.Add(this.hboxTreeView);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hboxTreeView]));
			w18.Position = 6;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
