using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace TA_project
{
	internal class Register
	{
		public bool signup(string n,string p, string e,string i,string dbo,string table)
		{
			SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T1VJKR\\SQLEXPRESS;Initial Catalog="+dbo+";Integrated Security=True"); // Connection String ;Trust Server Certificate=True
			conn.Open();
			MessageBox.Show("Connection Open");
			SqlCommand cm;
			String nm = n;
			String id = i;
			String psw = p;
			String em = e;

			if (checkEmail(em))
			{
				MessageBox.Show("Email is in the correct format!");
		
			}
			else if (!(checkEmail(em)))
			{
				MessageBox.Show("Please write email as username@fast.com.");
				return false;

			}
			if (string.IsNullOrWhiteSpace(nm) || string.IsNullOrWhiteSpace(psw))
			{
				MessageBox.Show("Please fill in all the required fields."); // Display an error message
				return false;
			}
			
			else
			{
				String query = "Insert into " + table + "(NAME,PASSWORD,ID,EMAIL) values ('" + nm + "','" + psw + "','" + id + "','" + em + "')";
				cm = new SqlCommand(query, conn);
				cm.ExecuteNonQuery();
				MessageBox.Show("REGISTERRED LEZGOOOO");
				cm.Dispose();
				conn.Close();
				return true;
			}
			
			
		}
		


	private bool checkEmail(string em)
	{
	
		string temp = @"@fast\.com$"; 
		return Regex.IsMatch(em, temp, RegexOptions.IgnoreCase);
	}

}
}
