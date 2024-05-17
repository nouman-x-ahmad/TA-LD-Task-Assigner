using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace TA_project
{
	public partial class Admin : Form
	{
		public static Admin Instance;
		public string usnm; 
		public Admin()
		{
			InitializeComponent();
			
			Instance= this;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			// Assuming 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			//usnm= textBox1.Text;
		}

		private void button1_Click(object sender, EventArgs e)//login button..;;;
		{
			var un = textBox1.Text;
			string em = textBox2.Text;
			string pass = textBox4.Text;
			string id = textBox3.Text;
			string dbo = "TA_PROJECT";
			string table = "admin_info";
			string tbo = "ID";
			usnm = un;
			login log = new login();

			bool check = log.signin(un, pass, em, id, dbo,table,tbo);
			if (check)
			{
				//MessageBox.Show("False");
				Admin_profile adf =new Admin_profile();
				adf.Show();
			}
			else
			{
				MessageBox.Show("False try again");
			}
			



		}

		private void Namelb1_Click(object sender, EventArgs e)
		{}
		private void Emaillb2_Click(object sender, EventArgs e)
		{}
		private void IDlb3_Click(object sender, EventArgs e)
		{}
		private void Passwordlb1_Click(object sender, EventArgs e)
		{}
		private void NametextBox1_TextChanged(object sender, EventArgs e)
		{}
		private void EmailtextBox2_TextChanged(object sender, EventArgs e)
		{}
		private void IDtextBox3_TextChanged(object sender, EventArgs e)
		{}

		private void passwordtextBox4_TextChanged(object sender, EventArgs e)
		{}
		private void LOGINFORM_Click(object sender, EventArgs e)
		{}

		private void login_data_error_Click(object sender, EventArgs e)
		{
			login_data_error.Text = "Error";
			//login_data_error.Hide();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{}
		private void exit_label_Click(object sender, EventArgs e)
		{
			//Application.Exit();
			this.Close();
		}
		//to delete the top bar..;;;;
		protected override void WndProc(ref Message m)
		{
			const int WM_NCCALCSIZE = 0x83;
			if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
			{
				m.Result = new IntPtr(0xF0);   // Align client area to all borders
				return;
			}
			base.WndProc(ref m);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				textBox4.PasswordChar = '\0'; // Show the password in plain text
			}
			else
			{
				textBox4.PasswordChar = '*'; // Hide the password using a character (e.g., '*')
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			checkBox1_CheckedChanged(sender, e);
		}
		//textBox4.Update();

			

	}
}
