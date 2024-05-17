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
	public partial class Form3 : Form
	{
		private Label nameFac;
		int fac_id;
		private string connectionString = "Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog=TA_PROJECT;Integrated Security=True";

		public Form3(int fac_idd)
		{
			fac_id = fac_idd;


			//Name of Fac
			nameFac = new Label();
			nameFac.Font = new Font("Arial", 18, FontStyle.Bold);
			nameFac.ForeColor = Color.White; // Set font color to red
			nameFac.BackColor = Color.CornflowerBlue;
			nameFac.Location = new Point(20, 20);
			nameFac.AutoSize = true;
			this.Controls.Add(nameFac);
			nameOfFac(fac_idd);

			//-----end-----
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			tA_UserContr1.Visible = true;
			tA_UserContr1.Get_TA_Details(fac_id);
			lD_UserContr1.Visible = false;
		}
		private void nameOfFac(int facID)
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			string query = "select faculty_name from Faculty where faculty_id = " + facID;
			SqlCommand command = new SqlCommand(query, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			string name;
			while (reader.Read())
			{
				name = reader["faculty_name"].ToString();
				nameFac.Text = name;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			tA_UserContr1.Visible = true;
			tA_UserContr1.Get_TA_Details(fac_id);
			lD_UserContr1.Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			lD_UserContr1.Visible = true;
			lD_UserContr1.Get_LD_Details(fac_id);
			tA_UserContr1.Visible = false;
		}
	}
}
