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
	public partial class Admin_profile : Form
	{
		public static string k;
		//Admin.Instance.usnm = "f";;
		public Admin_profile()
		{
			InitializeComponent();
			 k = "user";//Admin.Instance.usnm 
			username_label.Text = k;
			
		}

		private void Admin_profile_Load(object sender, EventArgs e)
		{
			this.Text = "administrator form";
			//fetchdata();
			admin_data11.Visible= true;
			admin_data11.BringToFront();
			faculty_data21.Visible= false;
			tA_data31.Visible= false;
			lD_data41.Visible= false;
		}

		private void Admin_title_Click(object sender, EventArgs e)
		{
			
		}

		private void username_label_Click(object sender, EventArgs e)
		{
			
		}






		private void faculty_label1_Click(object sender, EventArgs e)
		{
			faculty_data21.Visible = true ;
			faculty_data21.BringToFront() ;
			admin_data11.Visible = false;
			tA_data31.Visible = false;
			lD_data41.Visible = false;
		}

		private void Admin_label4_Click(object sender, EventArgs e)
		{
			admin_data11.Visible = true;
			admin_data11.BringToFront() ;
			faculty_data21.Visible = false;
			tA_data31.Visible = false;
			lD_data41.Visible = false;
		}

		private void TA_label2_Click(object sender, EventArgs e)
		{
			tA_data31.Visible = true;
			tA_data31.BringToFront();
			admin_data11.Visible = false; 
			faculty_data21.Visible = false;
			lD_data41.Visible = false;
		}

		private void LD_label3_Click(object sender, EventArgs e)
		{
			admin_data11.Visible = false;
			faculty_data21.Visible = false;
			tA_data31.Visible = false;
			
			lD_data41.Visible = true;
			lD_data41.BringToFront();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lD_data41_Load(object sender, EventArgs e)
		{

		}
	}
}
