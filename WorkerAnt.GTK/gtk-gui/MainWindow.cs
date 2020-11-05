
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action preferencesAction;

	private global::Gtk.Action aboutAction;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button button1;

	private global::Gtk.Button button2;

	private global::Gtk.Toolbar toolbar2;

	private global::Gtk.RadioButton radiobutton1;

	private global::Gtk.RadioButton radiobutton2;

	private global::Gtk.RadioButton radiobutton3;

	private global::Gtk.RadioButton radiobutton4;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.preferencesAction = new global::Gtk.Action("preferencesAction", null, null, "gtk-preferences");
		w1.Add(this.preferencesAction, null);
		this.aboutAction = new global::Gtk.Action("aboutAction", null, null, "gtk-about");
		w1.Add(this.aboutAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.WidthRequest = 400;
		this.HeightRequest = 300;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-dialog-warning", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.FocusOnClick = false;
		this.button1.Xalign = 1F;
		this.button1.Yalign = 1F;
		this.button1.BorderWidth = ((uint)(1));
		this.button1.Label = global::Mono.Unix.Catalog.GetString("     Start     ");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w2.X = 322;
		w2.Y = 264;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("      Set       ");
		this.fixed1.Add(this.button2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
		w3.X = 246;
		w3.Y = 264;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar2\'><toolitem/><toolitem/><toolitem name=\'preferencesAct" +
				"ion\' action=\'preferencesAction\'/><toolitem name=\'aboutAction\' action=\'aboutActio" +
				"n\'/></toolbar></ui>");
		this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar2")));
		this.toolbar2.WidthRequest = 400;
		this.toolbar2.HeightRequest = 35;
		this.toolbar2.Name = "toolbar2";
		this.toolbar2.ShowArrow = false;
		this.toolbar2.ToolbarStyle = ((global::Gtk.ToolbarStyle)(0));
		this.toolbar2.IconSize = ((global::Gtk.IconSize)(2));
		this.fixed1.Add(this.toolbar2);
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Recovery"));
		this.radiobutton1.CanFocus = true;
		this.radiobutton1.Active = false;
		this.radiobutton1.DrawIndicator = true;
		this.radiobutton1.UseUnderline = true;
		this.radiobutton1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.fixed1.Add(this.radiobutton1);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton1]));
		w5.X = 10;
		w5.Y = 45;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Smart"));
		this.radiobutton2.CanFocus = true;
		this.radiobutton2.Name = "radiobutton2";
		this.radiobutton2.Active = false;
		this.radiobutton2.DrawIndicator = true;
		this.radiobutton2.UseUnderline = true;
		this.radiobutton2.Group = this.radiobutton1.Group;
		this.fixed1.Add(this.radiobutton2);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton2]));
		w6.X = 10;
		w6.Y = 75;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton3 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Productive"));
		this.radiobutton3.CanFocus = true;
		this.radiobutton3.Name = "radiobutton3";
		this.radiobutton3.Active = false;
		this.radiobutton3.DrawIndicator = true;
		this.radiobutton3.UseUnderline = true;
		this.radiobutton3.Group = this.radiobutton1.Group;
		this.fixed1.Add(this.radiobutton3);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton3]));
		w7.X = 10;
		w7.Y = 105;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radiobutton4 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Manual"));
		this.radiobutton4.CanFocus = true;
		this.radiobutton4.Name = "radiobutton4";
		this.radiobutton4.Active = false;
		this.radiobutton4.DrawIndicator = true;
		this.radiobutton4.UseUnderline = true;
		this.radiobutton4.Group = this.radiobutton1.Group;
		this.fixed1.Add(this.radiobutton4);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.radiobutton4]));
		w8.X = 219;
		w8.Y = 52;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
	}
}
