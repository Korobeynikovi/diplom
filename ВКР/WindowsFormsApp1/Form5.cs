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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1OO9TPLS\SQLEXPRESS;Initial Catalog=Alkasar;Integrated Security=True");

		public int P_ID { get; private set; }
		public int ORG_ID { get; private set; }

		private void GetDataRecord()
		{
			SqlCommand cmd = new SqlCommand("Select * from People_Table", con);
			DataTable dt = new DataTable();

			con.Open();

			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			dataGridView1.DataSource = dt;
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

		private void Form5_Load(object sender, EventArgs e)
		{
			GetDataRecord();
			GetDataRecord2();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (IsValid())
			{
				SqlCommand cmd = new SqlCommand("INSERT INTO People_Table([ФИО сотрудника],[Домашний адрес],[Должность],[Номер телефона]) VALUES (@ФИО_сотрудника, @Домашний_адрес, @Должность, @Номер_телефона)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@ФИО_сотрудника", textBox4.Text);
				cmd.Parameters.AddWithValue("@Домашний_адрес", textBox3.Text);
				cmd.Parameters.AddWithValue("@Должность", textBox2.Text);
				cmd.Parameters.AddWithValue("@Номер_телефона", textBox1.Text);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись добавлена!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


				GetDataRecord();
				Clears();
			}

		}

		private bool IsValid()
		{
			if (textBox4.Text == string.Empty)
			{
				MessageBox.Show("Введите ФИО сотрудника", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (textBox3.Text == string.Empty)
			{
				MessageBox.Show("Введите домашний адрес сотрудника", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (textBox2.Text == string.Empty)
			{
				MessageBox.Show("Введите должность сотрудника", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (textBox1.Text == string.Empty)
			{
				MessageBox.Show("Введите номер телефона сотрудника", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void Clears()
		{
			P_ID = 0;
			ORG_ID = 0;
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (IsValid1())
			{
				SqlCommand cmd = new SqlCommand("INSERT INTO Org_Table([Название объекта],[Адрес объекта],[Описание объекта]) VALUES (@Название_объекта, @Адрес_объекта, @Описание_объекта)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Название_объекта", textBox5.Text);
				cmd.Parameters.AddWithValue("@Адрес_объекта", textBox6.Text);
				cmd.Parameters.AddWithValue("@Описание_объекта", textBox7.Text);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись добавлена!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


				GetDataRecord2();
				Clears();
			}
		}

		private bool IsValid1()
		{
			if (textBox5.Text == string.Empty)
			{
				MessageBox.Show("Введите Название объекта", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (textBox6.Text == string.Empty)
			{
				MessageBox.Show("Введите Адрес объекта", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			P_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
			textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
		}

		private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ORG_ID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
			textBox5.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
			textBox6.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
			textBox7.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (ORG_ID > 0)
			{
				SqlCommand cmd = new SqlCommand("UPDATE Org_Table SET [Название объекта] = @Название_объекта, [Адрес объекта] = @Адрес_объекта, [Описание объекта] = @Описание_объекта WHERE [ID объекта] = @ID", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Название_объекта", textBox5.Text);
				cmd.Parameters.AddWithValue("@Адрес_объекта", textBox6.Text);
				cmd.Parameters.AddWithValue("@Описание_объекта", textBox7.Text);
				cmd.Parameters.AddWithValue("@ID", this.ORG_ID);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись изменена!", "Обновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);


				GetDataRecord2();
				Clears();
			}
			else
			{
				MessageBox.Show("Выберите запись двойным кликом!", "Выбор?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (P_ID > 0)
			{
				SqlCommand cmd = new SqlCommand("UPDATE People_Table SET [ФИО сотрудника] = @ФИО_сотрудника, [Домашний адрес] = @Домашний_адрес, [Должность] = @Должность, [Номер телефона] = @Номер_телефона WHERE [ID сотрудника] = @IDP", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@ФИО_сотрудника", textBox4.Text);
				cmd.Parameters.AddWithValue("@Домашний_адрес", textBox3.Text);
				cmd.Parameters.AddWithValue("@Должность", textBox2.Text);
				cmd.Parameters.AddWithValue("@Номер_телефона", textBox1.Text);
				cmd.Parameters.AddWithValue("@IDP", this.P_ID);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись изменена!", "Обнолено", MessageBoxButtons.OK, MessageBoxIcon.Information);

				GetDataRecord();
				Clears();
			}
			else
			{
				MessageBox.Show("Выберите запись двойным кликом!", "Выбор?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (P_ID > 0)
			{
				SqlCommand cmd = new SqlCommand("DELETE FROM People_Table WHERE  [ID сотрудника] = @IDP", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@IDP", this.P_ID);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

				GetDataRecord();
				Clears();
			}
			else
			{
				MessageBox.Show("Выберите запись двойным кликом!", "Выбор?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (ORG_ID > 0)
			{
				SqlCommand cmd = new SqlCommand("DELETE FROM Org_Table WHERE [ID объекта] = @ID", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@ID", this.ORG_ID);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Запись удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);


				GetDataRecord2();
				Clears();
			}
			else
			{
				MessageBox.Show("Выберите запись двойным кликом!", "Выбор?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
