using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_project
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form2(1));
				Application.Run(new Home_Module());
			//	Application.Run(new Admin());
			//	Application.Run(new TA());
			//Application.Run(new Faculty());
			//Application.Run(new Admin_profile());
			//MessageBox.Show("call a form in program file to start running this project");
		}

	}

}
