
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz {
	public partial class OrdersFilter {
		private global::Gtk.Table table1;
		
		private global::QSOrmProject.EnumComboBox enumcomboStatus;
		
		private global::Gtk.Label label1;
		
		protected virtual void Build() {
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.OrdersFilter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.OrdersFilter";
			// Container child Vodovoz.OrdersFilter.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.enumcomboStatus = new global::QSOrmProject.EnumComboBox();
			this.enumcomboStatus.Name = "enumcomboStatus";
			this.enumcomboStatus.ShowSpecialStateAll = true;
			this.enumcomboStatus.ShowSpecialStateNot = false;
			this.table1.Add(this.enumcomboStatus);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.enumcomboStatus]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Статус:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.Hide();
			this.enumcomboStatus.EnumItemSelected += new global::System.EventHandler<QSOrmProject.EnumItemClickedEventArgs>(this.OnEnumcomboStatusEnumItemSelected);
		}
	}
}
