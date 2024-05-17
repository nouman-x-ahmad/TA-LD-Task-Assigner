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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TA_project
{
	public partial class admin_data1 : UserControl
	{
		public static string k;
		public admin_data1()
		{
			InitializeComponent();
			k = Admin.Instance.usnm;
		}

		private void admin_data1_Load(object sender, EventArgs e)
		{
			fetchdata();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}




		private void fetchdata()
		{
			string dbo = "TA_PROJECT";
			string table = "admin_info";
			string connectionString = "Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=" + dbo + ";Integrated Security=True";

			string selectQuery = "SELECT Name, Email, ID FROM "+table+" where Name =@k";
			
			//string selectQuery = $"SELECT * FROM TA_Table WHERE NAME = '{un}'  AND Password = '{pass}' AND Email= '{em}' AND ID ='{id}'";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(selectQuery, connection);
				connection.Open();
				command.Parameters.AddWithValue("@k", Admin.Instance.usnm);//Admin.Instance.usnm <<<-------------------
				using (SqlDataReader reader = command.ExecuteReader())
				{
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							
							string nme = reader.GetString(reader.GetOrdinal("Name")); 
							string em = reader.GetString(reader.GetOrdinal("Email")); 
							string ID = reader.GetString(reader.GetOrdinal("ID")); 

						
							name_textBox1.Text = nme.ToString();
							Email_textBox3.Text = em;
							ID_textBox2.Text= ID.ToString();
						}
					}
					else
					{
						// Handle no data scenario
						name_textBox1.Text = "No data found.";
					}
				}
			}


		}

		private void name_textBox1_TextChanged(object sender, EventArgs e)
		{
			name_textBox1.ReadOnly = true;
			name_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		}
		private void ID_textBox2_TextChanged(object sender, EventArgs e) 
		{
			ID_textBox2.ReadOnly = true;
		}
		private void Email_textBox3_TextChanged(object sender, EventArgs e) 
		{
			Email_textBox3.ReadOnly = true;
		}
		private void age_textBox4_TextChanged(object sender, EventArgs e) 
		{
			age_textBox4.ReadOnly = true;
		}
	}
}
