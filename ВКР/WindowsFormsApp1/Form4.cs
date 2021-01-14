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

namespace WindowsFormsApp1
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1OO9TPLS\SQLEXPRESS;Initial Catalog=Alkasar;Integrated Security=True");
			SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Logins where Логин = '"+ textBox1.Text +"' and Пароль = '"+ textBox2.Text +"'", con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
				
				Form5 f = new Form5();
				f.ShowDialog();
				Close();
			}
			else 
			{
				MessageBox.Show("Пожалуйста проверьте правильность ввода логина/пароля", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
