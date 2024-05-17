using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TA_project
{
	

	public partial class TA_UserContr : UserControl
	{
		int fccid;
		private string connectionString = "Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=TA_PROJECT;Integrated Security=True";

		public TA_UserContr()
		{
			InitializeComponent();
		}
		public void Get_TA_Details(int facc_id)
		{
			fccid = facc_id;
			string query = "SELECT TA.name, TA.email FROM TA JOIN Faculty ON TA.faculty_id = Faculty.faculty_id" +
				" WHERE Faculty.faculty_id =" + facc_id;
			using (SqlConnection sqlC = new SqlConnection(connectionString))
			{
				sqlC.Open();
				SqlDataAdapter Dataadp = new SqlDataAdapter(query, sqlC);
				DataTable tbl = new DataTable();
				Dataadp.Fill(tbl);
				TaList.DataSource = tbl;
			}
		}

		private void TA_UserContr_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string userInput = textBox1.Text;
			if (string.IsNullOrEmpty(userInput))
			{
				MessageBox.Show("Please enter a value.");
			}
			else
			{
				string query = "INSERT INTO task_ta values('" + userInput + "'," + fccid + ")";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						// Add parameters to prevent SQL injection
						command.Parameters.AddWithValue("@UserInput", userInput);

						connection.Open();
						int rowsAffected = command.ExecuteNonQuery();
						// Check rowsAffected if needed for success/failure
						if (rowsAffected > 0)
						{
							// Successful insertion
							MessageBox.Show("Task assigned successfully!");
						}
						else
						{
							// Insertion failed
							MessageBox.Show("Task assigned failed!");
						}
					}
				}
			}
		}
	}
}
