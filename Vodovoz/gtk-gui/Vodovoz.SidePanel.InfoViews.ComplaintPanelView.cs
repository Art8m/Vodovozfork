
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.SidePanel.InfoViews
{
	public partial class ComplaintPanelView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label lblUnclosedCount;

		private global::Gtk.Label lblCaption;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView yTVComplainsResults;

		private global::Gtk.Label lblResults;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView yTreeView;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.SidePanel.InfoViews.ComplaintPanelView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.SidePanel.InfoViews.ComplaintPanelView";
			// Container child Vodovoz.SidePanel.InfoViews.ComplaintPanelView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lblUnclosedCount = new global::Gtk.Label();
			this.lblUnclosedCount.Name = "lblUnclosedCount";
			this.lblUnclosedCount.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Не закрыто:</b>");
			this.lblUnclosedCount.UseMarkup = true;
			this.lblUnclosedCount.Justify = ((global::Gtk.Justification)(2));
			this.vbox1.Add(this.lblUnclosedCount);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblUnclosedCount]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lblCaption = new global::Gtk.Label();
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.LabelProp = global::Mono.Unix.Catalog.GetString("<u><b>За выбранный интервал\nдат в недовозах виновны:</b></u>");
			this.lblCaption.UseMarkup = true;
			this.lblCaption.Justify = ((global::Gtk.Justification)(2));
			this.vbox1.Add(this.lblCaption);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblCaption]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.yTVComplainsResults = new global::Gamma.GtkWidgets.yTreeView();
			this.yTVComplainsResults.CanFocus = true;
			this.yTVComplainsResults.Name = "yTVComplainsResults";
			this.GtkScrolledWindow1.Add(this.yTVComplainsResults);
			this.vbox1.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow1]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lblResults = new global::Gtk.Label();
			this.lblResults.Name = "lblResults";
			this.lblResults.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Итог работы (по закрытым жалобам)</b>");
			this.lblResults.UseMarkup = true;
			this.lblResults.Justify = ((global::Gtk.Justification)(2));
			this.vbox1.Add(this.lblResults);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblResults]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.yTreeView = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreeView.CanFocus = true;
			this.yTreeView.Name = "yTreeView";
			this.GtkScrolledWindow.Add(this.yTreeView);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 4;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
