using System;
using Gtk;

namespace Lachesis{
	public class MainWindow : Window{
		public MainWindow():base("Lachesis"){
			Application.Init ();
			SetDefaultSize (250, 200);
			DeleteEvent +=Quit;
			#region --Menu Bar Initialization--
			MenuBar mb = new MenuBar();

			Menu fileMenu = new Menu ();
			MenuItem file = new MenuItem ("File");
			file.Submenu = fileMenu;

			MenuItem quit = new MenuItem ("Quit");
			quit.Activated += Quit;
			fileMenu.Append (quit);

			mb.Append (file);

			VBox menuBar = new VBox (false, 2);
			menuBar.PackStart (mb, false, false, 0);

			Add (menuBar);

			#endregion --End--
			#region --Project Initializaition Frame--

			//TODO: Build Project Initialization Frame
			#endregion
			#region --Design Phase Frame--
			//TODO: Build Design Phase Frame
			
			#endregion
			#region --Drawing Release Frame--
			//TODO: Build Drawing Release Frame
			#endregion
			#region --Purchasing And Fabrication Frame--
			//TODO: Build Purchasing and Fabrication Frame

			#endregion
			ShowAll ();
			Application.Run ();
			}
			void Quit(object sender, EventArgs args){
				Application.Quit ();
			}
		}
	}
