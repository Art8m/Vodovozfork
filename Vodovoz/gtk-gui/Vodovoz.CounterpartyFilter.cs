
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class CounterpartyFilter
	{
		private global::Gtk.DataBindings.DataVBox datavbox1;
		
		private global::Gtk.DataBindings.DataHBox datahbox1;
		
		private global::Gtk.Label label1;
		
		private global::QSOrmProject.EnumComboBox comboCounterpartyType;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.CounterpartyFilter
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.CounterpartyFilter";
			// Container child Vodovoz.CounterpartyFilter.Gtk.Container+ContainerChild
			this.datavbox1 = new global::Gtk.DataBindings.DataVBox ();
			this.datavbox1.Name = "datavbox1";
			this.datavbox1.Spacing = 6;
			this.datavbox1.InheritedDataSource = false;
			this.datavbox1.InheritedBoundaryDataSource = false;
			this.datavbox1.InheritedDataSource = false;
			this.datavbox1.InheritedBoundaryDataSource = false;
			// Container child datavbox1.Gtk.Box+BoxChild
			this.datahbox1 = new global::Gtk.DataBindings.DataHBox ();
			this.datahbox1.Name = "datahbox1";
			this.datahbox1.Spacing = 6;
			this.datahbox1.InheritedDataSource = false;
			this.datahbox1.InheritedBoundaryDataSource = false;
			this.datahbox1.InheritedDataSource = false;
			this.datahbox1.InheritedBoundaryDataSource = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Тип контрагента:");
			this.datahbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child datahbox1.Gtk.Box+BoxChild
			this.comboCounterpartyType = new global::QSOrmProject.EnumComboBox ();
			this.comboCounterpartyType.Name = "comboCounterpartyType";
			this.comboCounterpartyType.ItemsEnumName = "";
			this.comboCounterpartyType.ShowSpecialStateAll = true;
			this.comboCounterpartyType.ShowSpecialStateNot = false;
			this.datahbox1.Add (this.comboCounterpartyType);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.datahbox1 [this.comboCounterpartyType]));
			w2.Position = 1;
			this.datavbox1.Add (this.datahbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.datavbox1 [this.datahbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.datavbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.comboCounterpartyType.EnumItemSelected += new global::System.EventHandler<QSOrmProject.EnumItemClickedEventArgs> (this.OnComboCounterpartyTypeEnumItemSelected);
		}
	}
}
