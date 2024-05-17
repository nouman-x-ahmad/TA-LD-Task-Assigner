using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TA_project
{
	public partial class TA : Form
	{
		public TA()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{}
		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			checkBox1_CheckedChanged(sender, e);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				PaswordBox4.PasswordChar = '\0'; // Show 
			}
			else
			{
				PaswordBox4.PasswordChar = '*'; // Hide the password 
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{



			var un = Namebox1.Text;
			string em = EmailBox2.Text;
			string pass = PaswordBox4.Text;
			string id = IDBox3.Text;
			string dbo = "TA_PROJECT";
			string table = "TA";
			string idx = " ta_id";
			login log = new login();

			bool check = log.signin(un, pass, em, id, dbo, table,idx);
			if (check == false)
			{
				MessageBox.Show("False");
			}
			else
			{
				Form1 tal = new Form1(int.Parse(IDBox3.Text));

				tal.Visible = true;
				this.Visible = false;
			}



		}

		private void exit_label_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TA_Load(object sender, EventArgs e)
		{

		}
	}
}
