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
	public partial class LD : Form
	{
		public LD()
		{
			InitializeComponent();
		}

		private void LD_Load(object sender, EventArgs e){}

		private void textBox1_TextChanged(object sender, EventArgs e){}
		private void EmailBox2_TextChanged(object sender, EventArgs e){}
		private void PaswordBox4_TextChanged(object sender, EventArgs e)
		{
			checkBox1_CheckedChanged(sender, e);
		}
		private void IDBox3_TextChanged(object sender, EventArgs e){}
		private void login_button1_Click(object sender, EventArgs e)
		{

			var un = NameBox1.Text;
			string em = EmailBox2.Text;
			string pass = PaswordBox4.Text;
			string id = IDBox3.Text;
			string dbo = "TA_PROJECT";
			string table = "LD";
			string idx = "ld_id";
			login log = new login();

			bool check = log.signin(un, pass, em, id, dbo, table,idx);
			if (check == false)
			{
				MessageBox.Show("False");
			}
			else
			{
				Form2 lal = new Form2(int.Parse(IDBox3.Text));

				lal.Visible = true;
				this.Visible = false;
			}
		}


		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				PaswordBox4.PasswordChar = '\0'; // Show the password in plain text
			}
			else
			{
				PaswordBox4.PasswordChar = '*'; // Hide the password using a character (e.g., '*')
			}
		}




		private void exit_label_Click(object sender, EventArgs e)
		{
			Application.Exit();
			//this.Close();
		}









		private void panel4_Paint(object sender, PaintEventArgs e){}
		private void panel3_Paint(object sender, PaintEventArgs e){}
		private void panel2_Paint(object sender, PaintEventArgs e){}
		private void panel1_Paint(object sender, PaintEventArgs e) {}
		private void pictureBox1_Click(object sender, EventArgs e) {}
		private void LOGINFORM_Click(object sender, EventArgs e) {}
		private void label3_Click(object sender, EventArgs e) {}
		private void label2_Click(object sender, EventArgs e) {}
		private void EMAIL_Click(object sender, EventArgs e) {}
		private void Nametxt_Click(object sender, EventArgs e) {}
		private void label1_Click(object sender, EventArgs e) {}



	}
}
