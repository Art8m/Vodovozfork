
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views
{
	public partial class ExportImportNomenclatureCatalogView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Table table1;

		private global::QS.Widgets.EnumMenuButton enummenubuttonExport;

		private global::QS.Widgets.EnumMenuButton enummenubuttonLoadActions;

		private global::Gamma.GtkWidgets.yButton ybuttonExport;

		private global::Gamma.GtkWidgets.yFileChooserButton yfilechooserbuttonImport;

		private global::Gamma.GtkWidgets.yLabel ylabelExport;

		private global::Gamma.GtkWidgets.yLabel ylabelImport;

		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox4;

		private global::Gamma.GtkWidgets.yButton ybuttonConfirmLoadNew;

		private global::QS.Widgets.EnumMenuButton enummenubuttonConfirmUpdate;

		private global::Gamma.GtkWidgets.yCheckButton ycheckDontChangeSellPrice;

		private global::Gamma.GtkWidgets.yLabel ylabel2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.ProgressBar progressbar;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTextView ytextviewProgressStatus;

		private global::Gtk.HBox hbox1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewNomenclatures;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gamma.GtkWidgets.yTextView ytextviewNodeMessages;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.ExportImportNomenclatureCatalogView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.ExportImportNomenclatureCatalogView";
			// Container child Vodovoz.Views.ExportImportNomenclatureCatalogView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.enummenubuttonExport = new global::QS.Widgets.EnumMenuButton();
			this.enummenubuttonExport.CanFocus = true;
			this.enummenubuttonExport.Name = "enummenubuttonExport";
			this.enummenubuttonExport.UseUnderline = true;
			this.enummenubuttonExport.UseMarkup = false;
			this.enummenubuttonExport.LabelXAlign = 0F;
			this.enummenubuttonExport.Label = global::Mono.Unix.Catalog.GetString("Выгрузка");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-copy", global::Gtk.IconSize.Menu);
			this.enummenubuttonExport.Image = w1;
			this.table1.Add(this.enummenubuttonExport);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.enummenubuttonExport]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.enummenubuttonLoadActions = new global::QS.Widgets.EnumMenuButton();
			this.enummenubuttonLoadActions.CanFocus = true;
			this.enummenubuttonLoadActions.Name = "enummenubuttonLoadActions";
			this.enummenubuttonLoadActions.UseUnderline = true;
			this.enummenubuttonLoadActions.UseMarkup = false;
			this.enummenubuttonLoadActions.LabelXAlign = 0F;
			this.enummenubuttonLoadActions.Label = global::Mono.Unix.Catalog.GetString("Действия");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-justify-fill", global::Gtk.IconSize.Menu);
			this.enummenubuttonLoadActions.Image = w3;
			this.table1.Add(this.enummenubuttonLoadActions);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.enummenubuttonLoadActions]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ybuttonExport = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonExport.WidthRequest = 200;
			this.ybuttonExport.HeightRequest = 30;
			this.ybuttonExport.CanFocus = true;
			this.ybuttonExport.Name = "ybuttonExport";
			this.ybuttonExport.UseUnderline = true;
			this.ybuttonExport.Label = global::Mono.Unix.Catalog.GetString("Выбрать");
			this.table1.Add(this.ybuttonExport);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.ybuttonExport]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yfilechooserbuttonImport = new global::Gamma.GtkWidgets.yFileChooserButton();
			this.yfilechooserbuttonImport.WidthRequest = 150;
			this.yfilechooserbuttonImport.HeightRequest = 30;
			this.yfilechooserbuttonImport.Name = "yfilechooserbuttonImport";
			this.yfilechooserbuttonImport.Title = global::Mono.Unix.Catalog.GetString("Выберите csv файл");
			this.table1.Add(this.yfilechooserbuttonImport);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.yfilechooserbuttonImport]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabelExport = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelExport.Name = "ylabelExport";
			this.ylabelExport.LabelProp = global::Mono.Unix.Catalog.GetString("Папка выгрузки:");
			this.table1.Add(this.ylabelExport);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabelExport]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabelImport = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelImport.Name = "ylabelImport";
			this.ylabelImport.LabelProp = global::Mono.Unix.Catalog.GetString("Файл загрузки:");
			this.table1.Add(this.ylabelImport);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabelImport]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox3.Add(this.table1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.table1]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.ybuttonConfirmLoadNew = new global::Gamma.GtkWidgets.yButton();
			this.ybuttonConfirmLoadNew.CanFocus = true;
			this.ybuttonConfirmLoadNew.Name = "ybuttonConfirmLoadNew";
			this.ybuttonConfirmLoadNew.UseUnderline = true;
			this.ybuttonConfirmLoadNew.Label = global::Mono.Unix.Catalog.GetString("Подтвердить загрузку");
			global::Gtk.Image w10 = new global::Gtk.Image();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.ybuttonConfirmLoadNew.Image = w10;
			this.hbox4.Add(this.ybuttonConfirmLoadNew);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ybuttonConfirmLoadNew]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.enummenubuttonConfirmUpdate = new global::QS.Widgets.EnumMenuButton();
			this.enummenubuttonConfirmUpdate.CanFocus = true;
			this.enummenubuttonConfirmUpdate.Name = "enummenubuttonConfirmUpdate";
			this.enummenubuttonConfirmUpdate.UseUnderline = true;
			this.enummenubuttonConfirmUpdate.UseMarkup = false;
			this.enummenubuttonConfirmUpdate.LabelXAlign = 0F;
			this.enummenubuttonConfirmUpdate.Label = global::Mono.Unix.Catalog.GetString("Подтвердить замену");
			global::Gtk.Image w12 = new global::Gtk.Image();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.enummenubuttonConfirmUpdate.Image = w12;
			this.hbox4.Add(this.enummenubuttonConfirmUpdate);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.enummenubuttonConfirmUpdate]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.ycheckDontChangeSellPrice = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckDontChangeSellPrice.CanFocus = true;
			this.ycheckDontChangeSellPrice.Name = "ycheckDontChangeSellPrice";
			this.ycheckDontChangeSellPrice.Label = global::Mono.Unix.Catalog.GetString("Не заменять цены на продажу");
			this.ycheckDontChangeSellPrice.DrawIndicator = true;
			this.ycheckDontChangeSellPrice.UseUnderline = true;
			this.hbox4.Add(this.ycheckDontChangeSellPrice);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ycheckDontChangeSellPrice]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.ylabel2 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel2.HeightRequest = 30;
			this.ylabel2.Name = "ylabel2";
			this.ylabel2.Xalign = 1F;
			this.ylabel2.LabelProp = global::Mono.Unix.Catalog.GetString("Статус: ");
			this.hbox4.Add(this.ylabel2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ylabel2]));
			w15.Position = 3;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.progressbar = new global::Gtk.ProgressBar();
			this.progressbar.WidthRequest = 450;
			this.progressbar.HeightRequest = 30;
			this.progressbar.Name = "progressbar";
			this.hbox2.Add(this.progressbar);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.progressbar]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.hbox3.Add(this.vbox1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytextviewProgressStatus = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewProgressStatus.CanFocus = true;
			this.ytextviewProgressStatus.Name = "ytextviewProgressStatus";
			this.ytextviewProgressStatus.Editable = false;
			this.ytextviewProgressStatus.WrapMode = ((global::Gtk.WrapMode)(3));
			this.ytextviewProgressStatus.LeftMargin = 5;
			this.GtkScrolledWindow1.Add(this.ytextviewProgressStatus);
			this.hbox3.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.GtkScrolledWindow1]));
			w21.Position = 2;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewNomenclatures = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewNomenclatures.CanFocus = true;
			this.ytreeviewNomenclatures.Name = "ytreeviewNomenclatures";
			this.GtkScrolledWindow.Add(this.ytreeviewNomenclatures);
			this.hbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow]));
			w24.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.WidthRequest = 300;
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ytextviewNodeMessages = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewNodeMessages.CanFocus = true;
			this.ytextviewNodeMessages.Name = "ytextviewNodeMessages";
			this.ytextviewNodeMessages.Editable = false;
			this.ytextviewNodeMessages.WrapMode = ((global::Gtk.WrapMode)(3));
			this.ytextviewNodeMessages.LeftMargin = 5;
			this.GtkScrolledWindow2.Add(this.ytextviewNodeMessages);
			this.hbox1.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow2]));
			w26.Position = 1;
			w26.Expand = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w27.Position = 1;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.ybuttonConfirmLoadNew.Hide();
			this.enummenubuttonConfirmUpdate.Hide();
			this.ycheckDontChangeSellPrice.Hide();
			this.Hide();
		}
	}
}
