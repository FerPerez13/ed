using CCategoria;
using Gtk;
using System;
using System.Data;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText (), "text", 1);

		ListStore listStore = new ListStore (typeof(long), typeof(string));
		treeView.Model = listStore;

		fillListStore (listStore);

		deleteAction.Sensitive = false;

		newAction.Activated += delegate {
			new CategoriaView();
		};

		deleteAction.Activated += delegate {
			if (!WindowHelper.Confirm(this, "¿Quieres eliminar el registro?"))
				return;

			TreeIter treeIter;
			treeView.Selection.GetSelected(out treeIter);
			object id = listStore.GetValue(treeIter, 0);

			IDbCommand dbCommand = App.Instace.DbConnection.CreateCommand();
			dbCommand.CommandText = "delete from categoria where id = @id";
			DbHelper.DbCommandAddParameter(dbCommand, "id", id);
			dbCommand.ExecuteNonQuery();
		};

		refreshAction.Activated += delegate {
			fillListStore(listStore);
		};

		treeView.Selection.Changed += delegate {
			deleteAction.Sensitive = treeView.Selection.CountSelectedRows() > 0;
		};
	}

	private void fillListStore (ListStore listStore) {
		listStore.Clear ();
		IDbCommand dbCommand = App.Instace.DbConnection.CreateCommand ();
		dbCommand.CommandText = "select * from categoria order by id";
		IDataReader dataReader = dbCommand.ExecuteReader ();
		while (dataReader.Read())
			listStore.AppendValues (dataReader ["id"], dataReader ["nombre"]);
		dataReader.Close ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
