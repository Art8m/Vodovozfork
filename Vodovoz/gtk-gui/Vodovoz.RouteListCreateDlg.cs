
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RouteListCreateDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.DataBindings.DataTable dataRouteList;
		
		private global::QSOrmProject.DataDatePicker datepickerDate;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.HSeparator hseparator2;
		
		private global::Gtk.HSeparator hseparator3;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.DataBindings.DataLabel labelStatus;
		
		private global::Gtk.DataBindings.DataEntryReference referenceCar;
		
		private global::Gtk.DataBindings.DataEntryReference referenceDriver;
		
		private global::Gtk.DataBindings.DataEntryReference referenceForwarder;
		
		private global::Gtk.DataBindings.DataEntryReference referenceLogistican;
		
		private global::Gtk.DataBindings.DataSpecComboBox speccomboShift;
		
		private global::Gtk.DataBindings.DataSpinButton spinActualDistance;
		
		private global::Gtk.DataBindings.DataSpinButton spinPlannedDistance;
		
		private global::Vodovoz.RouteListCreateItemsView createroutelistitemsview1;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Button buttonPrint;
		
		private global::Gtk.Button buttonAccept;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.RouteListCreateDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.RouteListCreateDlg";
			// Container child Vodovoz.RouteListCreateDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.dataRouteList = new global::Gtk.DataBindings.DataTable (((uint)(8)), ((uint)(4)), false);
			this.dataRouteList.Name = "dataRouteList";
			this.dataRouteList.RowSpacing = ((uint)(6));
			this.dataRouteList.ColumnSpacing = ((uint)(6));
			this.dataRouteList.InheritedDataSource = false;
			this.dataRouteList.InheritedBoundaryDataSource = false;
			this.dataRouteList.InheritedDataSource = false;
			this.dataRouteList.InheritedBoundaryDataSource = false;
			// Container child dataRouteList.Gtk.Table+TableChild
			this.datepickerDate = new global::QSOrmProject.DataDatePicker ();
			this.datepickerDate.Events = ((global::Gdk.EventMask)(256));
			this.datepickerDate.Name = "datepickerDate";
			this.datepickerDate.Date = new global::System.DateTime (0);
			this.datepickerDate.IsEditable = true;
			this.datepickerDate.AutoSeparation = false;
			this.datepickerDate.InheritedDataSource = true;
			this.datepickerDate.Mappings = "Date";
			this.datepickerDate.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.datepickerDate);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.datepickerDate]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w2 = new global::Gtk.Image ();
			w2.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w2;
			this.hbox7.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonSave]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отмена");
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w4;
			this.hbox7.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonCancel]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.dataRouteList.Add (this.hbox7);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.hbox7]));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.dataRouteList.Add (this.hseparator2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.hseparator2]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.RightAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.dataRouteList.Add (this.hseparator3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.hseparator3]));
			w8.TopAttach = ((uint)(5));
			w8.BottomAttach = ((uint)(6));
			w8.RightAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Смена:");
			this.dataRouteList.Add (this.label1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label1]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Логист:");
			this.dataRouteList.Add (this.label10);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label10]));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.dataRouteList.Add (this.label2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label2]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Водитель:");
			this.dataRouteList.Add (this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label3]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Машина:");
			this.dataRouteList.Add (this.label4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label4]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Состояние:");
			this.dataRouteList.Add (this.label5);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label5]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Планируемое:");
			this.dataRouteList.Add (this.label6);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label6]));
			w15.TopAttach = ((uint)(7));
			w15.BottomAttach = ((uint)(8));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Фактическое:");
			this.dataRouteList.Add (this.label7);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label7]));
			w16.TopAttach = ((uint)(7));
			w16.BottomAttach = ((uint)(8));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Расстояние");
			this.dataRouteList.Add (this.label8);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label8]));
			w17.TopAttach = ((uint)(6));
			w17.BottomAttach = ((uint)(7));
			w17.RightAttach = ((uint)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Экспедитор:");
			this.dataRouteList.Add (this.label9);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label9]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.LeftAttach = ((uint)(2));
			w18.RightAttach = ((uint)(3));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.labelStatus = new global::Gtk.DataBindings.DataLabel ();
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Xalign = 0F;
			this.labelStatus.UseMarkup = true;
			this.labelStatus.InheritedDataSource = true;
			this.labelStatus.Mappings = "Status";
			this.labelStatus.InheritedBoundaryDataSource = false;
			this.labelStatus.Important = false;
			this.labelStatus.InheritedDataSource = true;
			this.labelStatus.Mappings = "Status";
			this.labelStatus.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.labelStatus);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.labelStatus]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceCar = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceCar.Events = ((global::Gdk.EventMask)(256));
			this.referenceCar.Name = "referenceCar";
			this.referenceCar.DisplayFields = new string[] {
				"Model",
				"RegistrationNumber"
			};
			this.referenceCar.DisplayFormatString = "{0} {1}";
			this.referenceCar.InheritedDataSource = true;
			this.referenceCar.Mappings = "Car";
			this.referenceCar.InheritedBoundaryDataSource = false;
			this.referenceCar.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.referenceCar);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.referenceCar]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(3));
			w20.RightAttach = ((uint)(4));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceDriver = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceDriver.Events = ((global::Gdk.EventMask)(256));
			this.referenceDriver.Name = "referenceDriver";
			this.referenceDriver.DisplayFormatString = "";
			this.referenceDriver.InheritedDataSource = true;
			this.referenceDriver.Mappings = "Driver";
			this.referenceDriver.InheritedBoundaryDataSource = false;
			this.referenceDriver.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.referenceDriver);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.referenceDriver]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.LeftAttach = ((uint)(3));
			w21.RightAttach = ((uint)(4));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceForwarder = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceForwarder.Events = ((global::Gdk.EventMask)(256));
			this.referenceForwarder.Name = "referenceForwarder";
			this.referenceForwarder.InheritedDataSource = true;
			this.referenceForwarder.InheritedBoundaryDataSource = false;
			this.referenceForwarder.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.referenceForwarder);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.referenceForwarder]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.LeftAttach = ((uint)(3));
			w22.RightAttach = ((uint)(4));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceLogistican = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceLogistican.Events = ((global::Gdk.EventMask)(256));
			this.referenceLogistican.Name = "referenceLogistican";
			this.referenceLogistican.InheritedDataSource = true;
			this.referenceLogistican.InheritedBoundaryDataSource = false;
			this.referenceLogistican.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.referenceLogistican);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.referenceLogistican]));
			w23.LeftAttach = ((uint)(3));
			w23.RightAttach = ((uint)(4));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.speccomboShift = new global::Gtk.DataBindings.DataSpecComboBox ();
			this.speccomboShift.Name = "speccomboShift";
			this.speccomboShift.InheritedDataSource = true;
			this.speccomboShift.InheritedBoundaryDataSource = false;
			this.speccomboShift.ShowSpecialStateAll = false;
			this.speccomboShift.ShowSpecialStateNot = true;
			this.dataRouteList.Add (this.speccomboShift);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.speccomboShift]));
			w24.TopAttach = ((uint)(4));
			w24.BottomAttach = ((uint)(5));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.spinActualDistance = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.spinActualDistance.CanFocus = true;
			this.spinActualDistance.Name = "spinActualDistance";
			this.spinActualDistance.Adjustment.PageIncrement = 10;
			this.spinActualDistance.ClimbRate = 1;
			this.spinActualDistance.Digits = ((uint)(3));
			this.spinActualDistance.Numeric = true;
			this.spinActualDistance.InheritedDataSource = true;
			this.spinActualDistance.Mappings = "ActualDistance";
			this.spinActualDistance.InheritedBoundaryDataSource = false;
			this.spinActualDistance.InheritedDataSource = true;
			this.spinActualDistance.Mappings = "ActualDistance";
			this.spinActualDistance.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.spinActualDistance);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.spinActualDistance]));
			w25.TopAttach = ((uint)(7));
			w25.BottomAttach = ((uint)(8));
			w25.LeftAttach = ((uint)(3));
			w25.RightAttach = ((uint)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.spinPlannedDistance = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.spinPlannedDistance.CanFocus = true;
			this.spinPlannedDistance.Name = "spinPlannedDistance";
			this.spinPlannedDistance.Adjustment.PageIncrement = 10;
			this.spinPlannedDistance.ClimbRate = 1;
			this.spinPlannedDistance.Digits = ((uint)(3));
			this.spinPlannedDistance.Numeric = true;
			this.spinPlannedDistance.InheritedDataSource = true;
			this.spinPlannedDistance.Mappings = "PlannedDistance";
			this.spinPlannedDistance.InheritedBoundaryDataSource = false;
			this.spinPlannedDistance.InheritedDataSource = true;
			this.spinPlannedDistance.Mappings = "PlannedDistance";
			this.spinPlannedDistance.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.spinPlannedDistance);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.spinPlannedDistance]));
			w26.TopAttach = ((uint)(7));
			w26.BottomAttach = ((uint)(8));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.dataRouteList);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.dataRouteList]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.createroutelistitemsview1 = new global::Vodovoz.RouteListCreateItemsView ();
			this.createroutelistitemsview1.HeightRequest = 150;
			this.createroutelistitemsview1.Events = ((global::Gdk.EventMask)(256));
			this.createroutelistitemsview1.Name = "createroutelistitemsview1";
			this.vbox1.Add (this.createroutelistitemsview1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.createroutelistitemsview1]));
			w28.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonPrint = new global::Gtk.Button ();
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			this.buttonPrint.Label = global::Mono.Unix.Catalog.GetString ("Печатать");
			global::Gtk.Image w29 = new global::Gtk.Image ();
			w29.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Menu);
			this.buttonPrint.Image = w29;
			this.hbox8.Add (this.buttonPrint);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonPrint]));
			w30.PackType = ((global::Gtk.PackType)(1));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonAccept = new global::Gtk.Button ();
			this.buttonAccept.CanFocus = true;
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.UseUnderline = true;
			this.buttonAccept.Label = global::Mono.Unix.Catalog.GetString ("Подтвердить");
			global::Gtk.Image w31 = new global::Gtk.Image ();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.buttonAccept.Image = w31;
			this.hbox8.Add (this.buttonAccept);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonAccept]));
			w32.PackType = ((global::Gtk.PackType)(1));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			this.vbox1.Add (this.hbox8);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox8]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonAccept.Clicked += new global::System.EventHandler (this.OnButtonAcceptClicked);
			this.buttonPrint.Clicked += new global::System.EventHandler (this.OnButtonPrintClicked);
		}
	}
}
