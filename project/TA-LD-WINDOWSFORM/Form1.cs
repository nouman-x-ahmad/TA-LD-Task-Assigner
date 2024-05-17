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

	public partial class Form1 : Form
	{
		private Label nameLabel;
		private string connectionString = "Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=TA_PROJECT;Integrated Security=True";
		int ta_ID;
		public Form1(int ta_id)
		{
			nameLabel = new Label();
			nameLabel.Font = new Font("Arial", 18);
			nameLabel.Location = new Point(80, 80);
			nameLabel.AutoSize = true;
			this.Controls.Add(nameLabel);

			InitializeComponent();
			ta_ID = ta_id;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			nameL(ta_ID);

			disp_task(ta_ID);
		}
		private void nameL(int taID)
		{

			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			string query = $"SELECT name FROM TA WHERE ta_id = ( SELECT ta_id FROM TA  WHERE ta_id = {taID})";
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
		private void disp_task(int taID)
		{
			string query = "SELECT task_ta.task FROM task_ta INNER JOIN TA ON task_ta.faculty_id = TA.faculty_id where TA.ta_id=" + taID;
			using (SqlConnection sqlC = new SqlConnection(connectionString))
			{
				sqlC.Open();
				SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlC);
				DataTable table = new DataTable();
				dataAdapter.Fill(table);
				taskTA.DataSource = table;
			}
		}

	

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string deleteQuery = $"DELETE FROM task_ta WHERE faculty_id IN (SELECT faculty_id FROM TA WHERE ta_id = {ta_ID})";
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
