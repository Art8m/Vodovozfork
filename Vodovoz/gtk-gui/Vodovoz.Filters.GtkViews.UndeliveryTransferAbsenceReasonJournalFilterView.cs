﻿
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Filters.GtkViews
{
	public partial class UndeliveryTransferAbsenceReasonJournalFilterView
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Label labelDateCreate;

		private global::Gamma.Widgets.yDatePeriodPicker ydateperiodpickerCreateEventDate;

		private global::Gamma.GtkWidgets.yCheckButton ychkIsArchive;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Filters.GtkViews.UndeliveryTransferAbsenceReasonJournalFilterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Filters.GtkViews.UndeliveryTransferAbsenceReasonJournalFilterView";
			// Container child Vodovoz.Filters.GtkViews.UndeliveryTransferAbsenceReasonJournalFilterView.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelDateCreate = new global::Gtk.Label();
			this.labelDateCreate.Name = "labelDateCreate";
			this.labelDateCreate.Xalign = 1F;
			this.labelDateCreate.LabelProp = global::Mono.Unix.Catalog.GetString("Дата создания:");
			this.hbox1.Add(this.labelDateCreate);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.labelDateCreate]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ydateperiodpickerCreateEventDate = new global::Gamma.Widgets.yDatePeriodPicker();
			this.ydateperiodpickerCreateEventDate.Events = ((global::Gdk.EventMask)(256));
			this.ydateperiodpickerCreateEventDate.Name = "ydateperiodpickerCreateEventDate";
			this.ydateperiodpickerCreateEventDate.StartDate = new global::System.DateTime(0);
			this.ydateperiodpickerCreateEventDate.EndDate = new global::System.DateTime(0);
			this.hbox1.Add(this.ydateperiodpickerCreateEventDate);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ydateperiodpickerCreateEventDate]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ychkIsArchive = new global::Gamma.GtkWidgets.yCheckButton();
			this.ychkIsArchive.CanFocus = true;
			this.ychkIsArchive.Name = "ychkIsArchive";
			this.ychkIsArchive.Label = global::Mono.Unix.Catalog.GetString("Показывать архивные");
			this.ychkIsArchive.DrawIndicator = true;
			this.ychkIsArchive.UseUnderline = true;
			this.hbox1.Add(this.ychkIsArchive);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ychkIsArchive]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}