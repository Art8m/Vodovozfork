
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class CarLoadDocumentDlg
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::QSOrmProject.EnumMenuButton enumPrint;

		private global::Gtk.Table tableWriteoff;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView ytextviewCommnet;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTextView ytextviewRouteListInfo;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gamma.Widgets.yEntryReferenceVM yentryrefRouteList;

		private global::Gamma.Widgets.yEntryReference yentryrefWarehouse;

		private global::Gamma.GtkWidgets.yLabel ylabelDate;

		private global::Gtk.HBox hbox4;

		private global::Vodovoz.CarLoadDocumentView carloaddocumentview1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.CarLoadDocumentDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.CarLoadDocumentDlg";
			// Container child Vodovoz.CarLoadDocumentDlg.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(6));
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox5.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox5.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.enumPrint = new global::QSOrmProject.EnumMenuButton();
			this.enumPrint.CanFocus = true;
			this.enumPrint.Name = "enumPrint";
			this.enumPrint.UseUnderline = true;
			this.enumPrint.UseMarkup = false;
			this.enumPrint.Label = global::Mono.Unix.Catalog.GetString("Печать");
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.enumPrint.Image = w5;
			this.hbox5.Add(this.enumPrint);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.enumPrint]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox5]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.tableWriteoff = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
			this.tableWriteoff.Name = "tableWriteoff";
			this.tableWriteoff.RowSpacing = ((uint)(6));
			this.tableWriteoff.ColumnSpacing = ((uint)(6));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewCommnet = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewCommnet.WidthRequest = 250;
			this.ytextviewCommnet.CanFocus = true;
			this.ytextviewCommnet.Name = "ytextviewCommnet";
			this.GtkScrolledWindow.Add(this.ytextviewCommnet);
			this.tableWriteoff.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.GtkScrolledWindow]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytextviewRouteListInfo = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewRouteListInfo.CanFocus = true;
			this.ytextviewRouteListInfo.Name = "ytextviewRouteListInfo";
			this.ytextviewRouteListInfo.Editable = false;
			this.GtkScrolledWindow1.Add(this.ytextviewRouteListInfo);
			this.tableWriteoff.Add(this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.GtkScrolledWindow1]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.tableWriteoff.Add(this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.label1]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Маршрутный лист:");
			this.tableWriteoff.Add(this.label2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.label2]));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Информация:");
			this.tableWriteoff.Add(this.label3);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.label3]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Склад:");
			this.tableWriteoff.Add(this.label4);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.label4]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.Yalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарий:");
			this.tableWriteoff.Add(this.label5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.label5]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.yentryrefRouteList = new global::Gamma.Widgets.yEntryReferenceVM();
			this.yentryrefRouteList.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefRouteList.Name = "yentryrefRouteList";
			this.tableWriteoff.Add(this.yentryrefRouteList);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.yentryrefRouteList]));
			w17.LeftAttach = ((uint)(3));
			w17.RightAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.yentryrefWarehouse = new global::Gamma.Widgets.yEntryReference();
			this.yentryrefWarehouse.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefWarehouse.Name = "yentryrefWarehouse";
			this.tableWriteoff.Add(this.yentryrefWarehouse);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.yentryrefWarehouse]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child tableWriteoff.Gtk.Table+TableChild
			this.ylabelDate = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelDate.Name = "ylabelDate";
			this.ylabelDate.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel1");
			this.tableWriteoff.Add(this.ylabelDate);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.tableWriteoff[this.ylabelDate]));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add(this.tableWriteoff);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.tableWriteoff]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.carloaddocumentview1 = new global::Vodovoz.CarLoadDocumentView();
			this.carloaddocumentview1.Events = ((global::Gdk.EventMask)(256));
			this.carloaddocumentview1.Name = "carloaddocumentview1";
			this.hbox4.Add(this.carloaddocumentview1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.carloaddocumentview1]));
			w21.Position = 0;
			this.vbox4.Add(this.hbox4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
			w22.Position = 2;
			this.Add(this.vbox4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.enumPrint.EnumItemClicked += new global::System.EventHandler<QSOrmProject.EnumItemClickedEventArgs>(this.OnEnumPrintEnumItemClicked);
			this.yentryrefWarehouse.ChangedByUser += new global::System.EventHandler(this.OnYentryrefWarehouseChangedByUser);
			this.yentryrefRouteList.ChangedByUser += new global::System.EventHandler(this.OnYentryrefRouteListChangedByUser);
		}
	}
}
