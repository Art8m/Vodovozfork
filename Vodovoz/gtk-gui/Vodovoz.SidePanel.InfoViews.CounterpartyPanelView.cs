
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.SidePanel.InfoViews
{
	public partial class CounterpartyPanelView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSaveComment;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textviewComment;

		private global::Gtk.Label label5;

		private global::Gtk.VBox vboxCurrentOrders;

		private global::Gtk.Label label2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView ytreeCurrentOrders;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelLatestOrderDate;

		private global::Gtk.Label label4;

		private global::Gtk.Table table1;

		private global::Gtk.Button btnAddPhone;

		private global::Gtk.Label label3;

		private global::Vodovoz.WrapLabel labelDebt;

		private global::Vodovoz.WrapLabel labelName;

		private global::Vodovoz.WrapLabel labelPhone;

		private global::Gamma.GtkWidgets.yLabel ylabelDebtInfo;

		private global::Gtk.Table PhonesTable;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.SidePanel.InfoViews.CounterpartyPanelView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.SidePanel.InfoViews.CounterpartyPanelView";
			// Container child Vodovoz.SidePanel.InfoViews.CounterpartyPanelView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<u><b>Контрагент</b></u>");
			this.label1.UseMarkup = true;
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSaveComment = new global::Gtk.Button();
			this.buttonSaveComment.CanFocus = true;
			this.buttonSaveComment.Name = "buttonSaveComment";
			this.buttonSaveComment.UseUnderline = true;
			this.buttonSaveComment.Label = global::Mono.Unix.Catalog.GetString("Сохранить комментарий");
			global::Gtk.Image w2 = new global::Gtk.Image();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.buttonSaveComment.Image = w2;
			this.hbox1.Add(this.buttonSaveComment);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSaveComment]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewComment = new global::Gtk.TextView();
			this.textviewComment.CanFocus = true;
			this.textviewComment.Name = "textviewComment";
			this.textviewComment.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow.Add(this.textviewComment);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Комментарий:</b>");
			this.label5.UseMarkup = true;
			this.vbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label5]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxCurrentOrders = new global::Gtk.VBox();
			this.vboxCurrentOrders.Name = "vboxCurrentOrders";
			this.vboxCurrentOrders.Spacing = 6;
			// Container child vboxCurrentOrders.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Оформленные заказы:</b>");
			this.label2.UseMarkup = true;
			this.vboxCurrentOrders.Add(this.label2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxCurrentOrders[this.label2]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vboxCurrentOrders.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytreeCurrentOrders = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeCurrentOrders.CanFocus = true;
			this.ytreeCurrentOrders.Name = "ytreeCurrentOrders";
			this.GtkScrolledWindow1.Add(this.ytreeCurrentOrders);
			this.vboxCurrentOrders.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxCurrentOrders[this.GtkScrolledWindow1]));
			w10.Position = 1;
			this.vbox1.Add(this.vboxCurrentOrders);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxCurrentOrders]));
			w11.PackType = ((global::Gtk.PackType)(1));
			w11.Position = 5;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.hbox2.Add(this.label6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label6]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelLatestOrderDate = new global::Gtk.Label();
			this.labelLatestOrderDate.Name = "labelLatestOrderDate";
			this.labelLatestOrderDate.Selectable = true;
			this.hbox2.Add(this.labelLatestOrderDate);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelLatestOrderDate]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 6;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Последний заказ:</b>");
			this.label4.UseMarkup = true;
			this.label4.Wrap = true;
			this.label4.Justify = ((global::Gtk.Justification)(1));
			this.vbox1.Add(this.label4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
			w15.PackType = ((global::Gtk.PackType)(1));
			w15.Position = 7;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.btnAddPhone = new global::Gtk.Button();
			this.btnAddPhone.CanFocus = true;
			this.btnAddPhone.Name = "btnAddPhone";
			this.btnAddPhone.UseUnderline = true;
			global::Gtk.Image w16 = new global::Gtk.Image();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.btnAddPhone.Image = w16;
			this.table1.Add(this.btnAddPhone);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.btnAddPhone]));
			w17.LeftAttach = ((uint)(2));
			w17.RightAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("ФИО:");
			this.label3.UseMarkup = true;
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelDebt = new global::Vodovoz.WrapLabel();
			this.labelDebt.Name = "labelDebt";
			this.labelDebt.Xalign = 0F;
			this.labelDebt.Yalign = 0F;
			this.labelDebt.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel3");
			this.labelDebt.Wrap = true;
			this.labelDebt.Selectable = true;
			this.table1.Add(this.labelDebt);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.labelDebt]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(3));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelName = new global::Vodovoz.WrapLabel();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 0F;
			this.labelName.Yalign = 0F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.labelName.Wrap = true;
			this.labelName.Selectable = true;
			this.table1.Add(this.labelName);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.labelName]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(3));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPhone = new global::Vodovoz.WrapLabel();
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.LabelProp = global::Mono.Unix.Catalog.GetString("Щёлкните чтоб добавить телефон-->");
			this.table1.Add(this.labelPhone);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.labelPhone]));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabelDebtInfo = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelDebtInfo.Name = "ylabelDebtInfo";
			this.ylabelDebtInfo.LabelProp = global::Mono.Unix.Catalog.GetString("Долг(по клиенту):");
			this.table1.Add(this.ylabelDebtInfo);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabelDebtInfo]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w23.PackType = ((global::Gtk.PackType)(1));
			w23.Position = 8;
			// Container child vbox1.Gtk.Box+BoxChild
			this.PhonesTable = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.PhonesTable.Name = "PhonesTable";
			this.PhonesTable.RowSpacing = ((uint)(6));
			this.PhonesTable.ColumnSpacing = ((uint)(6));
			this.vbox1.Add(this.PhonesTable);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.PhonesTable]));
			w24.PackType = ((global::Gtk.PackType)(1));
			w24.Position = 9;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.label2.Hide();
			this.ytreeCurrentOrders.Hide();
			this.GtkScrolledWindow1.Hide();
			this.label6.Hide();
			this.labelLatestOrderDate.Hide();
			this.label4.Hide();
			this.Hide();
			this.btnAddPhone.Clicked += new global::System.EventHandler(this.OnBtnAddPhoneClicked);
			this.buttonSaveComment.Clicked += new global::System.EventHandler(this.OnButtonSaveCommentClicked);
		}
	}
}
