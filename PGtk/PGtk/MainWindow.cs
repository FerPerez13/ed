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
		if (label2.Text == "Adios") {
			Application.Quit ();
			a.RetVal = true;
		} else {
			label2.Text = "Adios";
			Application.Run();
		}
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		if (entry1.Text == "") {
			label2.Text = "Adios";
		} else {
			label2.Text = "Hola " + entry1.Text;
		}
	}


	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		Application.Quit ();
	}


	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		label2.Text = "Hola ";
	}
}
