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

namespace TA_project
{
	public partial class LD_data4 : UserControl
	{
		public LD_data4()
		{
			InitializeComponent();
		}
		private void Namebox1_TextChanged(object sender, EventArgs e)
		{}
		private void EmailBox2_TextChanged(object sender, EventArgs e)
		{}
		private void IDBox3_TextChanged(object sender, EventArgs e)
		{}
		private void PaswordBox4_TextChanged(object sender, EventArgs e)
		{}
		private void update_button1_Click(object sender, EventArgs e)
		{
			string dbo = "TA_PROJECT";//TA_Table
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=" + dbo + ";Integrated Security=True"); // Connection String ;Trust Server Certificate=True
			string table = "LD_info";
			conn.Open();
			//MessageBox.Show("Connection Open");

			var un = Namebox1.Text;
			string em = EmailBox2.Text;
			string pass = PaswordBox4.Text;
			string id = IDBox3.Text;
			System.Console.WriteLine(un);
			//string slect =
			// Fetch data 
			string selectQuery = $"update {table} set NAME = '{un}', Password = '{pass}', Email= '{em}' where ID ='{id}'";

			using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
			{
				cmd.Parameters.AddWithValue("ID", id);
				cmd.Parameters.AddWithValue("Email", em);
				cmd.Parameters.AddWithValue("Password", pass);
				cmd.Parameters.AddWithValue("Name", un);
				cmd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("true");


			}
		}

		private void create_button1_Click(object sender, EventArgs e)
		{
			string dbo = "TA_PROJECT";//TA_Table
			string table = "LD_info";
			Register register = new Register();
			bool check = register.signup(Namebox1.Text, PaswordBox4.Text, EmailBox2.Text, IDBox3.Text, dbo , table);
			if (check)
			{
				MessageBox.Show("successful");
			}
		}

		private void delete_button2_Click(object sender, EventArgs e)
		{
			string dbo = "TA_PROJECT";//TA_Table
			string table = "LD_info";//TA_Table
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=" + dbo + ";Integrated Security=True"); // Connection String ;Trust Server Certificate=True

			conn.Open();
			//MessageBox.Show("Connection Open");

			var un = Namebox1.Text;
			string em = EmailBox2.Text;
			string pass = PaswordBox4.Text;
			string id = IDBox3.Text;
			System.Console.WriteLine(un);
			//string slect =
			// Fetch data 
			string selectQuery = $"delete {table} where ID ='{id}'";
			using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
			{
				cmd.Parameters.AddWithValue("ID", id);
				cmd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("true");
			}
		}

		private void search_button1_Click(object sender, EventArgs e)
		{
			string dbo = "TA_PROJECT";//TA_Table
			string table = "LD_info";//TA_Table
			string id = IDBox3.Text;
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=" + dbo + ";Integrated Security=True"); // Connection String ;Trust Server Certificate=True
			conn.Open();
			//MessageBox.Show("
			string selectQuery = $"Select * From {table} where id='{id}'";
			using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
			{
				SqlDataAdapter d = new SqlDataAdapter(cmd);
				DataTable t = new DataTable();
				d.Fill(t);
				dataview.DataSource = t;
			}


		}

		private void exit_label_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
