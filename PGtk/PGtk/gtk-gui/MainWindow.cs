
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label label1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Button button3;
	private global::Gtk.Label label2;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button button4;
	private global::Gtk.Label label3;
	private global::Gtk.Button button2;
	private global::Gtk.HButtonBox hbuttonbox2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Dime tu nombre:");
		this.hbox2.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.hbox2.Add (this.entry1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entry1]));
		w2.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button ();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		// Container child button3.Gtk.Container+ContainerChild
		global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w4 = new global::Gtk.HBox ();
		w4.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w5 = new global::Gtk.Image ();
		w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
		w4.Add (w5);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w7 = new global::Gtk.Label ();
		w7.LabelProp = global::Mono.Unix.Catalog.GetString ("_Sí");
		w7.UseUnderline = true;
		w4.Add (w7);
		w3.Add (w4);
		this.button3.Add (w3);
		this.hbox2.Add (this.button3);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button3]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Mira que sorpresa");
		this.vbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label2]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		// Container child button4.Gtk.Container+ContainerChild
		global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w15 = new global::Gtk.HBox ();
		w15.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w16 = new global::Gtk.Image ();
		w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
		w15.Add (w16);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w18 = new global::Gtk.Label ();
		w15.Add (w18);
		w14.Add (w15);
		this.button4.Add (w14);
		this.hbox1.Add (this.button4);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button4]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("¿Quieres que cierre la aplicación?");
		this.hbox1.Add (this.label3);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		// Container child button2.Gtk.Container+ContainerChild
		global::Gtk.Alignment w24 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w25 = new global::Gtk.HBox ();
		w25.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w26 = new global::Gtk.Image ();
		w26.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
		w25.Add (w26);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w28 = new global::Gtk.Label ();
		w25.Add (w28);
		w24.Add (w25);
		this.button2.Add (w24);
		this.hbox1.Add (this.button2);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button2]));
		w32.Position = 2;
		w32.Expand = false;
		w32.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w33.Position = 2;
		w33.Expand = false;
		w33.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox2 = new global::Gtk.HButtonBox ();
		this.hbuttonbox2.Name = "hbuttonbox2";
		this.vbox1.Add (this.hbuttonbox2);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox2]));
		w34.Position = 3;
		w34.Expand = false;
		w34.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 434;
		this.DefaultHeight = 93;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
	}
}
