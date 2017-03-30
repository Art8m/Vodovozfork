
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class CarsDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.RadioButton radiobuttonFiles;

		private global::Gtk.RadioButton radiobuttonMain;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Notebook notebook1;

		private global::Gtk.Table tableCarData;

		private global::Gamma.GtkWidgets.yCheckButton checkIsArchive;

		private global::Gamma.GtkWidgets.yCheckButton checkIsCompanyHavings;

		private global::Gamma.Widgets.yEntryReference dataentryFuelType;

		private global::Gamma.GtkWidgets.yEntry dataentryModel;

		private global::Gamma.Widgets.yEntryReference dataentryreferenceDriver;

		private global::Gamma.GtkWidgets.yEntry dataentryRegNumber;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label5;

		private global::Gamma.GtkWidgets.ySpinButton dataspinbutton1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::QSOrmProject.PhotoView photoviewCar;

		private global::Gtk.Label textDriverInfo;

		private global::Gtk.Label label1;

		private global::QSAttachment.Attachment attachmentFiles;

		private global::Gtk.Label label2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.CarsDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.CarsDlg";
			// Container child Vodovoz.CarsDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radiobuttonFiles = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Файлы"));
			this.radiobuttonFiles.CanFocus = true;
			this.radiobuttonFiles.Name = "radiobuttonFiles";
			this.radiobuttonFiles.DrawIndicator = false;
			this.radiobuttonFiles.UseUnderline = true;
			this.radiobuttonFiles.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox1.Add (this.radiobuttonFiles);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.radiobuttonFiles]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radiobuttonMain = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Основное"));
			this.radiobuttonMain.CanFocus = true;
			this.radiobuttonMain.Name = "radiobuttonMain";
			this.radiobuttonMain.DrawIndicator = false;
			this.radiobuttonMain.UseUnderline = true;
			this.radiobuttonMain.Group = this.radiobuttonFiles.Group;
			this.hbox1.Add (this.radiobuttonMain);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.radiobuttonMain]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 3;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vseparator1]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.tableCarData = new global::Gtk.Table (((uint)(6)), ((uint)(5)), false);
			this.tableCarData.Name = "tableCarData";
			this.tableCarData.RowSpacing = ((uint)(6));
			this.tableCarData.ColumnSpacing = ((uint)(6));
			// Container child tableCarData.Gtk.Table+TableChild
			this.checkIsArchive = new global::Gamma.GtkWidgets.yCheckButton ();
			this.checkIsArchive.CanFocus = true;
			this.checkIsArchive.Name = "checkIsArchive";
			this.checkIsArchive.Label = "";
			this.checkIsArchive.DrawIndicator = true;
			this.checkIsArchive.UseUnderline = true;
			this.tableCarData.Add (this.checkIsArchive);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.checkIsArchive]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.checkIsCompanyHavings = new global::Gamma.GtkWidgets.yCheckButton ();
			this.checkIsCompanyHavings.CanFocus = true;
			this.checkIsCompanyHavings.Name = "checkIsCompanyHavings";
			this.checkIsCompanyHavings.Label = global::Mono.Unix.Catalog.GetString ("Имущество компании");
			this.checkIsCompanyHavings.DrawIndicator = true;
			this.checkIsCompanyHavings.UseUnderline = true;
			this.tableCarData.Add (this.checkIsCompanyHavings);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.checkIsCompanyHavings]));
			w10.TopAttach = ((uint)(4));
			w10.BottomAttach = ((uint)(5));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.dataentryFuelType = new global::Gamma.Widgets.yEntryReference ();
			this.dataentryFuelType.Events = ((global::Gdk.EventMask)(256));
			this.dataentryFuelType.Name = "dataentryFuelType";
			this.tableCarData.Add (this.dataentryFuelType);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.dataentryFuelType]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.dataentryModel = new global::Gamma.GtkWidgets.yEntry ();
			this.dataentryModel.CanFocus = true;
			this.dataentryModel.Name = "dataentryModel";
			this.dataentryModel.IsEditable = true;
			this.dataentryModel.MaxLength = 50;
			this.dataentryModel.InvisibleChar = '●';
			this.tableCarData.Add (this.dataentryModel);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.dataentryModel]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.dataentryreferenceDriver = new global::Gamma.Widgets.yEntryReference ();
			this.dataentryreferenceDriver.Events = ((global::Gdk.EventMask)(256));
			this.dataentryreferenceDriver.Name = "dataentryreferenceDriver";
			this.dataentryreferenceDriver.DisplayFields = new string [] {
					"Name",
					"LastName",
					"Patronymic"};
			this.dataentryreferenceDriver.DisplayFormatString = "{0} {1} {2}";
			this.tableCarData.Add (this.dataentryreferenceDriver);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.dataentryreferenceDriver]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.dataentryRegNumber = new global::Gamma.GtkWidgets.yEntry ();
			this.dataentryRegNumber.CanFocus = true;
			this.dataentryRegNumber.Name = "dataentryRegNumber";
			this.dataentryRegNumber.IsEditable = true;
			this.dataentryRegNumber.InvisibleChar = '●';
			this.tableCarData.Add (this.dataentryRegNumber);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.dataentryRegNumber]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(4));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Расход литров");
			this.hbox5.Add (this.label5);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label5]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.dataspinbutton1 = new global::Gamma.GtkWidgets.ySpinButton (0, 999, 1);
			this.dataspinbutton1.CanFocus = true;
			this.dataspinbutton1.Name = "dataspinbutton1";
			this.dataspinbutton1.Adjustment.PageIncrement = 10;
			this.dataspinbutton1.ClimbRate = 1;
			this.dataspinbutton1.Digits = ((uint)(2));
			this.dataspinbutton1.Numeric = true;
			this.dataspinbutton1.ValueAsDecimal = 0m;
			this.dataspinbutton1.ValueAsInt = 0;
			this.hbox5.Add (this.dataspinbutton1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.dataspinbutton1]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("на 100 км.");
			this.hbox5.Add (this.label10);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label10]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.tableCarData.Add (this.hbox5);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.hbox5]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.LeftAttach = ((uint)(2));
			w18.RightAttach = ((uint)(3));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Марка а/м:");
			this.tableCarData.Add (this.label3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.label3]));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Гос. номер:");
			this.tableCarData.Add (this.label4);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.label4]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Водитель:");
			this.tableCarData.Add (this.label6);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.label6]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString (" Информация\nо водителе:");
			this.label7.Justify = ((global::Gtk.Justification)(1));
			this.tableCarData.Add (this.label7);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.label7]));
			w22.TopAttach = ((uint)(5));
			w22.BottomAttach = ((uint)(6));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Архив:");
			this.tableCarData.Add (this.label8);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.label8]));
			w23.TopAttach = ((uint)(4));
			w23.BottomAttach = ((uint)(5));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Топливо:");
			this.tableCarData.Add (this.label9);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.label9]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.photoviewCar = new global::QSOrmProject.PhotoView ();
			this.photoviewCar.Events = ((global::Gdk.EventMask)(256));
			this.photoviewCar.Name = "photoviewCar";
			this.tableCarData.Add (this.photoviewCar);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.photoviewCar]));
			w25.BottomAttach = ((uint)(5));
			w25.LeftAttach = ((uint)(4));
			w25.RightAttach = ((uint)(5));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCarData.Gtk.Table+TableChild
			this.textDriverInfo = new global::Gtk.Label ();
			this.textDriverInfo.Name = "textDriverInfo";
			this.textDriverInfo.Xalign = 0F;
			this.tableCarData.Add (this.textDriverInfo);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.tableCarData [this.textDriverInfo]));
			w26.TopAttach = ((uint)(5));
			w26.BottomAttach = ((uint)(6));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(4));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.tableCarData);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Информация");
			this.notebook1.SetTabLabel (this.tableCarData, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.attachmentFiles = new global::QSAttachment.Attachment ();
			this.attachmentFiles.Events = ((global::Gdk.EventMask)(256));
			this.attachmentFiles.Name = "attachmentFiles";
			this.notebook1.Add (this.attachmentFiles);
			global::Gtk.Notebook.NotebookChild w28 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.attachmentFiles]));
			w28.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Файлы");
			this.notebook1.SetTabLabel (this.attachmentFiles, this.label2);
			this.label2.ShowAll ();
			this.vbox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
			w29.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.radiobuttonMain.Toggled += new global::System.EventHandler (this.OnRadiobuttonMainToggled);
			this.radiobuttonFiles.Toggled += new global::System.EventHandler (this.OnRadiobuttonFilesToggled);
			this.dataentryreferenceDriver.Changed += new global::System.EventHandler (this.OnDataentryreferenceDriverChanged);
			this.checkIsCompanyHavings.Toggled += new global::System.EventHandler (this.OnCheckIsCompanyHavingsToggled);
		}
	}
}
