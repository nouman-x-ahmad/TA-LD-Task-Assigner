using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_project
{
	public partial class Faculty : Form
	{
		public Faculty()
		{
			InitializeComponent();
		}

		private void NameBox1_TextChanged(object sender, EventArgs e)
		{}
		private void EmailBox2_TextChanged(object sender, EventArgs e)
		{}
		private void IDBox3_TextChanged(object sender, EventArgs e)
		{}
		private void PaswordBox4_TextChanged(object sender, EventArgs e)
		{
			checkBox1_CheckedChanged(sender, e);
		}
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				PaswordBox4.PasswordChar = '\0'; // Show the password
			}
			else
			{
				PaswordBox4.PasswordChar = '*'; // Hide the password 
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			var un = NameBox1.Text;
			string em = EmailBox2.Text;
			string pass = PaswordBox4.Text;
			string id = IDBox3.Text;
			string dbo = "TA_PROJECT";
			string table = "Faculty";
			string tbo = "faculty_id";
			string nme = "faculty_Name";
			login log = new login();

			bool check = log.signin(un, pass, em, id, dbo,table,tbo,nme);
			if (check == false)
			{
				MessageBox.Show("False");
			}
			else
			{
				//call the faculty profile here......;;;;;;<---------------------
				
					Form3 fal = new Form3(int.Parse(IDBox3.Text));
					fal.Visible = true;
					this.Visible = false;
			}

		}

		private void exit_label_Click(object sender, EventArgs e)
		{
			Application.Exit();
			//this.Close();
		}

		private void Faculty_Load(object sender, EventArgs e)
		{

		}
	}
}
