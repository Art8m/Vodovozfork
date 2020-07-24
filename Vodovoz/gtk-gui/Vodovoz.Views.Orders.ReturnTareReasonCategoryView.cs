
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Orders
{
	public partial class ReturnTareReasonCategoryView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.yButton ybtnSave;

		private global::Gamma.GtkWidgets.yButton ybtnCancel;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Table table2;

		private global::Gtk.Label lblCategory;

		private global::Gamma.GtkWidgets.yEntry yentryReturnTareReasonCategoryName;

		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewReasons;

		private global::Gtk.HBox hbox2;

		private global::Gamma.GtkWidgets.yButton ybtnAddReason;

		private global::Gamma.GtkWidgets.yButton ybtnRemoveReason;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Orders.ReturnTareReasonCategoryView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Orders.ReturnTareReasonCategoryView";
			// Container child Vodovoz.Views.Orders.ReturnTareReasonCategoryView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ybtnSave = new global::Gamma.GtkWidgets.yButton();
			this.ybtnSave.CanFocus = true;
			this.ybtnSave.Name = "ybtnSave";
			this.ybtnSave.UseUnderline = true;
			this.ybtnSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.ybtnSave.Image = w1;
			this.hbox1.Add(this.ybtnSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ybtnSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ybtnCancel = new global::Gamma.GtkWidgets.yButton();
			this.ybtnCancel.CanFocus = true;
			this.ybtnCancel.Name = "ybtnCancel";
			this.ybtnCancel.UseUnderline = true;
			this.ybtnCancel.Label = global::Mono.Unix.Catalog.GetString("Отмена");
			this.hbox1.Add(this.ybtnCancel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ybtnCancel]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.lblCategory = new global::Gtk.Label();
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Xalign = 1F;
			this.lblCategory.LabelProp = global::Mono.Unix.Catalog.GetString("Категория забора тары: ");
			this.table2.Add(this.lblCategory);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.lblCategory]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.yentryReturnTareReasonCategoryName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryReturnTareReasonCategoryName.CanFocus = true;
			this.yentryReturnTareReasonCategoryName.Name = "yentryReturnTareReasonCategoryName";
			this.yentryReturnTareReasonCategoryName.IsEditable = true;
			this.yentryReturnTareReasonCategoryName.InvisibleChar = '•';
			this.table2.Add(this.yentryReturnTareReasonCategoryName);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.yentryReturnTareReasonCategoryName]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table2]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewReasons = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewReasons.CanFocus = true;
			this.ytreeviewReasons.Name = "ytreeviewReasons";
			this.GtkScrolledWindow.Add(this.ytreeviewReasons);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w10.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ybtnAddReason = new global::Gamma.GtkWidgets.yButton();
			this.ybtnAddReason.CanFocus = true;
			this.ybtnAddReason.Name = "ybtnAddReason";
			this.ybtnAddReason.UseUnderline = true;
			this.ybtnAddReason.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			this.hbox2.Add(this.ybtnAddReason);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ybtnAddReason]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ybtnRemoveReason = new global::Gamma.GtkWidgets.yButton();
			this.ybtnRemoveReason.CanFocus = true;
			this.ybtnRemoveReason.Name = "ybtnRemoveReason";
			this.ybtnRemoveReason.UseUnderline = true;
			this.ybtnRemoveReason.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			this.hbox2.Add(this.ybtnRemoveReason);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ybtnRemoveReason]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
			w14.Position = 2;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
