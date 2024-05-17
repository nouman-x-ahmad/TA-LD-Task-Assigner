using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TA_project
{
	internal class login
	{
		public string Name;
		public string password;
		public string Email;
		public string ID;


		public bool signin(string n, string p, string e, string i ,string dbo, string table,string idx,string nxme="name")
		{ string db = "TA_DB";
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog="+dbo+";Integrated Security=True"); // Connection String ;Trust Server Certificate=True

			conn.Open();
			//MessageBox.Show("Connection Open");
			
			var un = n;
			string em = e;
			string pass = p;
			string id = i;
			System.Console.WriteLine(un);
			//string slect =
			// Fetch data
			string selectQuery = $"SELECT * FROM {table} WHERE {nxme} = '{un}'  AND Password = '{pass}' AND Email= '{em}' AND {idx} ='{id}'";

			using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
			{

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{

					MessageBox.Show("LOGIN SUCCESSFUL BROTHER!");
					return true;
				}
				else
				{

					//MessageBox.Show("Data not matched!");
					//login_data_error.Text = "error";
					return false;
				}
			}
		}



	}
}
