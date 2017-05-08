using System;
using System.Data;

namespace CCategoria
{
	public partial class CategoriaView : Gtk.Window
	{
		public CategoriaView () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			saveAction.Activated += delegate {
				string nombre = entryNombre.Text;
				IDbCommand dbCommand = App.Instace.DbConnection.CreateCommand();
				dbCommand.CommandText = "insert into categoria (nombre) values (@nombre)";
				DbHelper.DbCommandAddParameter(dbCommand, "nombre", nombre);
				dbCommand.ExecuteNonQuery();
			};
		}
	}
}

