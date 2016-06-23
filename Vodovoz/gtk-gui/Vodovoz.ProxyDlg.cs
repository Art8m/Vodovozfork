
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class ProxyDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.DataBindings.DataTable datatable1;
		
		private global::QSOrmProject.DataDatePicker datepickerIssue;
		
		private global::Gtk.DataBindings.DataEntry entryNumber;
		
		private global::Gtk.HBox hbox4;
		
		private global::QSOrmProject.DataDatePicker datepickerStart;
		
		private global::Gtk.Label label5;
		
		private global::QSOrmProject.DataDatePicker datepickerExpiration;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label6;
		
		private global::QSContacts.PersonsView personsView;
		
		private global::Gtk.DataBindings.DataEntryReferenceVM referenceDeliveryPoint;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.ProxyDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.ProxyDlg";
			// Container child Vodovoz.ProxyDlg.Gtk.Container+ContainerChild
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
			w4.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.DataBindings.DataTable (((uint)(5)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			// Container child datatable1.Gtk.Table+TableChild
			this.datepickerIssue = new global::QSOrmProject.DataDatePicker ();
			this.datepickerIssue.Events = ((global::Gdk.EventMask)(256));
			this.datepickerIssue.Name = "datepickerIssue";
			this.datepickerIssue.WithTime = false;
			this.datepickerIssue.Date = new global::System.DateTime (0);
			this.datepickerIssue.IsEditable = true;
			this.datepickerIssue.AutoSeparation = false;
			this.datepickerIssue.InheritedDataSource = true;
			this.datepickerIssue.Mappings = "IssueDate";
			this.datepickerIssue.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.datepickerIssue);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.datepickerIssue]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryNumber = new global::Gtk.DataBindings.DataEntry ();
			this.entryNumber.CanFocus = true;
			this.entryNumber.Name = "entryNumber";
			this.entryNumber.IsEditable = true;
			this.entryNumber.InvisibleChar = '●';
			this.entryNumber.InheritedDataSource = true;
			this.entryNumber.Mappings = "Number";
			this.entryNumber.InheritedBoundaryDataSource = false;
			this.entryNumber.InheritedDataSource = true;
			this.entryNumber.Mappings = "Number";
			this.entryNumber.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.entryNumber);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.entryNumber]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.datepickerStart = new global::QSOrmProject.DataDatePicker ();
			this.datepickerStart.Events = ((global::Gdk.EventMask)(256));
			this.datepickerStart.Name = "datepickerStart";
			this.datepickerStart.WithTime = false;
			this.datepickerStart.Date = new global::System.DateTime (0);
			this.datepickerStart.IsEditable = true;
			this.datepickerStart.AutoSeparation = false;
			this.datepickerStart.InheritedDataSource = true;
			this.datepickerStart.Mappings = "StartDate";
			this.datepickerStart.InheritedBoundaryDataSource = false;
			this.hbox4.Add (this.datepickerStart);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.datepickerStart]));
			w8.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString (" - ");
			this.hbox4.Add (this.label5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label5]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.datepickerExpiration = new global::QSOrmProject.DataDatePicker ();
			this.datepickerExpiration.Events = ((global::Gdk.EventMask)(256));
			this.datepickerExpiration.Name = "datepickerExpiration";
			this.datepickerExpiration.WithTime = false;
			this.datepickerExpiration.Date = new global::System.DateTime (0);
			this.datepickerExpiration.IsEditable = true;
			this.datepickerExpiration.AutoSeparation = false;
			this.datepickerExpiration.InheritedDataSource = true;
			this.datepickerExpiration.Mappings = "ExpirationDate";
			this.datepickerExpiration.InheritedBoundaryDataSource = false;
			this.hbox4.Add (this.datepickerExpiration);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.datepickerExpiration]));
			w10.Position = 2;
			this.datatable1.Add (this.hbox4);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.hbox4]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Список сотрудников:");
			this.datatable1.Add (this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label1]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер:");
			this.datatable1.Add (this.label2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label2]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата выдачи:");
			this.datatable1.Add (this.label3);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label3]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Сроки действия:");
			this.datatable1.Add (this.label4);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label4]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Точка доставки:");
			this.datatable1.Add (this.label6);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label6]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.personsView = new global::QSContacts.PersonsView ();
			this.personsView.Events = ((global::Gdk.EventMask)(256));
			this.personsView.Name = "personsView";
			this.datatable1.Add (this.personsView);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.personsView]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceDeliveryPoint = new global::Gtk.DataBindings.DataEntryReferenceVM ();
			this.referenceDeliveryPoint.Events = ((global::Gdk.EventMask)(256));
			this.referenceDeliveryPoint.Name = "referenceDeliveryPoint";
			this.referenceDeliveryPoint.InheritedDataSource = true;
			this.referenceDeliveryPoint.Mappings = "DeliveryPoint";
			this.referenceDeliveryPoint.InheritedBoundaryDataSource = false;
			this.referenceDeliveryPoint.CursorPointsEveryType = false;
			this.datatable1.Add (this.referenceDeliveryPoint);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.referenceDeliveryPoint]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.datatable1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datatable1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
		}
	}
}
