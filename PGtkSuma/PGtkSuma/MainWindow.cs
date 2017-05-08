using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void Sumar (object sender, EventArgs e)
	{
		Decimal n1 = Decimal.Parse(s1.Text);
		Decimal n2 = Decimal.Parse(s2.Text);
		Decimal resu = n1 + n2;
		res.Text = resu.ToString();
	}
}
