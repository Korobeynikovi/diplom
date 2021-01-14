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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1OO9TPLS\SQLEXPRESS;Initial Catalog=Alkasar;Integrated Security=True");


		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();
			//SqlCommand cmd = new SqlCommand("SELECT* FROM Mane_table WHERE [ФИО сотрудника]='" + textBox1.Text +"' ");
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select [ФИО сотрудника], [Название объекта], [Время прибытия] from Mane_Table where [ФИО сотрудника] LIKE '%" + textBox1.Text+ "%' OR [Название объекта] LIKE '%" + textBox1.Text + "%' OR [Время прибытия] LIKE '%" + textBox1.Text + "%'";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			GetDataRecord();
		}

		private void GetDataRecord()
		{
			SqlCommand cmd = new SqlCommand("Select [ФИО сотрудника], [Название объекта], [Время прибытия] from Mane_Table", con);
			DataTable dt = new DataTable();

			con.Open();

			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			dataGridView1.DataSource = dt;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("Select [ФИО сотрудника], [Название объекта], [Время прибытия] from Mane_Table", con);
			DataTable dt = new DataTable();

			con.Open();

			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			dataGridView1.DataSource = dt;
			textBox1.Clear();
		}

		Bitmap bmp;

		private void button3_Click(object sender, EventArgs e)
		{
			int height = dataGridView1.Height;
			dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
			bmp = new Bitmap(dataGridView1.Width,dataGridView1.Height);
			dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
			dataGridView1.Height = height;
			printPreviewDialog1.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bmp, 0, 0);
		}
	}
}
