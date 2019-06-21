
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Filters.GtkViews
{
	public partial class CounterpartyFilterView
	{
		private global::Gtk.Table table1;

		private global::Gamma.GtkWidgets.yCheckButton checkIncludeArhive;

		private global::Gtk.HBox hbox2;

		private global::Gamma.GtkWidgets.yCheckButton checkCustomer;

		private global::Gamma.GtkWidgets.yCheckButton checkSupplier;

		private global::Gamma.GtkWidgets.yCheckButton checkPartner;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::QS.Widgets.GtkUI.RepresentationEntry yentryTag;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Filters.GtkViews.CounterpartyFilterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Filters.GtkViews.CounterpartyFilterView";
			// Container child Vodovoz.Filters.GtkViews.CounterpartyFilterView.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkIncludeArhive = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkIncludeArhive.CanFocus = true;
			this.checkIncludeArhive.Name = "checkIncludeArhive";
			this.checkIncludeArhive.Label = global::Mono.Unix.Catalog.GetString("Включая архивных");
			this.checkIncludeArhive.DrawIndicator = true;
			this.checkIncludeArhive.UseUnderline = true;
			this.table1.Add(this.checkIncludeArhive);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.checkIncludeArhive]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkCustomer = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkCustomer.CanFocus = true;
			this.checkCustomer.Name = "checkCustomer";
			this.checkCustomer.Label = global::Mono.Unix.Catalog.GetString("Покупатель");
			this.checkCustomer.DrawIndicator = true;
			this.checkCustomer.UseUnderline = true;
			this.hbox2.Add(this.checkCustomer);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.checkCustomer]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkSupplier = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkSupplier.CanFocus = true;
			this.checkSupplier.Name = "checkSupplier";
			this.checkSupplier.Label = global::Mono.Unix.Catalog.GetString("Поставщик");
			this.checkSupplier.DrawIndicator = true;
			this.checkSupplier.UseUnderline = true;
			this.hbox2.Add(this.checkSupplier);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.checkSupplier]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.checkPartner = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkPartner.CanFocus = true;
			this.checkPartner.Name = "checkPartner";
			this.checkPartner.Label = global::Mono.Unix.Catalog.GetString("Партнер");
			this.checkPartner.DrawIndicator = true;
			this.checkPartner.UseUnderline = true;
			this.hbox2.Add(this.checkPartner);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.checkPartner]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.table1.Add(this.hbox2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox2]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Показывать только:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Тег:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryTag = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.yentryTag.Events = ((global::Gdk.EventMask)(256));
			this.yentryTag.Name = "yentryTag";
			this.table1.Add(this.yentryTag);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryTag]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
