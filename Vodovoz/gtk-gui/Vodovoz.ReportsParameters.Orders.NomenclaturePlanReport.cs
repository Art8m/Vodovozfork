
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters.Orders
{
	public partial class NomenclaturePlanReport
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Label label3;

		private global::QSWidgetLib.DatePeriodPicker dateperiodReportDate;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Table table1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow3;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewSelectedEmployees;

		private global::Gtk.HSeparator hseparator3;

		private global::Gtk.HSeparator hseparator5;

		private global::Gtk.HSeparator hseparator6;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label4;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VBox vbox15;

		private global::Gtk.Table table4;

		private global::Gamma.Widgets.yEnumComboBox enumType;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::QS.Widgets.GtkUI.RepresentationEntry yentryProductGroup;

		private global::Gtk.HBox hbox6;

		private global::QSWidgetLib.SearchEntity searchentityNomenclature;

		private global::Gtk.Label label11;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewNomenclatures;

		private global::Gtk.VBox vbox10;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.VBox vbox11;

		private global::Gtk.VBox vbox12;

		private global::Gtk.Label label14;

		private global::Gtk.Button btnNomenclatureAdd;

		private global::Gtk.Button btnNomenclatureDelete;

		private global::Gtk.Label label15;

		private global::Gtk.VBox vbox13;

		private global::Gtk.VBox vbox14;

		private global::Gtk.Label label16;

		private global::Gtk.Button btnEmployeeAdd;

		private global::Gtk.Button btnEmployeeDelete;

		private global::Gtk.Label label17;

		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewSelectedNomenclatures;

		private global::Gamma.GtkWidgets.yButton ybuttonSave;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Label label9;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label13;

		private global::Gtk.VBox vbox8;

		private global::Gamma.Widgets.ySpecComboBox ycmbxSubdivision;

		private global::QSWidgetLib.SearchEntity searchentityEmployee;

		private global::Gtk.Label label12;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewEmployees;

		private global::Gtk.VBox vbox9;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.VSeparator vseparator4;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.Button buttonCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.Orders.NomenclaturePlanReport
			global::Stetic.BinContainer.Attach(this);
			this.WidthRequest = 800;
			this.Name = "Vodovoz.ReportsParameters.Orders.NomenclaturePlanReport";
			// Container child Vodovoz.ReportsParameters.Orders.NomenclaturePlanReport.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.hbox11.Add(this.label3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.label3]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.dateperiodReportDate = new global::QSWidgetLib.DatePeriodPicker();
			this.dateperiodReportDate.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodReportDate.Name = "dateperiodReportDate";
			this.dateperiodReportDate.StartDate = new global::System.DateTime(0);
			this.dateperiodReportDate.EndDate = new global::System.DateTime(0);
			this.hbox11.Add(this.dateperiodReportDate);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.dateperiodReportDate]));
			w2.Position = 1;
			this.vbox4.Add(this.hbox11);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox11]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox4.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(5)), false);
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
            this.GtkScrolledWindow3.WidthRequest = 350;
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.ytreeviewSelectedEmployees = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewSelectedEmployees.WidthRequest = 350;
			this.ytreeviewSelectedEmployees.CanFocus = true;
			this.ytreeviewSelectedEmployees.Name = "ytreeviewSelectedEmployees";
			this.GtkScrolledWindow3.Add(this.ytreeviewSelectedEmployees);
			this.table1.Add(this.GtkScrolledWindow3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow3]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(4));
			w6.RightAttach = ((uint)(5));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator();
			this.hseparator3.Name = "hseparator3";
			this.table1.Add(this.hseparator3);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator3]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator5 = new global::Gtk.HSeparator();
			this.hseparator5.Name = "hseparator5";
			this.table1.Add(this.hseparator5);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator5]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(4));
			w8.RightAttach = ((uint)(5));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hseparator6 = new global::Gtk.HSeparator();
			this.hseparator6.Name = "hseparator6";
			this.table1.Add(this.hseparator6);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.hseparator6]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("ТМЦ");
			this.vbox1.Add(this.label4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.enumType = new global::Gamma.Widgets.yEnumComboBox();
			this.enumType.Name = "enumType";
			this.enumType.ShowSpecialStateAll = false;
			this.enumType.ShowSpecialStateNot = false;
			this.enumType.UseShortTitle = false;
			this.enumType.DefaultFirst = true;
			this.table4.Add(this.enumType);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table4[this.enumType]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Тип:");
			this.table4.Add(this.label6);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table4[this.label6]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Группа:");
			this.table4.Add(this.label7);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table4[this.label7]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.yentryProductGroup = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.yentryProductGroup.Events = ((global::Gdk.EventMask)(256));
			this.yentryProductGroup.Name = "yentryProductGroup";
			this.table4.Add(this.yentryProductGroup);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table4[this.yentryProductGroup]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox15.Add(this.table4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.table4]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			this.hbox4.Add(this.vbox15);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox15]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.searchentityNomenclature = new global::QSWidgetLib.SearchEntity();
			this.searchentityNomenclature.Events = ((global::Gdk.EventMask)(256));
			this.searchentityNomenclature.Name = "searchentityNomenclature";
			this.hbox6.Add(this.searchentityNomenclature);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.searchentityNomenclature]));
			w18.Position = 0;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Номенклатура");
			this.vbox1.Add(this.label11);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label11]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
            this.GtkScrolledWindow.WidthRequest = 200;
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewNomenclatures = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewNomenclatures.WidthRequest = 200;
			this.ytreeviewNomenclatures.HeightRequest = 200;
			this.ytreeviewNomenclatures.CanFocus = true;
			this.ytreeviewNomenclatures.Name = "ytreeviewNomenclatures";
			this.GtkScrolledWindow.Add(this.ytreeviewNomenclatures);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w22.Position = 4;
			this.table1.Add(this.vbox1);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox1]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox10 = new global::Gtk.VBox();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.Name = "vseparator3";
			this.vbox10.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.vseparator3]));
			w24.Position = 0;
			this.table1.Add(this.vbox10);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox10]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.vbox12.Add(this.label14);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label14]));
			w26.Position = 0;
			w26.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.btnNomenclatureAdd = new global::Gtk.Button();
			this.btnNomenclatureAdd.CanFocus = true;
			this.btnNomenclatureAdd.Name = "btnNomenclatureAdd";
			this.btnNomenclatureAdd.UseUnderline = true;
			global::Gtk.Image w27 = new global::Gtk.Image();
			w27.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", global::Gtk.IconSize.Button);
			this.btnNomenclatureAdd.Image = w27;
			this.vbox12.Add(this.btnNomenclatureAdd);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.btnNomenclatureAdd]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.btnNomenclatureDelete = new global::Gtk.Button();
			this.btnNomenclatureDelete.CanFocus = true;
			this.btnNomenclatureDelete.Name = "btnNomenclatureDelete";
			this.btnNomenclatureDelete.UseUnderline = true;
			global::Gtk.Image w29 = new global::Gtk.Image();
			w29.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-back", global::Gtk.IconSize.Button);
			this.btnNomenclatureDelete.Image = w29;
			this.vbox12.Add(this.btnNomenclatureDelete);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.btnNomenclatureDelete]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.vbox12.Add(this.label15);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label15]));
			w31.Position = 3;
			w31.Fill = false;
			this.vbox11.Add(this.vbox12);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.vbox12]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			this.table1.Add(this.vbox11);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox11]));
			w33.LeftAttach = ((uint)(2));
			w33.RightAttach = ((uint)(3));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(1));
			// Container child table1.Gtk.Table+TableChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.vbox14.Add(this.label16);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label16]));
			w34.Position = 0;
			w34.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.btnEmployeeAdd = new global::Gtk.Button();
			this.btnEmployeeAdd.CanFocus = true;
			this.btnEmployeeAdd.Name = "btnEmployeeAdd";
			this.btnEmployeeAdd.UseUnderline = true;
			global::Gtk.Image w35 = new global::Gtk.Image();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", global::Gtk.IconSize.Button);
			this.btnEmployeeAdd.Image = w35;
			this.vbox14.Add(this.btnEmployeeAdd);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.btnEmployeeAdd]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.btnEmployeeDelete = new global::Gtk.Button();
			this.btnEmployeeDelete.CanFocus = true;
			this.btnEmployeeDelete.Name = "btnEmployeeDelete";
			this.btnEmployeeDelete.UseUnderline = true;
			global::Gtk.Image w37 = new global::Gtk.Image();
			w37.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-go-back", global::Gtk.IconSize.Button);
			this.btnEmployeeDelete.Image = w37;
			this.vbox14.Add(this.btnEmployeeDelete);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.btnEmployeeDelete]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.vbox14.Add(this.label17);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label17]));
			w39.Position = 3;
			w39.Fill = false;
			this.vbox13.Add(this.vbox14);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.vbox14]));
			w40.Position = 0;
			w40.Expand = false;
			w40.Fill = false;
			this.table1.Add(this.vbox13);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox13]));
			w41.TopAttach = ((uint)(2));
			w41.BottomAttach = ((uint)(3));
			w41.LeftAttach = ((uint)(2));
			w41.RightAttach = ((uint)(3));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(1));
			// Container child table1.Gtk.Table+TableChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
            this.GtkScrolledWindow2.WidthRequest = 350;
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ytreeviewSelectedNomenclatures = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewSelectedNomenclatures.WidthRequest = 350;
			this.ytreeviewSelectedNomenclatures.CanFocus = true;
			this.ytreeviewSelectedNomenclatures.Name = "ytreeviewSelectedNomenclatures";
			this.GtkScrolledWindow2.Add(this.ytreeviewSelectedNomenclatures);
			this.vbox2.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow2]));
			w43.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.ybuttonSave = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonSave.CanFocus = true;
			this.ybuttonSave.Name = "ybuttonSave";
			this.ybuttonSave.UseUnderline = true;
			this.ybuttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить по умолчанию");
			this.vbox2.Add(this.ybuttonSave);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.ybuttonSave]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.table1.Add(this.vbox2);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox2]));
			w45.LeftAttach = ((uint)(4));
			w45.RightAttach = ((uint)(5));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Сотрудники");
			this.vbox6.Add(this.label9);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label9]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Подразделение:");
			this.hbox7.Add(this.label13);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label13]));
			w47.Position = 0;
			w47.Expand = false;
			w47.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.ycmbxSubdivision = new global::Gamma.Widgets.ySpecComboBox();
            this.ycmbxSubdivision.Name = "ycmbxSubdivision";
			this.ycmbxSubdivision.AddIfNotExist = false;
			this.ycmbxSubdivision.DefaultFirst = false;
			this.ycmbxSubdivision.ShowSpecialStateAll = false;
			this.ycmbxSubdivision.ShowSpecialStateNot = false;
			this.vbox8.Add(this.ycmbxSubdivision);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.ycmbxSubdivision]));
			w48.Position = 0;
			w48.Expand = false;
			w48.Fill = false;
			this.hbox7.Add(this.vbox8);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vbox8]));
			w49.Position = 1;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox6.Add(this.hbox7);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox7]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.searchentityEmployee = new global::QSWidgetLib.SearchEntity();
			this.searchentityEmployee.Events = ((global::Gdk.EventMask)(256));
			this.searchentityEmployee.Name = "searchentityEmployee";
			this.vbox6.Add(this.searchentityEmployee);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.searchentityEmployee]));
			w51.Position = 2;
			w51.Expand = false;
			w51.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Сотрудники");
			this.vbox6.Add(this.label12);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label12]));
			w52.Position = 3;
			w52.Expand = false;
			w52.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
            this.GtkScrolledWindow1.WidthRequest = 200;
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytreeviewEmployees = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewEmployees.WidthRequest = 200;
			this.ytreeviewEmployees.HeightRequest = 200;
			this.ytreeviewEmployees.CanFocus = true;
			this.ytreeviewEmployees.Name = "ytreeviewEmployees";
			this.GtkScrolledWindow1.Add(this.ytreeviewEmployees);
			this.vbox6.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow1]));
			w54.Position = 4;
			this.table1.Add(this.vbox6);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox6]));
			w55.TopAttach = ((uint)(2));
			w55.BottomAttach = ((uint)(3));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.Name = "vseparator6";
			this.vbox9.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.vseparator6]));
			w56.Position = 0;
			this.table1.Add(this.vbox9);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table1[this.vbox9]));
			w57.LeftAttach = ((uint)(1));
			w57.RightAttach = ((uint)(2));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vseparator4 = new global::Gtk.VSeparator();
			this.vseparator4.Name = "vseparator4";
			this.table1.Add(this.vseparator4);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table1[this.vseparator4]));
			w58.LeftAttach = ((uint)(3));
			w58.RightAttach = ((uint)(4));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vseparator5 = new global::Gtk.VSeparator();
			this.vseparator5.Name = "vseparator5";
			this.table1.Add(this.vseparator5);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table1[this.vseparator5]));
			w59.TopAttach = ((uint)(2));
			w59.BottomAttach = ((uint)(3));
			w59.LeftAttach = ((uint)(3));
			w59.RightAttach = ((uint)(4));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add(this.table1);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.table1]));
			w60.Position = 2;
			w60.Expand = false;
			w60.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.buttonCreateReport = new global::Gtk.Button();
			this.buttonCreateReport.CanFocus = true;
			this.buttonCreateReport.Name = "buttonCreateReport";
			this.buttonCreateReport.UseUnderline = true;
			this.buttonCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox4.Add(this.buttonCreateReport);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonCreateReport]));
			w61.Position = 3;
			w61.Expand = false;
			w61.Fill = false;
			this.Add(this.vbox4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
