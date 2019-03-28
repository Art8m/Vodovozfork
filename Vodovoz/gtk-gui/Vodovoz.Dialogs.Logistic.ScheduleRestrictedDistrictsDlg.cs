
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs.Logistic
{
	public partial class ScheduleRestrictedDistrictsDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonSave;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VBox vbox5;

		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow scrollDistricts;

		private global::Gamma.GtkWidgets.yTreeView ytreeDistricts;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonAddDistrict;

		private global::Gtk.Button btnEditDistrict;

		private global::Gtk.Button buttonDeleteDistrict;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vboxSchedules;

		private global::Gtk.HBox hbox3;

		private global::Gtk.VBox vboxButtons;

		private global::Gtk.RadioButton btnToday;

		private global::Gtk.RadioButton btnMonday;

		private global::Gtk.RadioButton btnTuesday;

		private global::Gtk.RadioButton btnWednesday;

		private global::Gtk.RadioButton btnThursday;

		private global::Gtk.RadioButton btnFriday;

		private global::Gtk.RadioButton btnSaturday;

		private global::Gtk.RadioButton btnSunday;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeSchedules;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button buttonAddSchedule;

		private global::Gtk.Button buttonDeleteSchedule;

		private global::Gtk.VBox vboxGeographicGroups;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView yTreeGeographicGroups;

		private global::Gtk.HButtonBox hbuttonbox2;

		private global::Gtk.Button btnAddGeographicGroup;

		private global::Gtk.Button btnRemoveGeographicGroup;

		private global::Gtk.VBox vbox4;

		private global::GMap.NET.GtkSharp.GMapControl gmapWidget;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button buttonCreateBorder;

		private global::Gtk.Button buttonRemoveBorder;

		private global::Gtk.Button buttonAddVertex;

		private global::Gtk.Button buttonMoveVertex;

		private global::Gtk.Button buttonRemoveVertex;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboMapType;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.Logistic.ScheduleRestrictedDistrictsDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.Logistic.ScheduleRestrictedDistrictsDlg";
			// Container child Vodovoz.Dialogs.Logistic.ScheduleRestrictedDistrictsDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			this.hbox4.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonSave]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrollDistricts = new global::Gtk.ScrolledWindow();
			this.scrollDistricts.Name = "scrollDistricts";
			this.scrollDistricts.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.scrollDistricts.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrollDistricts.Gtk.Container+ContainerChild
			this.ytreeDistricts = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeDistricts.CanFocus = true;
			this.ytreeDistricts.Name = "ytreeDistricts";
			this.scrollDistricts.Add(this.ytreeDistricts);
			this.vbox2.Add(this.scrollDistricts);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrollDistricts]));
			w4.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonAddDistrict = new global::Gtk.Button();
			this.buttonAddDistrict.CanFocus = true;
			this.buttonAddDistrict.Name = "buttonAddDistrict";
			this.buttonAddDistrict.UseUnderline = true;
			this.buttonAddDistrict.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			this.hbox2.Add(this.buttonAddDistrict);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonAddDistrict]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnEditDistrict = new global::Gtk.Button();
			this.btnEditDistrict.CanFocus = true;
			this.btnEditDistrict.Name = "btnEditDistrict";
			this.btnEditDistrict.UseUnderline = true;
			this.btnEditDistrict.Label = global::Mono.Unix.Catalog.GetString("Стоимость\nдоставки");
			this.hbox2.Add(this.btnEditDistrict);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnEditDistrict]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonDeleteDistrict = new global::Gtk.Button();
			this.buttonDeleteDistrict.CanFocus = true;
			this.buttonDeleteDistrict.Name = "buttonDeleteDistrict";
			this.buttonDeleteDistrict.UseUnderline = true;
			this.buttonDeleteDistrict.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			this.hbox2.Add(this.buttonDeleteDistrict);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonDeleteDistrict]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox5.Add(this.vbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox2]));
			w9.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxSchedules = new global::Gtk.VBox();
			this.vboxSchedules.Name = "vboxSchedules";
			this.vboxSchedules.Spacing = 6;
			// Container child vboxSchedules.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vboxButtons = new global::Gtk.VBox();
			this.vboxButtons.Name = "vboxButtons";
			this.vboxButtons.Spacing = 6;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnToday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("ДД"));
			this.btnToday.CanFocus = true;
			this.btnToday.Name = "btnToday";
			this.btnToday.DrawIndicator = false;
			this.btnToday.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.vboxButtons.Add(this.btnToday);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnToday]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnMonday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("ПН"));
			this.btnMonday.CanFocus = true;
			this.btnMonday.Name = "btnMonday";
			this.btnMonday.DrawIndicator = false;
			this.btnMonday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnMonday);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnMonday]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnTuesday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("ВТ"));
			this.btnTuesday.CanFocus = true;
			this.btnTuesday.Name = "btnTuesday";
			this.btnTuesday.DrawIndicator = false;
			this.btnTuesday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnTuesday);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnTuesday]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnWednesday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("СР"));
			this.btnWednesday.CanFocus = true;
			this.btnWednesday.Name = "btnWednesday";
			this.btnWednesday.DrawIndicator = false;
			this.btnWednesday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnWednesday);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnWednesday]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnThursday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("ЧТ"));
			this.btnThursday.CanFocus = true;
			this.btnThursday.Name = "btnThursday";
			this.btnThursday.DrawIndicator = false;
			this.btnThursday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnThursday);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnThursday]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnFriday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("ПТ"));
			this.btnFriday.CanFocus = true;
			this.btnFriday.Name = "btnFriday";
			this.btnFriday.DrawIndicator = false;
			this.btnFriday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnFriday);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnFriday]));
			w15.Position = 5;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnSaturday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("СБ"));
			this.btnSaturday.CanFocus = true;
			this.btnSaturday.Name = "btnSaturday";
			this.btnSaturday.DrawIndicator = false;
			this.btnSaturday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnSaturday);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnSaturday]));
			w16.Position = 6;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vboxButtons.Gtk.Box+BoxChild
			this.btnSunday = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("ВС"));
			this.btnSunday.CanFocus = true;
			this.btnSunday.Name = "btnSunday";
			this.btnSunday.DrawIndicator = false;
			this.btnSunday.Group = this.btnToday.Group;
			this.vboxButtons.Add(this.btnSunday);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vboxButtons[this.btnSunday]));
			w17.Position = 7;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox3.Add(this.vboxButtons);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vboxButtons]));
			w18.Position = 0;
			w18.Expand = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeSchedules = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeSchedules.CanFocus = true;
			this.ytreeSchedules.Name = "ytreeSchedules";
			this.ytreeSchedules.EnableSearch = false;
			this.GtkScrolledWindow.Add(this.ytreeSchedules);
			this.hbox3.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.GtkScrolledWindow]));
			w20.Position = 1;
			this.vboxSchedules.Add(this.hbox3);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vboxSchedules[this.hbox3]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vboxSchedules.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonAddSchedule = new global::Gtk.Button();
			this.buttonAddSchedule.CanFocus = true;
			this.buttonAddSchedule.Name = "buttonAddSchedule";
			this.buttonAddSchedule.UseUnderline = true;
			this.buttonAddSchedule.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			this.hbox7.Add(this.buttonAddSchedule);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonAddSchedule]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonDeleteSchedule = new global::Gtk.Button();
			this.buttonDeleteSchedule.CanFocus = true;
			this.buttonDeleteSchedule.Name = "buttonDeleteSchedule";
			this.buttonDeleteSchedule.UseUnderline = true;
			this.buttonDeleteSchedule.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			this.hbox7.Add(this.buttonDeleteSchedule);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonDeleteSchedule]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.vboxSchedules.Add(this.hbox7);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vboxSchedules[this.hbox7]));
			w24.PackType = ((global::Gtk.PackType)(1));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.hbox1.Add(this.vboxSchedules);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vboxSchedules]));
			w25.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vboxGeographicGroups = new global::Gtk.VBox();
			this.vboxGeographicGroups.Name = "vboxGeographicGroups";
			this.vboxGeographicGroups.Spacing = 6;
			// Container child vboxGeographicGroups.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.yTreeGeographicGroups = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreeGeographicGroups.CanFocus = true;
			this.yTreeGeographicGroups.Name = "yTreeGeographicGroups";
			this.yTreeGeographicGroups.EnableSearch = false;
			this.GtkScrolledWindow1.Add(this.yTreeGeographicGroups);
			this.vboxGeographicGroups.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vboxGeographicGroups[this.GtkScrolledWindow1]));
			w27.Position = 0;
			// Container child vboxGeographicGroups.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox();
			this.hbuttonbox2.Name = "hbuttonbox2";
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnAddGeographicGroup = new global::Gtk.Button();
			this.btnAddGeographicGroup.CanFocus = true;
			this.btnAddGeographicGroup.Name = "btnAddGeographicGroup";
			this.btnAddGeographicGroup.UseUnderline = true;
			this.btnAddGeographicGroup.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			this.hbuttonbox2.Add(this.btnAddGeographicGroup);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnAddGeographicGroup]));
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnRemoveGeographicGroup = new global::Gtk.Button();
			this.btnRemoveGeographicGroup.CanFocus = true;
			this.btnRemoveGeographicGroup.Name = "btnRemoveGeographicGroup";
			this.btnRemoveGeographicGroup.UseUnderline = true;
			this.btnRemoveGeographicGroup.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			this.hbuttonbox2.Add(this.btnRemoveGeographicGroup);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnRemoveGeographicGroup]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.vboxGeographicGroups.Add(this.hbuttonbox2);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vboxGeographicGroups[this.hbuttonbox2]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.hbox1.Add(this.vboxGeographicGroups);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vboxGeographicGroups]));
			w31.Position = 1;
			this.vbox5.Add(this.hbox1);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox1]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			this.hbox5.Add(this.vbox5);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox5]));
			w33.Position = 0;
			w33.Expand = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.gmapWidget = new global::GMap.NET.GtkSharp.GMapControl();
			this.gmapWidget.Name = "gmapWidget";
			this.gmapWidget.MaxZoom = 24;
			this.gmapWidget.MinZoom = 0;
			this.gmapWidget.MouseWheelZoomEnabled = true;
			this.gmapWidget.ShowTileGridLines = false;
			this.gmapWidget.GrayScaleMode = false;
			this.gmapWidget.NegativeMode = false;
			this.gmapWidget.HasFrame = false;
			this.gmapWidget.Bearing = 0F;
			this.gmapWidget.Zoom = 9D;
			this.gmapWidget.RoutesEnabled = true;
			this.gmapWidget.PolygonsEnabled = true;
			this.gmapWidget.MarkersEnabled = true;
			this.gmapWidget.CanDragMap = true;
			this.vbox4.Add(this.gmapWidget);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.gmapWidget]));
			w34.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonCreateBorder = new global::Gtk.Button();
			this.buttonCreateBorder.CanFocus = true;
			this.buttonCreateBorder.Name = "buttonCreateBorder";
			this.buttonCreateBorder.UseUnderline = true;
			this.buttonCreateBorder.Label = global::Mono.Unix.Catalog.GetString("Создать границу");
			this.hbox6.Add(this.buttonCreateBorder);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonCreateBorder]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonRemoveBorder = new global::Gtk.Button();
			this.buttonRemoveBorder.CanFocus = true;
			this.buttonRemoveBorder.Name = "buttonRemoveBorder";
			this.buttonRemoveBorder.UseUnderline = true;
			this.buttonRemoveBorder.Label = global::Mono.Unix.Catalog.GetString("Удалить границу");
			this.hbox6.Add(this.buttonRemoveBorder);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonRemoveBorder]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonAddVertex = new global::Gtk.Button();
			this.buttonAddVertex.CanFocus = true;
			this.buttonAddVertex.Name = "buttonAddVertex";
			this.buttonAddVertex.UseUnderline = true;
			this.buttonAddVertex.Label = global::Mono.Unix.Catalog.GetString("Добавить вершину");
			this.hbox6.Add(this.buttonAddVertex);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonAddVertex]));
			w37.Position = 2;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonMoveVertex = new global::Gtk.Button();
			this.buttonMoveVertex.CanFocus = true;
			this.buttonMoveVertex.Name = "buttonMoveVertex";
			this.buttonMoveVertex.UseUnderline = true;
			this.buttonMoveVertex.Label = global::Mono.Unix.Catalog.GetString("Переместить вершину");
			this.hbox6.Add(this.buttonMoveVertex);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonMoveVertex]));
			w38.Position = 3;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonRemoveVertex = new global::Gtk.Button();
			this.buttonRemoveVertex.CanFocus = true;
			this.buttonRemoveVertex.Name = "buttonRemoveVertex";
			this.buttonRemoveVertex.UseUnderline = true;
			this.buttonRemoveVertex.Label = global::Mono.Unix.Catalog.GetString("Удалить вершину");
			this.hbox6.Add(this.buttonRemoveVertex);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonRemoveVertex]));
			w39.Position = 4;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.yenumcomboMapType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboMapType.Name = "yenumcomboMapType";
			this.yenumcomboMapType.ShowSpecialStateAll = false;
			this.yenumcomboMapType.ShowSpecialStateNot = false;
			this.yenumcomboMapType.UseShortTitle = false;
			this.yenumcomboMapType.DefaultFirst = true;
			this.hbox6.Add(this.yenumcomboMapType);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.yenumcomboMapType]));
			w40.PackType = ((global::Gtk.PackType)(1));
			w40.Position = 5;
			w40.Expand = false;
			w40.Fill = false;
			this.vbox4.Add(this.hbox6);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox6]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			this.hbox5.Add(this.vbox4);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox4]));
			w42.Position = 1;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w43.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
			this.buttonAddDistrict.Clicked += new global::System.EventHandler(this.OnButtonAddDistrictClicked);
			this.btnEditDistrict.Clicked += new global::System.EventHandler(this.OnBtnEditDistrictClicked);
			this.buttonDeleteDistrict.Clicked += new global::System.EventHandler(this.OnButtonDeleteDistrictClicked);
			this.btnToday.Clicked += new global::System.EventHandler(this.OnBtnTodayClicked);
			this.btnMonday.Clicked += new global::System.EventHandler(this.OnBtnMondayClicked);
			this.btnTuesday.Clicked += new global::System.EventHandler(this.OnBtnTuesdayClicked);
			this.btnWednesday.Clicked += new global::System.EventHandler(this.OnBtnWednesdayClicked);
			this.btnThursday.Clicked += new global::System.EventHandler(this.OnBtnThursdayClicked);
			this.btnFriday.Clicked += new global::System.EventHandler(this.OnBtnFridayClicked);
			this.btnSaturday.Clicked += new global::System.EventHandler(this.OnBtnSaturdayClicked);
			this.btnSunday.Clicked += new global::System.EventHandler(this.OnBtnSundayClicked);
			this.buttonAddSchedule.Clicked += new global::System.EventHandler(this.OnButtonAddScheduleClicked);
			this.buttonDeleteSchedule.Clicked += new global::System.EventHandler(this.OnButtonDeleteScheduleClicked);
			this.btnAddGeographicGroup.Clicked += new global::System.EventHandler(this.OnBtnAddGeographicGroupClicked);
			this.btnRemoveGeographicGroup.Clicked += new global::System.EventHandler(this.OnBtnRemoveGeographicGroupClicked);
			this.gmapWidget.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler(this.OnGmapWidgetButtonReleaseEvent);
			this.buttonCreateBorder.Clicked += new global::System.EventHandler(this.OnButtonCreateBorderClicked);
			this.buttonRemoveBorder.Clicked += new global::System.EventHandler(this.OnButtonRemoveBorderClicked);
			this.buttonAddVertex.Clicked += new global::System.EventHandler(this.OnButtonAddVertexClicked);
			this.buttonMoveVertex.Clicked += new global::System.EventHandler(this.OnButtonMoveVertexClicked);
			this.buttonRemoveVertex.Clicked += new global::System.EventHandler(this.OnButtonRemoveVertexClicked);
		}
	}
}
