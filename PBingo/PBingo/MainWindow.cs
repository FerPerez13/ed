using System;
using Gtk;
using System.Diagnostics;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window{	
	//Variables Locales
	private Random random;
	private Gdk.Color greenColor= new Gdk.Color(0,255,0);
	private List<int> numeros = new List<int> ();
	private List<Button> buttons = new List<Button> ();

	public MainWindow (): base (Gtk.WindowType.Toplevel){
		Build ();
		//vbox1.Add(button); //Con esta linea añadimos un boton en toda la pantalla
		random = new Random ();

		Table table = new Table(9,10,true);

		//Forma de sacar las filas y las columnas
		for (uint row=0; row<9; row++) {
			for (uint col=0; col<10; col++) {
				uint index = row * 10 + col;
				int numero = (int)index + 1;
				Button button = new Button ();
				button.Label = numero.ToString();
				button.Visible = true;
				table.Attach (button, col, col+1, row, row+1);
				buttons.Add (button);
				numeros.Add (numero);
			}
		}

		table.Visible = true;
		vbox1.Add (table);

		buttonNumero.Clicked += delegate {
			int numero = getNumero();
			show(numero);
			buttonNumero.Sensitive = numeros.Count>0; // No cerrarse cuando se pongan todos los numeros.
			espeak(numero);
		};

	}

	private int getNumero(){
		int indexAleatorio = random.Next (numeros.Count);
		int numero = numeros[indexAleatorio];
		numeros.RemoveAt(indexAleatorio);
		return numero;
	}

	private void show(int numero){
		label2.Text  = numero.ToString();
		Button button = buttons[numero-1];
		button.ModifyBg (StateType.Normal,greenColor);
	}

	private void espeak (int numero){
		string text = numero.ToString();
		if (text.Length == 2) {
			Process.Start ("espeak", "-v es" + " " + "\"" + text + " " + text [0] + " " + text [1] + "\"");
		} else {
			Process.Start ("espeak", "-v es" + " " + text);
		}
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

}
