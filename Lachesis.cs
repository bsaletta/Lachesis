using System;
using Gtk;

namespace Lachesis
{
	public class Lachesis{
		public static void Main(String[] args){
			Application.Init ();
			Window mainWindow = new Window ("Lachesis");

			mainWindow.ShowAll ();
			Application.Run ();
		}
	}

}

