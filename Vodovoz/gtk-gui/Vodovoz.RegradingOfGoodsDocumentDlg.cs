
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RegradingOfGoodsDocumentDlg
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table tableWriteoff;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView ytextviewCommnet;

		private global::Gtk.Label label1;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gamma.Widgets.yEntryReference yentryrefWarehouse;

		private global::Gamma.GtkWidgets.yLabel ylabelDate;

		private global::Vodovoz.RegradingOfGoodsDocumentItemsView regradingofgoodsitemsview;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.RegradingOfGoodsDocumentDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.RegradingOfGoodsDocumentDlg";
			// Container child Vodovoz.RegradingOfGoodsDocumentDlg.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(6));
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox5.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox5.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox4.Add (this.hbox5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox5]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.tableWriteoff = new global::Gtk.Table (((uint)(2)), ((uint)(4)), false);
			this.tableWriteoff.Name = "tableWriteoff";
			this.tableWriteoff.RowSpacing = ((uint)(6));
			this.tableWriteoff.ColumnSpacing = ((uint)(6));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewCommnet = new global::Gamma.GtkWidgets.yTextView ();
			this.ytextviewCommnet.CanFocus = true;
			this.ytextviewCommnet.Name = "ytextviewCommnet";
			this.GtkScrolledWindow.Add (this.ytextviewCommnet);
			this.tableWriteoff.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableWriteoff [this.GtkScrolledWindow]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.tableWriteoff.Add (this.label1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableWriteoff [this.label1]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Склад:");
			this.tableWriteoff.Add (this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableWriteoff [this.label4]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.Yalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Комментарий:");
			this.tableWriteoff.Add (this.label5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableWriteoff [this.label5]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.yentryrefWarehouse = new global::Gamma.Widgets.yEntryReference ();
			this.yentryrefWarehouse.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefWarehouse.Name = "yentryrefWarehouse";
			this.tableWriteoff.Add (this.yentryrefWarehouse);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableWriteoff [this.yentryrefWarehouse]));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.ylabelDate = new global::Gamma.GtkWidgets.yLabel ();
			this.ylabelDate.Name = "ylabelDate";
			this.ylabelDate.LabelProp = global::Mono.Unix.Catalog.GetString ("ylabel1");
			this.tableWriteoff.Add (this.ylabelDate);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableWriteoff [this.ylabelDate]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.tableWriteoff);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.tableWriteoff]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.regradingofgoodsitemsview = new global::Vodovoz.RegradingOfGoodsDocumentItemsView ();
			this.regradingofgoodsitemsview.Events = ((global::Gdk.EventMask)(256));
			this.regradingofgoodsitemsview.Name = "regradingofgoodsitemsview";
			this.vbox4.Add (this.regradingofgoodsitemsview);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.regradingofgoodsitemsview]));
			w14.Position = 2;
			this.Add (this.vbox4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
		}
	}
}
