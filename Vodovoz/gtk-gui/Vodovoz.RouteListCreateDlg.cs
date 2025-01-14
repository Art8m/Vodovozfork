
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RouteListCreateDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Table dataRouteList;

		private global::QS.Widgets.GtkUI.DatePicker datepickerDate;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entityviewmodelentryCar;

		private global::Vodovoz.ViewWidgets.GeographicGroupsToStringWidget ggToStringWidget;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.HBox hboxCash;

		private global::Gamma.GtkWidgets.yLabel labelTerminalCondition;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Label label7;

		private global::Gamma.Widgets.ySpecComboBox yspeccomboboxCashSubdivision;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HSeparator hseparator3;

		private global::Gtk.Label label1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label9;

		private global::Gamma.GtkWidgets.yLabel labelStatus;

		private global::Vodovoz.ViewWidgets.Mango.EmployeePhone phoneDriver;

		private global::Vodovoz.ViewWidgets.Mango.EmployeePhone phoneForwarder;

		private global::Vodovoz.ViewWidgets.Mango.EmployeePhone phoneLogistican;

		private global::QS.Widgets.GtkUI.RepresentationEntry referenceDriver;

		private global::QS.Widgets.GtkUI.RepresentationEntry referenceForwarder;

		private global::QS.Widgets.GtkUI.RepresentationEntry referenceLogistican;

		private global::Gamma.Widgets.ySpecComboBox speccomboShift;

		private global::Vodovoz.RouteListCreateItemsView createroutelistitemsview1;

		private global::Gtk.HBox hbox9;

		private global::Gamma.GtkWidgets.yButton printTimeButton;

		private global::QS.Widgets.EnumMenuButton enumPrint;

		private global::Gtk.Button buttonAccept;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.RouteListCreateDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.RouteListCreateDlg";
			// Container child Vodovoz.RouteListCreateDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.dataRouteList = new global::Gtk.Table(((uint)(6)), ((uint)(7)), false);
			this.dataRouteList.Name = "dataRouteList";
			this.dataRouteList.RowSpacing = ((uint)(6));
			this.dataRouteList.ColumnSpacing = ((uint)(6));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.datepickerDate = new global::QS.Widgets.GtkUI.DatePicker();
			this.datepickerDate.Events = ((global::Gdk.EventMask)(256));
			this.datepickerDate.Name = "datepickerDate";
			this.datepickerDate.WithTime = false;
			this.datepickerDate.HideCalendarButton = false;
			this.datepickerDate.Date = new global::System.DateTime(0);
			this.datepickerDate.IsEditable = true;
			this.datepickerDate.AutoSeparation = true;
			this.dataRouteList.Add(this.datepickerDate);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.datepickerDate]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.entityviewmodelentryCar = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entityviewmodelentryCar.Events = ((global::Gdk.EventMask)(256));
			this.entityviewmodelentryCar.Name = "entityviewmodelentryCar";
			this.entityviewmodelentryCar.CanEditReference = true;
			this.dataRouteList.Add(this.entityviewmodelentryCar);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.entityviewmodelentryCar]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(5));
			w2.RightAttach = ((uint)(6));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.ggToStringWidget = new global::Vodovoz.ViewWidgets.GeographicGroupsToStringWidget();
			this.ggToStringWidget.Events = ((global::Gdk.EventMask)(256));
			this.ggToStringWidget.Name = "ggToStringWidget";
			this.dataRouteList.Add(this.ggToStringWidget);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.ggToStringWidget]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w4;
			this.hbox7.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonSave]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отмена");
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w6;
			this.hbox7.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonCancel]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.dataRouteList.Add(this.hbox7);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.hbox7]));
			w8.XOptions = ((global::Gtk.AttachOptions)(0));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hboxCash = new global::Gtk.HBox();
			this.hboxCash.Name = "hboxCash";
			this.hboxCash.Spacing = 6;
			// Container child hboxCash.Gtk.Box+BoxChild
			this.labelTerminalCondition = new global::Gamma.GtkWidgets.yLabel();
			this.labelTerminalCondition.Name = "labelTerminalCondition";
			this.labelTerminalCondition.LabelProp = global::Mono.Unix.Catalog.GetString("Состояние терминала: ");
			this.hboxCash.Add(this.labelTerminalCondition);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxCash[this.labelTerminalCondition]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hboxCash.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hboxCash.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxCash[this.vseparator1]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hboxCash.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Сдается в кассу:");
			this.hboxCash.Add(this.label7);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxCash[this.label7]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hboxCash.Gtk.Box+BoxChild
			this.yspeccomboboxCashSubdivision = new global::Gamma.Widgets.ySpecComboBox();
			this.yspeccomboboxCashSubdivision.Name = "yspeccomboboxCashSubdivision";
			this.yspeccomboboxCashSubdivision.AddIfNotExist = false;
			this.yspeccomboboxCashSubdivision.DefaultFirst = false;
			this.yspeccomboboxCashSubdivision.ShowSpecialStateAll = false;
			this.yspeccomboboxCashSubdivision.ShowSpecialStateNot = false;
			this.hboxCash.Add(this.yspeccomboboxCashSubdivision);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hboxCash[this.yspeccomboboxCashSubdivision]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			this.dataRouteList.Add(this.hboxCash);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.hboxCash]));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(0));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.dataRouteList.Add(this.hseparator2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.hseparator2]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.RightAttach = ((uint)(6));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator();
			this.hseparator3.Name = "hseparator3";
			this.dataRouteList.Add(this.hseparator3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.hseparator3]));
			w15.TopAttach = ((uint)(5));
			w15.BottomAttach = ((uint)(6));
			w15.RightAttach = ((uint)(6));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Смена:");
			this.dataRouteList.Add(this.label1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label1]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Логист:");
			this.dataRouteList.Add(this.label10);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label10]));
			w17.LeftAttach = ((uint)(4));
			w17.RightAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.dataRouteList.Add(this.label2);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label2]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Водитель:");
			this.dataRouteList.Add(this.label3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label3]));
			w19.TopAttach = ((uint)(3));
			w19.BottomAttach = ((uint)(4));
			w19.LeftAttach = ((uint)(4));
			w19.RightAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Машина:");
			this.dataRouteList.Add(this.label4);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label4]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(4));
			w20.RightAttach = ((uint)(5));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Состояние:");
			this.dataRouteList.Add(this.label5);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label5]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Экспедитор:");
			this.dataRouteList.Add(this.label9);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.label9]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.LeftAttach = ((uint)(4));
			w22.RightAttach = ((uint)(5));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.labelStatus = new global::Gamma.GtkWidgets.yLabel();
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Xalign = 0F;
			this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString("--");
			this.dataRouteList.Add(this.labelStatus);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.labelStatus]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.phoneDriver = new global::Vodovoz.ViewWidgets.Mango.EmployeePhone();
			this.phoneDriver.CanFocus = true;
			this.phoneDriver.Name = "phoneDriver";
			this.phoneDriver.UseUnderline = true;
			this.phoneDriver.UseMarkup = false;
			this.phoneDriver.LabelXAlign = 0F;
			this.dataRouteList.Add(this.phoneDriver);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.phoneDriver]));
			w24.TopAttach = ((uint)(3));
			w24.BottomAttach = ((uint)(4));
			w24.LeftAttach = ((uint)(6));
			w24.RightAttach = ((uint)(7));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.phoneForwarder = new global::Vodovoz.ViewWidgets.Mango.EmployeePhone();
			this.phoneForwarder.CanFocus = true;
			this.phoneForwarder.Name = "phoneForwarder";
			this.phoneForwarder.UseUnderline = true;
			this.phoneForwarder.UseMarkup = false;
			this.phoneForwarder.LabelXAlign = 0F;
			this.dataRouteList.Add(this.phoneForwarder);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.phoneForwarder]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.LeftAttach = ((uint)(6));
			w25.RightAttach = ((uint)(7));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.phoneLogistican = new global::Vodovoz.ViewWidgets.Mango.EmployeePhone();
			this.phoneLogistican.CanFocus = true;
			this.phoneLogistican.Name = "phoneLogistican";
			this.phoneLogistican.UseUnderline = true;
			this.phoneLogistican.UseMarkup = false;
			this.phoneLogistican.LabelXAlign = 0F;
			this.dataRouteList.Add(this.phoneLogistican);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.phoneLogistican]));
			w26.LeftAttach = ((uint)(6));
			w26.RightAttach = ((uint)(7));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceDriver = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.referenceDriver.Events = ((global::Gdk.EventMask)(256));
			this.referenceDriver.Name = "referenceDriver";
			this.dataRouteList.Add(this.referenceDriver);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.referenceDriver]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.LeftAttach = ((uint)(5));
			w27.RightAttach = ((uint)(6));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceForwarder = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.referenceForwarder.Events = ((global::Gdk.EventMask)(256));
			this.referenceForwarder.Name = "referenceForwarder";
			this.dataRouteList.Add(this.referenceForwarder);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.referenceForwarder]));
			w28.TopAttach = ((uint)(4));
			w28.BottomAttach = ((uint)(5));
			w28.LeftAttach = ((uint)(5));
			w28.RightAttach = ((uint)(6));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceLogistican = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.referenceLogistican.Events = ((global::Gdk.EventMask)(256));
			this.referenceLogistican.Name = "referenceLogistican";
			this.dataRouteList.Add(this.referenceLogistican);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.referenceLogistican]));
			w29.LeftAttach = ((uint)(5));
			w29.RightAttach = ((uint)(6));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.speccomboShift = new global::Gamma.Widgets.ySpecComboBox();
			this.speccomboShift.Name = "speccomboShift";
			this.speccomboShift.AddIfNotExist = false;
			this.speccomboShift.DefaultFirst = false;
			this.speccomboShift.ShowSpecialStateAll = false;
			this.speccomboShift.ShowSpecialStateNot = true;
			this.dataRouteList.Add(this.speccomboShift);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.dataRouteList[this.speccomboShift]));
			w30.TopAttach = ((uint)(3));
			w30.BottomAttach = ((uint)(4));
			w30.LeftAttach = ((uint)(3));
			w30.RightAttach = ((uint)(4));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.dataRouteList);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.dataRouteList]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.createroutelistitemsview1 = new global::Vodovoz.RouteListCreateItemsView();
			this.createroutelistitemsview1.HeightRequest = 150;
			this.createroutelistitemsview1.Events = ((global::Gdk.EventMask)(256));
			this.createroutelistitemsview1.Name = "createroutelistitemsview1";
			this.createroutelistitemsview1.DisableColumnsUpdate = false;
			this.vbox1.Add(this.createroutelistitemsview1);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.createroutelistitemsview1]));
			w32.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.printTimeButton = new global::Gamma.GtkWidgets.yButton();
			this.printTimeButton.CanFocus = true;
			this.printTimeButton.Name = "printTimeButton";
			this.printTimeButton.UseUnderline = true;
			this.printTimeButton.Label = global::Mono.Unix.Catalog.GetString("Время печати МЛ");
			this.hbox9.Add(this.printTimeButton);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.printTimeButton]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.enumPrint = new global::QS.Widgets.EnumMenuButton();
			this.enumPrint.CanFocus = true;
			this.enumPrint.Name = "enumPrint";
			this.enumPrint.UseUnderline = true;
			this.enumPrint.UseMarkup = false;
			this.enumPrint.LabelXAlign = 0F;
			this.enumPrint.Label = global::Mono.Unix.Catalog.GetString("Распечатать");
			global::Gtk.Image w34 = new global::Gtk.Image();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.enumPrint.Image = w34;
			this.hbox9.Add(this.enumPrint);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.enumPrint]));
			w35.PackType = ((global::Gtk.PackType)(1));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.buttonAccept = new global::Gtk.Button();
			this.buttonAccept.CanFocus = true;
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.UseUnderline = true;
			this.buttonAccept.Label = global::Mono.Unix.Catalog.GetString("Подтвердить");
			global::Gtk.Image w36 = new global::Gtk.Image();
			w36.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.buttonAccept.Image = w36;
			this.hbox9.Add(this.buttonAccept);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.buttonAccept]));
			w37.PackType = ((global::Gtk.PackType)(1));
			w37.Position = 3;
			w37.Expand = false;
			w37.Fill = false;
			this.vbox1.Add(this.hbox9);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox9]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonAccept.Clicked += new global::System.EventHandler(this.OnButtonAcceptClicked);
		}
	}
}
