
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class AdditionalAgreementFreeRent
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.DataBindings.DataTable datatable1;
		
		private global::QSOrmProject.DataDatePicker dateIssue;
		
		private global::QSOrmProject.DataDatePicker dateStart;
		
		private global::Gtk.DataBindings.DataEntry entryAgreementNumber;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.DataBindings.DataEntryReference referenceRentPackage;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.AdditionalAgreementFreeRent
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.AdditionalAgreementFreeRent";
			// Container child Vodovoz.AdditionalAgreementFreeRent.Gtk.Container+ContainerChild
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
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Ok");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.DataBindings.DataTable (((uint)(6)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			// Container child datatable1.Gtk.Table+TableChild
			this.dateIssue = new global::QSOrmProject.DataDatePicker ();
			this.dateIssue.Events = ((global::Gdk.EventMask)(256));
			this.dateIssue.Name = "dateIssue";
			this.dateIssue.Date = new global::System.DateTime (0);
			this.dateIssue.IsEditable = false;
			this.dateIssue.AutoSeparation = false;
			this.dateIssue.InheritedDataSource = true;
			this.dateIssue.Mappings = "IssueDate";
			this.dateIssue.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.dateIssue);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dateIssue]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.dateStart = new global::QSOrmProject.DataDatePicker ();
			this.dateStart.Events = ((global::Gdk.EventMask)(256));
			this.dateStart.Name = "dateStart";
			this.dateStart.Date = new global::System.DateTime (0);
			this.dateStart.IsEditable = false;
			this.dateStart.AutoSeparation = false;
			this.dateStart.InheritedDataSource = true;
			this.dateStart.Mappings = "StartDate";
			this.dateStart.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.dateStart);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dateStart]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryAgreementNumber = new global::Gtk.DataBindings.DataEntry ();
			this.entryAgreementNumber.CanFocus = true;
			this.entryAgreementNumber.Name = "entryAgreementNumber";
			this.entryAgreementNumber.IsEditable = true;
			this.entryAgreementNumber.InvisibleChar = '●';
			this.entryAgreementNumber.InheritedDataSource = true;
			this.entryAgreementNumber.Mappings = "AgreementNumber";
			this.entryAgreementNumber.InheritedBoundaryDataSource = false;
			this.entryAgreementNumber.InheritedDataSource = true;
			this.entryAgreementNumber.Mappings = "AgreementNumber";
			this.entryAgreementNumber.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.entryAgreementNumber);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.entryAgreementNumber]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер доп. соглашения:");
			this.datatable1.Add (this.label1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label1]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Точка доставки:");
			this.datatable1.Add (this.label2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label2]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата создания:");
			this.datatable1.Add (this.label3);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label3]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата начала действия:");
			this.datatable1.Add (this.label4);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label4]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Пакет бесплатной аренды:");
			this.datatable1.Add (this.label5);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label5]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceRentPackage = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceRentPackage.Events = ((global::Gdk.EventMask)(256));
			this.referenceRentPackage.Name = "referenceRentPackage";
			this.referenceRentPackage.DisplayFields = new string[] {
				"Name"
			};
			this.referenceRentPackage.DisplayFormatString = "{0}";
			this.referenceRentPackage.InheritedDataSource = true;
			this.referenceRentPackage.Mappings = "RentPackage";
			this.referenceRentPackage.InheritedBoundaryDataSource = false;
			this.referenceRentPackage.CursorPointsEveryType = false;
			this.datatable1.Add (this.referenceRentPackage);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.referenceRentPackage]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.datatable1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datatable1]));
			w13.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
		}
	}
}
