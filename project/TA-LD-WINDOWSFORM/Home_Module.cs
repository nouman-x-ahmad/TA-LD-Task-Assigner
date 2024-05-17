using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;

namespace TA_project
{
	public partial class Home_Module : Form
	{
		public Home_Module()
		{
			InitializeComponent();
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			//RoundedPanel roundedPanel= new RoundedPanel();
			//Admin adm= new Admin();
			//adm.ShowDialog();
			//Admin jumpw = new Admin();
			//jumpw.Show();

		}
	
		private void TITLE_Click(object sender, EventArgs e)
		{
			///TITLE.

			//this.BringToFront();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			//this.Close();
		}

		private void admin_label_Click(object sender, EventArgs e)
		{
			
			OpenNewFormAndCloseCurrent();

		}
		private void OpenNewFormAndCloseCurrent()
		{

			// Instantiate the new form
			Admin adminForm = new Admin();

			// Show the new form
			adminForm.Show();
			//this.Hide();
			// Close the current form
			
		}

		private void Faculty_label4_Click(object sender, EventArgs e)
		{
			Faculty fac=new Faculty();
			fac.Show();
			//this.Hide();
		}

		private void TA_label5_Click(object sender, EventArgs e)
		{
			TA t=new TA();
			t.Show();
			//this.Hide();
		}

		private void LD_label4_Click(object sender, EventArgs e)
		{
			LD lD=new LD();
			lD.Show();
			//this.Hide();
		}

		//to delete the top bar..;;;;


	}

}
