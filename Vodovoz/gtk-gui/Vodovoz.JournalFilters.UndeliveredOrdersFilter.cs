
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.JournalFilters
{
	public partial class UndeliveredOrdersFilter
	{
		private global::Gtk.Table table1;

		private global::QSWidgetLib.DatePeriodPicker dateperiodNewOrderDate;

		private global::QSWidgetLib.DatePeriodPicker dateperiodOldOrderDate;

		private global::Gamma.Widgets.yEnumComboBox enumCMBUndeliveryStatus;

		private global::Gtk.Label lblActionWithInvoice;

		private global::Gtk.Label lblClient;

		private global::Gtk.Label lblDeliveryPoint;

		private global::Gtk.Label lblDriver;

		private global::Gtk.Label lblGuilty;

		private global::Gtk.Label lblGuiltyDep;

		private global::Gtk.Label lblInProcessAt;

		private global::Gtk.Label lblNewOrderDate;

		private global::Gtk.Label lblOldOrder;

		private global::Gtk.Label lblOldOrderAuthor;

		private global::Gtk.Label lblOldOrderDate;

		private global::Gtk.Label lblUndeliveryAuthor;

		private global::Gtk.Label lblUndeliveryStatus;

		private global::QS.Widgets.GtkUI.RepresentationEntry refClient;

		private global::QS.Widgets.GtkUI.RepresentationEntry refDeliveryPoint;

		private global::QS.Widgets.GtkUI.RepresentationEntry refDriver;

		private global::QS.Widgets.GtkUI.RepresentationEntry refOldOrder;

		private global::QS.Widgets.GtkUI.RepresentationEntry refOldOrderAuthor;

		private global::QS.Widgets.GtkUI.RepresentationEntry refUndeliveryAuthor;

		private global::Gamma.Widgets.yEnumComboBox yEnumCMBActionWithInvoice;

		private global::Gamma.Widgets.yEnumComboBox yEnumCMBGuilty;

		private global::Gamma.Widgets.ySpecComboBox ySpecCMBGuiltyDep;

		private global::Gamma.Widgets.ySpecComboBox ySpecCMBinProcessAt;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.JournalFilters.UndeliveredOrdersFilter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.JournalFilters.UndeliveredOrdersFilter";
			// Container child Vodovoz.JournalFilters.UndeliveredOrdersFilter.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(5)), ((uint)(6)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.dateperiodNewOrderDate = new global::QSWidgetLib.DatePeriodPicker();
			this.dateperiodNewOrderDate.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodNewOrderDate.Name = "dateperiodNewOrderDate";
			this.dateperiodNewOrderDate.StartDate = new global::System.DateTime(0);
			this.dateperiodNewOrderDate.EndDate = new global::System.DateTime(0);
			this.table1.Add(this.dateperiodNewOrderDate);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.dateperiodNewOrderDate]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(3));
			w1.RightAttach = ((uint)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.dateperiodOldOrderDate = new global::QSWidgetLib.DatePeriodPicker();
			this.dateperiodOldOrderDate.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodOldOrderDate.Name = "dateperiodOldOrderDate";
			this.dateperiodOldOrderDate.StartDate = new global::System.DateTime(0);
			this.dateperiodOldOrderDate.EndDate = new global::System.DateTime(0);
			this.table1.Add(this.dateperiodOldOrderDate);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.dateperiodOldOrderDate]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(3));
			w2.RightAttach = ((uint)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.enumCMBUndeliveryStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.enumCMBUndeliveryStatus.Name = "enumCMBUndeliveryStatus";
			this.enumCMBUndeliveryStatus.ShowSpecialStateAll = true;
			this.enumCMBUndeliveryStatus.ShowSpecialStateNot = false;
			this.enumCMBUndeliveryStatus.UseShortTitle = false;
			this.enumCMBUndeliveryStatus.DefaultFirst = false;
			this.table1.Add(this.enumCMBUndeliveryStatus);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.enumCMBUndeliveryStatus]));
			w3.LeftAttach = ((uint)(5));
			w3.RightAttach = ((uint)(6));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblActionWithInvoice = new global::Gtk.Label();
			this.lblActionWithInvoice.Name = "lblActionWithInvoice";
			this.lblActionWithInvoice.Xalign = 1F;
			this.lblActionWithInvoice.LabelProp = global::Mono.Unix.Catalog.GetString("Действие с накладной:");
			this.table1.Add(this.lblActionWithInvoice);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.lblActionWithInvoice]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblClient = new global::Gtk.Label();
			this.lblClient.Name = "lblClient";
			this.lblClient.Xalign = 1F;
			this.lblClient.LabelProp = global::Mono.Unix.Catalog.GetString("Клиент:");
			this.table1.Add(this.lblClient);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.lblClient]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblDeliveryPoint = new global::Gtk.Label();
			this.lblDeliveryPoint.Name = "lblDeliveryPoint";
			this.lblDeliveryPoint.Xalign = 1F;
			this.lblDeliveryPoint.LabelProp = global::Mono.Unix.Catalog.GetString("Адрес:");
			this.table1.Add(this.lblDeliveryPoint);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.lblDeliveryPoint]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblDriver = new global::Gtk.Label();
			this.lblDriver.Name = "lblDriver";
			this.lblDriver.Xalign = 1F;
			this.lblDriver.LabelProp = global::Mono.Unix.Catalog.GetString("Водитель:");
			this.table1.Add(this.lblDriver);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.lblDriver]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblGuilty = new global::Gtk.Label();
			this.lblGuilty.Name = "lblGuilty";
			this.lblGuilty.Xalign = 1F;
			this.lblGuilty.LabelProp = global::Mono.Unix.Catalog.GetString("Виновник:");
			this.table1.Add(this.lblGuilty);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.lblGuilty]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(4));
			w8.RightAttach = ((uint)(5));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblGuiltyDep = new global::Gtk.Label();
			this.lblGuiltyDep.Name = "lblGuiltyDep";
			this.lblGuiltyDep.Xalign = 1F;
			this.lblGuiltyDep.LabelProp = global::Mono.Unix.Catalog.GetString("Отдел:");
			this.table1.Add(this.lblGuiltyDep);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.lblGuiltyDep]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(4));
			w9.RightAttach = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblInProcessAt = new global::Gtk.Label();
			this.lblInProcessAt.Name = "lblInProcessAt";
			this.lblInProcessAt.Xalign = 1F;
			this.lblInProcessAt.LabelProp = global::Mono.Unix.Catalog.GetString("В работе у отд.:");
			this.table1.Add(this.lblInProcessAt);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.lblInProcessAt]));
			w10.TopAttach = ((uint)(4));
			w10.BottomAttach = ((uint)(5));
			w10.LeftAttach = ((uint)(4));
			w10.RightAttach = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblNewOrderDate = new global::Gtk.Label();
			this.lblNewOrderDate.Name = "lblNewOrderDate";
			this.lblNewOrderDate.Xalign = 1F;
			this.lblNewOrderDate.LabelProp = global::Mono.Unix.Catalog.GetString("Дата переноса:");
			this.table1.Add(this.lblNewOrderDate);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.lblNewOrderDate]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblOldOrder = new global::Gtk.Label();
			this.lblOldOrder.Name = "lblOldOrder";
			this.lblOldOrder.Xalign = 1F;
			this.lblOldOrder.LabelProp = global::Mono.Unix.Catalog.GetString("Заказ:");
			this.table1.Add(this.lblOldOrder);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.lblOldOrder]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblOldOrderAuthor = new global::Gtk.Label();
			this.lblOldOrderAuthor.Name = "lblOldOrderAuthor";
			this.lblOldOrderAuthor.Xalign = 1F;
			this.lblOldOrderAuthor.LabelProp = global::Mono.Unix.Catalog.GetString("Автор заказа:");
			this.table1.Add(this.lblOldOrderAuthor);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.lblOldOrderAuthor]));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblOldOrderDate = new global::Gtk.Label();
			this.lblOldOrderDate.Name = "lblOldOrderDate";
			this.lblOldOrderDate.Xalign = 1F;
			this.lblOldOrderDate.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.table1.Add(this.lblOldOrderDate);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.lblOldOrderDate]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblUndeliveryAuthor = new global::Gtk.Label();
			this.lblUndeliveryAuthor.Name = "lblUndeliveryAuthor";
			this.lblUndeliveryAuthor.Xalign = 1F;
			this.lblUndeliveryAuthor.LabelProp = global::Mono.Unix.Catalog.GetString("Автор недовоза:");
			this.table1.Add(this.lblUndeliveryAuthor);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.lblUndeliveryAuthor]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(4));
			w15.RightAttach = ((uint)(5));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblUndeliveryStatus = new global::Gtk.Label();
			this.lblUndeliveryStatus.Name = "lblUndeliveryStatus";
			this.lblUndeliveryStatus.Xalign = 1F;
			this.lblUndeliveryStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Статус недовоза:");
			this.table1.Add(this.lblUndeliveryStatus);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.lblUndeliveryStatus]));
			w16.LeftAttach = ((uint)(4));
			w16.RightAttach = ((uint)(5));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.refClient = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.refClient.Events = ((global::Gdk.EventMask)(256));
			this.refClient.Name = "refClient";
			this.table1.Add(this.refClient);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.refClient]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.refDeliveryPoint = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.refDeliveryPoint.Events = ((global::Gdk.EventMask)(256));
			this.refDeliveryPoint.Name = "refDeliveryPoint";
			this.table1.Add(this.refDeliveryPoint);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.refDeliveryPoint]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.refDriver = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.refDriver.Events = ((global::Gdk.EventMask)(256));
			this.refDriver.Name = "refDriver";
			this.table1.Add(this.refDriver);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.refDriver]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.refOldOrder = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.refOldOrder.Events = ((global::Gdk.EventMask)(256));
			this.refOldOrder.Name = "refOldOrder";
			this.table1.Add(this.refOldOrder);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.refOldOrder]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.refOldOrderAuthor = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.refOldOrderAuthor.Events = ((global::Gdk.EventMask)(256));
			this.refOldOrderAuthor.Name = "refOldOrderAuthor";
			this.table1.Add(this.refOldOrderAuthor);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.refOldOrderAuthor]));
			w21.LeftAttach = ((uint)(3));
			w21.RightAttach = ((uint)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.refUndeliveryAuthor = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.refUndeliveryAuthor.Events = ((global::Gdk.EventMask)(256));
			this.refUndeliveryAuthor.Name = "refUndeliveryAuthor";
			this.table1.Add(this.refUndeliveryAuthor);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.refUndeliveryAuthor]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.LeftAttach = ((uint)(5));
			w22.RightAttach = ((uint)(6));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yEnumCMBActionWithInvoice = new global::Gamma.Widgets.yEnumComboBox();
			this.yEnumCMBActionWithInvoice.Name = "yEnumCMBActionWithInvoice";
			this.yEnumCMBActionWithInvoice.ShowSpecialStateAll = true;
			this.yEnumCMBActionWithInvoice.ShowSpecialStateNot = false;
			this.yEnumCMBActionWithInvoice.UseShortTitle = false;
			this.yEnumCMBActionWithInvoice.DefaultFirst = false;
			this.table1.Add(this.yEnumCMBActionWithInvoice);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.yEnumCMBActionWithInvoice]));
			w23.TopAttach = ((uint)(3));
			w23.BottomAttach = ((uint)(4));
			w23.LeftAttach = ((uint)(3));
			w23.RightAttach = ((uint)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yEnumCMBGuilty = new global::Gamma.Widgets.yEnumComboBox();
			this.yEnumCMBGuilty.Name = "yEnumCMBGuilty";
			this.yEnumCMBGuilty.ShowSpecialStateAll = true;
			this.yEnumCMBGuilty.ShowSpecialStateNot = false;
			this.yEnumCMBGuilty.UseShortTitle = false;
			this.yEnumCMBGuilty.DefaultFirst = false;
			this.table1.Add(this.yEnumCMBGuilty);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.yEnumCMBGuilty]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.LeftAttach = ((uint)(5));
			w24.RightAttach = ((uint)(6));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ySpecCMBGuiltyDep = new global::Gamma.Widgets.ySpecComboBox();
			this.ySpecCMBGuiltyDep.Name = "ySpecCMBGuiltyDep";
			this.ySpecCMBGuiltyDep.AddIfNotExist = false;
			this.ySpecCMBGuiltyDep.DefaultFirst = false;
			this.ySpecCMBGuiltyDep.ShowSpecialStateAll = true;
			this.ySpecCMBGuiltyDep.ShowSpecialStateNot = false;
			this.table1.Add(this.ySpecCMBGuiltyDep);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.ySpecCMBGuiltyDep]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.LeftAttach = ((uint)(5));
			w25.RightAttach = ((uint)(6));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ySpecCMBinProcessAt = new global::Gamma.Widgets.ySpecComboBox();
			this.ySpecCMBinProcessAt.Name = "ySpecCMBinProcessAt";
			this.ySpecCMBinProcessAt.AddIfNotExist = false;
			this.ySpecCMBinProcessAt.DefaultFirst = false;
			this.ySpecCMBinProcessAt.ShowSpecialStateAll = true;
			this.ySpecCMBinProcessAt.ShowSpecialStateNot = false;
			this.table1.Add(this.ySpecCMBinProcessAt);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.ySpecCMBinProcessAt]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.LeftAttach = ((uint)(5));
			w26.RightAttach = ((uint)(6));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.ySpecCMBinProcessAt.ItemSelected += new global::System.EventHandler<Gamma.Widgets.ItemSelectedEventArgs>(this.OnYSpecCMBinProcessAtItemSelected);
			this.ySpecCMBGuiltyDep.ItemSelected += new global::System.EventHandler<Gamma.Widgets.ItemSelectedEventArgs>(this.OnYSpecCMBGuiltyDepItemSelected);
			this.yEnumCMBGuilty.EnumItemSelected += new global::System.EventHandler<Gamma.Widgets.ItemSelectedEventArgs>(this.OnYEnumCMBGuiltyEnumItemSelected);
			this.yEnumCMBActionWithInvoice.EnumItemSelected += new global::System.EventHandler<Gamma.Widgets.ItemSelectedEventArgs>(this.OnYEnumCMBActionWithInvoiceEnumItemSelected);
			this.refUndeliveryAuthor.Changed += new global::System.EventHandler(this.OnRefUndeliveryAuthorChanged);
			this.refOldOrderAuthor.Changed += new global::System.EventHandler(this.OnRefOldOrderAuthorChanged);
			this.refOldOrder.Changed += new global::System.EventHandler(this.OnRefOldOrderChanged);
			this.refDriver.Changed += new global::System.EventHandler(this.OnRefDriverChanged);
			this.refDeliveryPoint.Changed += new global::System.EventHandler(this.OnRefDeliveryPointChanged);
			this.refClient.Changed += new global::System.EventHandler(this.OnRefClientChanged);
			this.enumCMBUndeliveryStatus.EnumItemSelected += new global::System.EventHandler<Gamma.Widgets.ItemSelectedEventArgs>(this.OnEnumCMBUndeliveryStatusEnumItemSelected);
			this.dateperiodOldOrderDate.PeriodChanged += new global::System.EventHandler(this.OnDateperiodOldOrderDatePeriodChanged);
			this.dateperiodNewOrderDate.PeriodChanged += new global::System.EventHandler(this.OnDateperiodNewOrderDatePeriodChanged);
		}
	}
}
