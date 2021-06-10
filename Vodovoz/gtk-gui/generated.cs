﻿
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;

		internal static void Initialize(Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false))
			{
				Stetic.Gui.initialized = true;
				global::Gtk.IconFactory w1 = new global::Gtk.IconFactory();
				global::Gtk.IconSet w2 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.menu.users.png"));
				w1.Add("users", w2);
				global::Gtk.IconSet w3 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.orders.png"));
				w1.Add("order", w3);
				global::Gtk.IconSet w4 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.service.png"));
				w1.Add("service", w4);
				global::Gtk.IconSet w5 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.stock.png"));
				w1.Add("stock", w5);
				global::Gtk.IconSet w6 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.accounting.png"));
				w1.Add("accounting", w6);
				global::Gtk.IconSet w7 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.reports.png"));
				w1.Add("report", w7);
				global::Gtk.IconSet w8 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.archive.png"));
				w1.Add("archive", w8);
				global::Gtk.IconSet w9 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.cash.png"));
				w1.Add("cash", w9);
				global::Gtk.IconSet w10 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.logistic.png"));
				w1.Add("logistic", w10);
				global::Gtk.IconSet w11 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.menu.table.png"));
				w1.Add("table", w11);
				global::Gtk.IconSet w12 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("view-filter.png"));
				w1.Add("view-filter", w12);
				global::Gtk.IconSet w13 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.employees.png"));
				w1.Add("employees", w13);
				global::Gtk.IconSet w14 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.menu.logs.png"));
				w1.Add("logs", w14);
				global::Gtk.IconSet w15 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.menu.CRMLogo.png"));
				w1.Add("CRM", w15);
				global::Gtk.IconSet w16 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.complaints.png"));
				w1.Add("complaints", w16);
				global::Gtk.IconSet w17 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.suppliers.png"));
				w1.Add("suppliers", w17);
				global::Gtk.IconSet w18 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.retail.png"));
				w1.Add("retail", w18);
				global::Gtk.IconSet w19 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.phone.phone-disable.png"));
				w1.Add("phone-disable", w19);
				global::Gtk.IconSet w20 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.phone.phone-connected.png"));
				w1.Add("phone-connected", w20);
				global::Gtk.IconSet w21 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.phone.phone-disconnected.png"));
				w1.Add("phone-disconnected", w21);
				global::Gtk.IconSet w22 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.phone.phone-ring.png"));
				w1.Add("phone-ring", w22);
				global::Gtk.IconSet w23 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.phone.phone-talk.png"));
				w1.Add("phone-talk", w23);
				global::Gtk.IconSet w24 = new global::Gtk.IconSet(global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.toolbar.car_service.png"));
				w1.Add("car_events", w24);
				w1.AddDefault();
			}
		}
	}

	internal class BinContainer
	{
		private Gtk.Widget child;

		private Gtk.UIManager uimanager;

		public static BinContainer Attach(Gtk.Bin bin)
		{
			BinContainer bc = new BinContainer();
			bin.SizeRequested += new Gtk.SizeRequestedHandler(bc.OnSizeRequested);
			bin.SizeAllocated += new Gtk.SizeAllocatedHandler(bc.OnSizeAllocated);
			bin.Added += new Gtk.AddedHandler(bc.OnAdded);
			return bc;
		}

		private void OnSizeRequested(object sender, Gtk.SizeRequestedArgs args)
		{
			if ((this.child != null))
			{
				args.Requisition = this.child.SizeRequest();
			}
		}

		private void OnSizeAllocated(object sender, Gtk.SizeAllocatedArgs args)
		{
			if ((this.child != null))
			{
				this.child.Allocation = args.Allocation;
			}
		}

		private void OnAdded(object sender, Gtk.AddedArgs args)
		{
			this.child = args.Widget;
		}

		public void SetUiManager(Gtk.UIManager uim)
		{
			this.uimanager = uim;
			this.child.Realized += new System.EventHandler(this.OnRealized);
		}

		private void OnRealized(object sender, System.EventArgs args)
		{
			if ((this.uimanager != null))
			{
				Gtk.Widget w;
				w = this.child.Toplevel;
				if (((w != null)
							&& typeof(Gtk.Window).IsInstanceOfType(w)))
				{
					((Gtk.Window)(w)).AddAccelGroup(this.uimanager.AccelGroup);
					this.uimanager = null;
				}
			}
		}
	}

	internal class IconLoader
	{
		public static Gdk.Pixbuf LoadIcon(Gtk.Widget widget, string name, Gtk.IconSize size)
		{
			Gdk.Pixbuf res = widget.RenderIcon(name, size, null);
			if ((res != null))
			{
				return res;
			}
			else
			{
				int sz;
				int sy;
				global::Gtk.Icon.SizeLookup(size, out sz, out sy);
				try
				{
					return Gtk.IconTheme.Default.LoadIcon(name, sz, 0);
				}
				catch (System.Exception)
				{
					if ((name != "gtk-missing-image"))
					{
						return Stetic.IconLoader.LoadIcon(widget, "gtk-missing-image", size);
					}
					else
					{
						Gdk.Pixmap pmap = new Gdk.Pixmap(Gdk.Screen.Default.RootWindow, sz, sz);
						Gdk.GC gc = new Gdk.GC(pmap);
						gc.RgbFgColor = new Gdk.Color(255, 255, 255);
						pmap.DrawRectangle(gc, true, 0, 0, sz, sz);
						gc.RgbFgColor = new Gdk.Color(0, 0, 0);
						pmap.DrawRectangle(gc, false, 0, 0, (sz - 1), (sz - 1));
						gc.SetLineAttributes(3, Gdk.LineStyle.Solid, Gdk.CapStyle.Round, Gdk.JoinStyle.Round);
						gc.RgbFgColor = new Gdk.Color(255, 0, 0);
						pmap.DrawLine(gc, (sz / 4), (sz / 4), ((sz - 1)
										- (sz / 4)), ((sz - 1)
										- (sz / 4)));
						pmap.DrawLine(gc, ((sz - 1)
										- (sz / 4)), (sz / 4), (sz / 4), ((sz - 1)
										- (sz / 4)));
						return Gdk.Pixbuf.FromDrawable(pmap, pmap.Colormap, 0, 0, 0, 0, sz, sz);
					}
				}
			}
		}
	}

	internal class ActionGroups
	{
		public static Gtk.ActionGroup GetActionGroup(System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup(type.FullName);
		}

		public static Gtk.ActionGroup GetActionGroup(string name)
		{
			return null;
		}
	}
}
