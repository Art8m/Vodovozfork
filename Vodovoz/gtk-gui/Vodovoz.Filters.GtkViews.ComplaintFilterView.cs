
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Filters.GtkViews
{
	public partial class ComplaintFilterView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table4;

		private global::QS.Widgets.GtkUI.RepresentationEntry entryreferencevmEmployee;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label5;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxDateType;

		private global::QS.Widgets.GtkUI.DateRangePicker daterangepicker;

		private global::Gtk.HBox hbox5;

		private global::Gamma.GtkWidgets.yButton ybuttonMyComplaint;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gamma.Widgets.yEntryReference yentryreferenceSubdivision;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.Table table1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxStatus;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboboxType;

		private global::Gtk.HSeparator hseparator1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Filters.GtkViews.ComplaintFilterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Filters.GtkViews.ComplaintFilterView";
			// Container child Vodovoz.Filters.GtkViews.ComplaintFilterView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.entryreferencevmEmployee = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.entryreferencevmEmployee.Events = ((global::Gdk.EventMask)(256));
			this.entryreferencevmEmployee.Name = "entryreferencevmEmployee";
			this.table4.Add(this.entryreferencevmEmployee);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table4[this.entryreferencevmEmployee]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Дата");
			this.hbox3.Add(this.label5);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label5]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.yenumcomboboxDateType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxDateType.Name = "yenumcomboboxDateType";
			this.yenumcomboboxDateType.ShowSpecialStateAll = false;
			this.yenumcomboboxDateType.ShowSpecialStateNot = false;
			this.yenumcomboboxDateType.UseShortTitle = false;
			this.yenumcomboboxDateType.DefaultFirst = false;
			this.hbox3.Add(this.yenumcomboboxDateType);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.yenumcomboboxDateType]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.daterangepicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.daterangepicker.Events = ((global::Gdk.EventMask)(256));
			this.daterangepicker.Name = "daterangepicker";
			this.daterangepicker.StartDate = new global::System.DateTime(0);
			this.daterangepicker.EndDate = new global::System.DateTime(0);
			this.hbox3.Add(this.daterangepicker);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.daterangepicker]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.table4.Add(this.hbox3);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table4[this.hbox3]));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.ybuttonMyComplaint = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonMyComplaint.CanFocus = true;
			this.ybuttonMyComplaint.Name = "ybuttonMyComplaint";
			this.ybuttonMyComplaint.UseUnderline = true;
			this.ybuttonMyComplaint.Label = global::Mono.Unix.Catalog.GetString("Мои жалобы");
			this.hbox5.Add(this.ybuttonMyComplaint);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.ybuttonMyComplaint]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			this.table4.Add(this.hbox5);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4[this.hbox5]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.XPadding = ((uint)(3));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Автор жалобы");
			this.table4.Add(this.label3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table4[this.label3]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("В работе у");
			this.table4.Add(this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table4[this.label4]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.yentryreferenceSubdivision = new global::Gamma.Widgets.yEntryReference();
			this.yentryreferenceSubdivision.Events = ((global::Gdk.EventMask)(256));
			this.yentryreferenceSubdivision.Name = "yentryreferenceSubdivision";
			this.table4.Add(this.yentryreferenceSubdivision);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table4[this.yentryreferenceSubdivision]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table4]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Тип");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Статус жалобы");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yenumcomboboxStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxStatus.Name = "yenumcomboboxStatus";
			this.yenumcomboboxStatus.ShowSpecialStateAll = true;
			this.yenumcomboboxStatus.ShowSpecialStateNot = false;
			this.yenumcomboboxStatus.UseShortTitle = false;
			this.yenumcomboboxStatus.DefaultFirst = false;
			this.table1.Add(this.yenumcomboboxStatus);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.yenumcomboboxStatus]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yenumcomboboxType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboboxType.Name = "yenumcomboboxType";
			this.yenumcomboboxType.ShowSpecialStateAll = true;
			this.yenumcomboboxType.ShowSpecialStateNot = false;
			this.yenumcomboboxType.UseShortTitle = false;
			this.yenumcomboboxType.DefaultFirst = false;
			this.table1.Add(this.yenumcomboboxType);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.yenumcomboboxType]));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
