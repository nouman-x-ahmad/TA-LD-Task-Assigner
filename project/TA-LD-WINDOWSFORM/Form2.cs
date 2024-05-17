using System;
using System.Collections;
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
	public partial class Form2 : Form
	{
		private Label nameLabel;
		int ldID;
		private string connectionString = "Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=TA_PROJECT;Integrated Security=True";

		public Form2(int ld_id)
		{
			InitializeComponent();
			ldID = ld_id;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			nameLabel = new Label();
			nameLabel.Font = new Font("Arial", 18);
			nameLabel.Location = new Point(80, 80);
			nameLabel.AutoSize = true;
			this.Controls.Add(nameLabel);
			nameL(ldID);

			disp_task(ldID);
		}
		private void nameL(int ld_ID)
		{

			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			string query = $"SELECT name FROM LD WHERE ld_id = ( SELECT ld_id FROM LD  WHERE ld_id = {ld_ID})";
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			string name;
			while (reader.Read())
			{
				name = reader["name"].ToString();
				nameLabel.Text = name;
			}
			reader.Close();
		}
		private void disp_task(int ld_ID)
		{
			string query = "SELECT task_ld.task FROM task_ld INNER JOIN LD ON task_ld.faculty_id = LD.faculty_id where LD.ld_id=" + ld_ID;
			using (SqlConnection sqlC = new SqlConnection(connectionString))
			{
				sqlC.Open();
				SqlDataAdapter Dataadp = new SqlDataAdapter(query, sqlC);
				DataTable tbl = new DataTable();
				Dataadp.Fill(tbl);
				tasktable.DataSource = tbl;
			}
		}


		private void taskTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string deleteQuery = $"DELETE FROM task_ld WHERE faculty_id IN (SELECT faculty_id FROM LD WHERE ld_id = {ldID})";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();

				// Execute the DELETE query
				using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
				{
					int rowsAffected = sqlCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MessageBox.Show("Task has been done!");
						// Optionally, you can update your UI or perform additional actions here after deletion.
					}
					else
					{
						MessageBox.Show("error!");
					}
				}
			}
		}

	}
}
