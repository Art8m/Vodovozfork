
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.SidePanel.InfoViews
{
	public partial class CashInfoPanelView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HSeparator hseparatorTop;

		private global::Gtk.Label labelTitle;

		private global::Vodovoz.WrapLabel labelInfo;

		private global::Gtk.HSeparator hseparatorBottom;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.SidePanel.InfoViews.CashInfoPanelView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.SidePanel.InfoViews.CashInfoPanelView";
			// Container child Vodovoz.SidePanel.InfoViews.CashInfoPanelView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparatorTop = new global::Gtk.HSeparator();
			this.hseparatorTop.HeightRequest = 2;
			this.hseparatorTop.Name = "hseparatorTop";
			this.vbox1.Add(this.hseparatorTop);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparatorTop]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString("<u><b>Остатки по кассам:</b></u>");
			this.labelTitle.UseMarkup = true;
			this.vbox1.Add(this.labelTitle);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelTitle]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelInfo = new global::Vodovoz.WrapLabel();
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.LabelProp = global::Mono.Unix.Catalog.GetString("info");
			this.labelInfo.Selectable = true;
			this.vbox1.Add(this.labelInfo);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelInfo]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparatorBottom = new global::Gtk.HSeparator();
			this.hseparatorBottom.HeightRequest = 2;
			this.hseparatorBottom.Name = "hseparatorBottom";
			this.vbox1.Add(this.hseparatorBottom);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparatorBottom]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}