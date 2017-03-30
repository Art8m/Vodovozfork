
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class FuelDocumentDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table table3;

		private global::Gtk.HBox hbox4;

		private global::QSOrmProject.DisableSpinButton disablespinMoney;

		private global::Gtk.Button buttonSetRemain;

		private global::Gtk.HBox hbox5;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label labelExpenseInfo;

		private global::Gtk.Button buttonOpenExpense;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label labelResultInfo;

		private global::Gamma.Widgets.yDatePicker ydatepicker;

		private global::Gamma.Widgets.yEntryReference yentryCar;

		private global::Gamma.Widgets.yEntryReference yentrydriver;

		private global::Gamma.Widgets.yEntryReference yentryfuel;

		private global::Gamma.GtkWidgets.yTextView ytextviewFuelInfo;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeTickets;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.FuelDocumentDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.FuelDocumentDlg";
			// Container child Vodovoz.FuelDocumentDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox8.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox8.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add (this.hbox8);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox8]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(6)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.disablespinMoney = new global::QSOrmProject.DisableSpinButton ();
			this.disablespinMoney.Events = ((global::Gdk.EventMask)(256));
			this.disablespinMoney.Name = "disablespinMoney";
			this.disablespinMoney.Active = false;
			this.disablespinMoney.Upper = 100000;
			this.disablespinMoney.Lower = 0;
			this.disablespinMoney.Digits = ((uint)(2));
			this.hbox4.Add (this.disablespinMoney);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.disablespinMoney]));
			w6.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSetRemain = new global::Gtk.Button ();
			this.buttonSetRemain.CanFocus = true;
			this.buttonSetRemain.Name = "buttonSetRemain";
			this.buttonSetRemain.UseUnderline = true;
			this.buttonSetRemain.Label = global::Mono.Unix.Catalog.GetString ("Весь остаток");
			this.hbox4.Add (this.buttonSetRemain);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonSetRemain]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.table3.Add (this.hbox4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3 [this.hbox4]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			this.table3.Add (this.hbox5);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.hbox5]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelExpenseInfo = new global::Gtk.Label ();
			this.labelExpenseInfo.Name = "labelExpenseInfo";
			this.labelExpenseInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("Расходный ордер");
			this.hbox7.Add (this.labelExpenseInfo);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.labelExpenseInfo]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonOpenExpense = new global::Gtk.Button ();
			this.buttonOpenExpense.CanFocus = true;
			this.buttonOpenExpense.Name = "buttonOpenExpense";
			this.buttonOpenExpense.UseUnderline = true;
			this.buttonOpenExpense.Label = global::Mono.Unix.Catalog.GetString ("Открыть расходный ордер");
			this.hbox7.Add (this.buttonOpenExpense);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonOpenExpense]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.table3.Add (this.hbox7);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3 [this.hbox7]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.table3.Add (this.label1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3 [this.label1]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Водитель:");
			this.table3.Add (this.label2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3 [this.label2]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Вид топлива:");
			this.table3.Add (this.label3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3 [this.label3]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Автомобиль:");
			this.table3.Add (this.label4);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3 [this.label4]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Выдано деньгами:");
			this.table3.Add (this.label5);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3 [this.label5]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelResultInfo = new global::Gtk.Label ();
			this.labelResultInfo.Name = "labelResultInfo";
			this.labelResultInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("Итог");
			this.table3.Add (this.labelResultInfo);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3 [this.labelResultInfo]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.LeftAttach = ((uint)(2));
			w18.RightAttach = ((uint)(3));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ydatepicker = new global::Gamma.Widgets.yDatePicker ();
			this.ydatepicker.Events = ((global::Gdk.EventMask)(256));
			this.ydatepicker.Name = "ydatepicker";
			this.ydatepicker.WithTime = false;
			this.ydatepicker.Date = new global::System.DateTime (0);
			this.ydatepicker.IsEditable = false;
			this.ydatepicker.AutoSeparation = false;
			this.table3.Add (this.ydatepicker);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3 [this.ydatepicker]));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.yentryCar = new global::Gamma.Widgets.yEntryReference ();
			this.yentryCar.Sensitive = false;
			this.yentryCar.Events = ((global::Gdk.EventMask)(256));
			this.yentryCar.Name = "yentryCar";
			this.table3.Add (this.yentryCar);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table3 [this.yentryCar]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.yentrydriver = new global::Gamma.Widgets.yEntryReference ();
			this.yentrydriver.Sensitive = false;
			this.yentrydriver.Events = ((global::Gdk.EventMask)(256));
			this.yentrydriver.Name = "yentrydriver";
			this.table3.Add (this.yentrydriver);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3 [this.yentrydriver]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.yentryfuel = new global::Gamma.Widgets.yEntryReference ();
			this.yentryfuel.Sensitive = false;
			this.yentryfuel.Events = ((global::Gdk.EventMask)(256));
			this.yentryfuel.Name = "yentryfuel";
			this.table3.Add (this.yentryfuel);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table3 [this.yentryfuel]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.ytextviewFuelInfo = new global::Gamma.GtkWidgets.yTextView ();
			this.ytextviewFuelInfo.CanFocus = true;
			this.ytextviewFuelInfo.Name = "ytextviewFuelInfo";
			this.ytextviewFuelInfo.Editable = false;
			this.table3.Add (this.ytextviewFuelInfo);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table3 [this.ytextviewFuelInfo]));
			w23.BottomAttach = ((uint)(4));
			w23.LeftAttach = ((uint)(2));
			w23.RightAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table3]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeTickets = new global::Gamma.GtkWidgets.yTreeView ();
			this.ytreeTickets.CanFocus = true;
			this.ytreeTickets.Name = "ytreeTickets";
			this.GtkScrolledWindow.Add (this.ytreeTickets);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w26.Position = 2;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOpenExpense.Clicked += new global::System.EventHandler (this.OnButtonOpenExpenseClicked);
			this.disablespinMoney.ValueChanged += new global::System.EventHandler (this.OnDisablespinMoneyValueChanged);
			this.buttonSetRemain.Clicked += new global::System.EventHandler (this.OnButtonSetRemainClicked);
		}
	}
}
