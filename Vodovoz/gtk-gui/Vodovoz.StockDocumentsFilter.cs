
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class StockDocumentsFilter
	{
		private global::Gtk.Table table1;

		private global::QSWidgetLib.DatePeriodPicker dateperiodDocs;

		private global::QS.Widgets.GtkUI.RepresentationEntry entryreferencePoint;

		private global::Gamma.Widgets.yEnumComboBox enumcomboDocumentType;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::QS.Widgets.GtkUI.RepresentationEntry yentryrefDriver;

		private global::Gamma.Widgets.yEntryReference yentryrefWarehouse;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.StockDocumentsFilter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.StockDocumentsFilter";
			// Container child Vodovoz.StockDocumentsFilter.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.dateperiodDocs = new global::QSWidgetLib.DatePeriodPicker();
			this.dateperiodDocs.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodDocs.Name = "dateperiodDocs";
			this.dateperiodDocs.StartDate = new global::System.DateTime(0);
			this.dateperiodDocs.EndDate = new global::System.DateTime(0);
			this.table1.Add(this.dateperiodDocs);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.dateperiodDocs]));
			w1.LeftAttach = ((uint)(3));
			w1.RightAttach = ((uint)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryreferencePoint = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.entryreferencePoint.Sensitive = false;
			this.entryreferencePoint.Events = ((global::Gdk.EventMask)(256));
			this.entryreferencePoint.Name = "entryreferencePoint";
			this.table1.Add(this.entryreferencePoint);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.entryreferencePoint]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(3));
			w2.RightAttach = ((uint)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.enumcomboDocumentType = new global::Gamma.Widgets.yEnumComboBox();
			this.enumcomboDocumentType.Name = "enumcomboDocumentType";
			this.enumcomboDocumentType.ShowSpecialStateAll = true;
			this.enumcomboDocumentType.ShowSpecialStateNot = false;
			this.enumcomboDocumentType.UseShortTitle = false;
			this.enumcomboDocumentType.DefaultFirst = false;
			this.table1.Add(this.enumcomboDocumentType);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.enumcomboDocumentType]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Вид документа:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Точка доставки:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Склад:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("За период:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Водитель:");
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryrefDriver = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.yentryrefDriver.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefDriver.Name = "yentryrefDriver";
			this.table1.Add(this.yentryrefDriver);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryrefDriver]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryrefWarehouse = new global::Gamma.Widgets.yEntryReference();
			this.yentryrefWarehouse.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefWarehouse.Name = "yentryrefWarehouse";
			this.table1.Add(this.yentryrefWarehouse);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryrefWarehouse]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.yentryrefWarehouse.ChangedByUser += new global::System.EventHandler(this.OnYentryrefWarehouseChangedByUser);
			this.yentryrefDriver.ChangedByUser += new global::System.EventHandler(this.OnYentryrefDriverChangedByUser);
			this.enumcomboDocumentType.Changed += new global::System.EventHandler(this.OnEnumcomboDocumentTypeChanged);
			this.dateperiodDocs.PeriodChanged += new global::System.EventHandler(this.OnDateperiodDocsPeriodChanged);
		}
	}
}
