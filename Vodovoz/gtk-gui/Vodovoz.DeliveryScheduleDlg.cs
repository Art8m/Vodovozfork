
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class DeliveryScheduleDlg
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table datatable1;

		private global::Gamma.GtkWidgets.yEntry entryName;

		private global::Gtk.HBox hbox1;

		private global::Gamma.Widgets.yTimeEntry entryFrom;

		private global::Gtk.Label label1;

		private global::Gamma.Widgets.yTimeEntry entryTo;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label2;

		private global::Gamma.GtkWidgets.yCheckButton ycheckIsArchive;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.DeliveryScheduleDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.DeliveryScheduleDlg";
			// Container child Vodovoz.DeliveryScheduleDlg.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox4.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox4.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox3.Add(this.hbox4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryName = new global::Gamma.GtkWidgets.yEntry();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.datatable1.Add(this.entryName);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1[this.entryName]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryFrom = new global::Gamma.Widgets.yTimeEntry();
			this.entryFrom.CanFocus = true;
			this.entryFrom.Name = "entryFrom";
			this.entryFrom.IsEditable = true;
			this.entryFrom.InvisibleChar = '●';
			this.entryFrom.ShowSeconds = false;
			this.entryFrom.AutocompleteStep = 15;
			this.entryFrom.DateTime = new global::System.DateTime(0);
			this.entryFrom.Time = new global::System.TimeSpan(0);
			this.hbox1.Add(this.entryFrom);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryFrom]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("До:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryTo = new global::Gamma.Widgets.yTimeEntry();
			this.entryTo.CanFocus = true;
			this.entryTo.Name = "entryTo";
			this.entryTo.IsEditable = true;
			this.entryTo.InvisibleChar = '●';
			this.entryTo.ShowSeconds = false;
			this.entryTo.AutocompleteStep = 15;
			this.entryTo.DateTime = new global::System.DateTime(0);
			this.entryTo.Time = new global::System.TimeSpan(0);
			this.hbox1.Add(this.entryTo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryTo]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.datatable1.Add(this.hbox1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox1]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("C:");
			this.label10.Justify = ((global::Gtk.Justification)(1));
			this.datatable1.Add(this.label10);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label10]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Название:");
			this.datatable1.Add(this.label11);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label11]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Архивный:");
			this.datatable1.Add(this.label2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label2]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.ycheckIsArchive = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckIsArchive.CanFocus = true;
			this.ycheckIsArchive.Name = "ycheckIsArchive";
			this.ycheckIsArchive.Label = "";
			this.ycheckIsArchive.DrawIndicator = true;
			this.ycheckIsArchive.UseUnderline = true;
			this.datatable1.Add(this.ycheckIsArchive);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable1[this.ycheckIsArchive]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.datatable1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.datatable1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
