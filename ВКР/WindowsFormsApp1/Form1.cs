using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			panel4.Height = button1.Height;
			panel4.Top = button1.Top;
			GetDataRecord();
			GetDataRecord2();
			GetDataRecord3();
			



		}

		SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1OO9TPLS\SQLEXPRESS;Initial Catalog=Alkasar;Integrated Security=True");

		

		private void button1_Click(object sender, EventArgs e)
		{
			Form ifrm = new Form2();
			ifrm.ShowDialog();
		}


		private void button3_Click(object sender, EventArgs e)
		{
			Form ifrm = new Form4();
			ifrm.ShowDialog();
		}

		private void button1_MouseMove(object sender, MouseEventArgs e)
		{
			panel4.Height = button1.Height;
			panel4.Top = button1.Top;
		}



		private void button3_MouseMove(object sender, MouseEventArgs e)
		{
			panel4.Height = button3.Height;
			panel4.Top = button3.Top;
		}

		private void button4_Click(object sender, EventArgs e)
		{

			if (IsValid())
			{
				SqlCommand cmd = new SqlCommand("INSERT INTO Mane_Table([ФИО сотрудника], [ID сотрудника], [Название объекта], [ID объекта],  [Время прибытия]) VALUES (@ФИО_сотрудника, @ID_сотрудника, @Название_объекта, @ID_объекта, @Время_прибытия)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@ФИО_сотрудника", comboBoxName.Text);
				cmd.Parameters.AddWithValue("@Название_объекта", comboBoxOrg.Text);
				cmd.Parameters.AddWithValue("@Время_прибытия", textBox1.Text);
				cmd.Parameters.AddWithValue("@ID_сотрудника", textBox2.Text);
				cmd.Parameters.AddWithValue("@ID_объекта", textBox3.Text);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись добавлена!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


				GetDataRecord();
				textBox1.Clear();
			}

		}

		private bool IsValid()
		{
			if (comboBoxName.Text == string.Empty)
			{
				MessageBox.Show("Введите Имя", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "alkasarDataSet.Org_table". При необходимости она может быть перемещена или удалена.
			this.org_tableTableAdapter.Fill(this.alkasarDataSet.Org_table);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "alkasarDataSet.People_table". При необходимости она может быть перемещена или удалена.
			this.people_tableTableAdapter.Fill(this.alkasarDataSet.People_table);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "alkasarDataSet.Mane_table". При необходимости она может быть перемещена или удалена.
			this.mane_tableTableAdapter.Fill(this.alkasarDataSet.Mane_table);
			GetDataRecord();
			GetDataRecord2();
			GetDataRecord3();
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

		private void GetDataRecord3()
		{
			SqlCommand cmd = new SqlCommand("Select * from People_Table", con);
			DataTable dt = new DataTable();

			con.Open();

			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			dataGridView3.DataSource = dt;
		}
		private void GetDataRecord2()
		{
			SqlCommand cmd = new SqlCommand("Select  * from Org_Table", con);
			DataTable dt = new DataTable();

			con.Open();

			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			dataGridView2.DataSource = dt;
		}

		private void comboBoxOrg_SelectedValueChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < comboBoxOrg.Items.Count; i++)
			{
				if (comboBoxOrg.SelectedIndex == i)
				{
					textBox3.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
					break;
				}
			}
		}

		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox1.Text = DateTime.Now.ToString(); //textBox1 - имя какого-то контрола
		}

		private void comboBoxName_SelectedValueChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < comboBoxName.Items.Count; i++)
			{
				if (comboBoxName.SelectedIndex == i)
				{
					textBox2.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
					break;
				}
			}
		}
	}
}