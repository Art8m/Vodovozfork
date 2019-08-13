
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Complaints
{
	public partial class CreateInnerComplaintView
	{
		private global::Gtk.VBox vboxDialog;

		private global::Gtk.HBox hboxDialogButtons;

		private global::Gamma.GtkWidgets.yButton buttonSave;

		private global::Gamma.GtkWidgets.yButton buttonCancel;

		private global::Gtk.Table tableFields;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView ytextviewComplaintText;

		private global::Vodovoz.Views.Complaints.GuiltyItemsView guiltyitemsview;

		private global::Gtk.Label labelComplaintText;

		private global::Gtk.Label labelGuilty;

		private global::Gtk.HSeparator hseparator1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Complaints.CreateInnerComplaintView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Complaints.CreateInnerComplaintView";
			// Container child Vodovoz.Views.Complaints.CreateInnerComplaintView.Gtk.Container+ContainerChild
			this.vboxDialog = new global::Gtk.VBox();
			this.vboxDialog.Name = "vboxDialog";
			this.vboxDialog.Spacing = 6;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hboxDialogButtons = new global::Gtk.HBox();
			this.hboxDialogButtons.Name = "hboxDialogButtons";
			this.hboxDialogButtons.Spacing = 6;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonSave = new global::Gamma.GtkWidgets.yButton();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hboxDialogButtons.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gamma.GtkWidgets.yButton();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hboxDialogButtons.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vboxDialog.Add(this.hboxDialogButtons);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hboxDialogButtons]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.tableFields = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowSpacing = ((uint)(6));
			this.tableFields.ColumnSpacing = ((uint)(6));
			// Container child tableFields.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewComplaintText = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComplaintText.CanFocus = true;
			this.ytextviewComplaintText.Name = "ytextviewComplaintText";
			this.GtkScrolledWindow.Add(this.ytextviewComplaintText);
			this.tableFields.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableFields[this.GtkScrolledWindow]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			// Container child tableFields.Gtk.Table+TableChild
			this.guiltyitemsview = new global::Vodovoz.Views.Complaints.GuiltyItemsView();
			this.guiltyitemsview.Events = ((global::Gdk.EventMask)(256));
			this.guiltyitemsview.Name = "guiltyitemsview";
			this.tableFields.Add(this.guiltyitemsview);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableFields[this.guiltyitemsview]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelComplaintText = new global::Gtk.Label();
			this.labelComplaintText.Name = "labelComplaintText";
			this.labelComplaintText.Xalign = 1F;
			this.labelComplaintText.Yalign = 0F;
			this.labelComplaintText.LabelProp = global::Mono.Unix.Catalog.GetString("Проблема:");
			this.tableFields.Add(this.labelComplaintText);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelComplaintText]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFields.Gtk.Table+TableChild
			this.labelGuilty = new global::Gtk.Label();
			this.labelGuilty.Name = "labelGuilty";
			this.labelGuilty.Xalign = 1F;
			this.labelGuilty.Yalign = 0F;
			this.labelGuilty.LabelProp = global::Mono.Unix.Catalog.GetString("Виновники:");
			this.tableFields.Add(this.labelGuilty);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableFields[this.labelGuilty]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vboxDialog.Add(this.tableFields);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.tableFields]));
			w11.Position = 1;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vboxDialog.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hseparator1]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.Add(this.vboxDialog);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
