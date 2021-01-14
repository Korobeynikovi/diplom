namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBoxOrg = new System.Windows.Forms.ComboBox();
			this.orgtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.alkasarDataSet = new WindowsFormsApp1.AlkasarDataSet();
			this.comboBoxName = new System.Windows.Forms.ComboBox();
			this.peopletableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.manetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.manetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mane_tableTableAdapter = new WindowsFormsApp1.AlkasarDataSetTableAdapters.Mane_tableTableAdapter();
			this.people_tableTableAdapter = new WindowsFormsApp1.AlkasarDataSetTableAdapters.People_tableTableAdapter();
			this.org_tableTableAdapter = new WindowsFormsApp1.AlkasarDataSetTableAdapters.Org_tableTableAdapter();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orgtableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alkasarDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.peopletableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manetableBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.manetableBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 504);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel4.Location = new System.Drawing.Point(124, 119);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(5, 107);
			this.panel4.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.settingstoolscrossincircularbutton_80271__1_;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(16, 247);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(108, 107);
			this.button3.TabIndex = 2;
			this.toolTip1.SetToolTip(this.button3, "Клавиша перехода в режим администрирования базы данных");
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
			// 
			// button1
			// 
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.searchmagnifieroutline_80737__1_;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 107);
			this.button1.TabIndex = 0;
			this.toolTip1.SetToolTip(this.button1, "Клавиша перехода в режим поиска записей и печати табель-листов");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(155, 100);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 81);
			this.label1.TabIndex = 0;
			this.label1.Text = "Система учета рабочего времени сотрудников";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel3.Controls.Add(this.comboBoxOrg);
			this.panel3.Controls.Add(this.comboBoxName);
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.dataGridView3);
			this.panel3.Controls.Add(this.dataGridView2);
			this.panel3.Location = new System.Drawing.Point(155, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(645, 504);
			this.panel3.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(588, 166);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(35, 24);
			this.textBox3.TabIndex = 12;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(588, 119);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(35, 24);
			this.textBox2.TabIndex = 11;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(645, 100);
			this.panel5.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(170, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(315, 28);
			this.label2.TabIndex = 0;
			this.label2.Text = "Добавление записи в журнал";
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button4.AutoSize = true;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(242, 241);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(145, 33);
			this.button4.TabIndex = 3;
			this.button4.Text = "Добавить запись";
			this.toolTip1.SetToolTip(this.button4, "Клавиша добавления новой записи в базу данных");
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(19, 213);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(604, 22);
			this.textBox1.TabIndex = 2;
			this.toolTip1.SetToolTip(this.textBox1, "Окно редактирования информации о времени прибытия сотрудников");
			this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(204, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "Время прибытия сотрудника:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(199, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Наименование организации:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "ФИО сотрудника:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(19, 280);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(604, 212);
			this.dataGridView1.TabIndex = 4;
			this.toolTip1.SetToolTip(this.dataGridView1, "Рвбочая область базы данных");
			// 
			// comboBoxOrg
			// 
			this.comboBoxOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxOrg.DataSource = this.orgtableBindingSource;
			this.comboBoxOrg.DisplayMember = "Название объекта";
			this.comboBoxOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxOrg.FormattingEnabled = true;
			this.comboBoxOrg.Location = new System.Drawing.Point(19, 166);
			this.comboBoxOrg.Name = "comboBoxOrg";
			this.comboBoxOrg.Size = new System.Drawing.Size(604, 24);
			this.comboBoxOrg.TabIndex = 1;
			this.toolTip1.SetToolTip(this.comboBoxOrg, "Редактирование информации об Организации");
			this.comboBoxOrg.ValueMember = "Название объекта";
			this.comboBoxOrg.SelectedValueChanged += new System.EventHandler(this.comboBoxOrg_SelectedValueChanged);
			// 
			// orgtableBindingSource
			// 
			this.orgtableBindingSource.DataMember = "Org_table";
			this.orgtableBindingSource.DataSource = this.alkasarDataSet;
			// 
			// alkasarDataSet
			// 
			this.alkasarDataSet.DataSetName = "AlkasarDataSet";
			this.alkasarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBoxName
			// 
			this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxName.DataSource = this.peopletableBindingSource;
			this.comboBoxName.DisplayMember = "ФИО сотрудника";
			this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxName.FormattingEnabled = true;
			this.comboBoxName.Location = new System.Drawing.Point(19, 119);
			this.comboBoxName.Name = "comboBoxName";
			this.comboBoxName.Size = new System.Drawing.Size(604, 24);
			this.comboBoxName.TabIndex = 0;
			this.toolTip1.SetToolTip(this.comboBoxName, "Редактирование ФИО сотрудника");
			this.comboBoxName.ValueMember = "ФИО сотрудника";
			this.comboBoxName.SelectedValueChanged += new System.EventHandler(this.comboBoxName_SelectedValueChanged);
			// 
			// peopletableBindingSource
			// 
			this.peopletableBindingSource.DataMember = "People_table";
			this.peopletableBindingSource.DataSource = this.alkasarDataSet;
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(297, 325);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(130, 75);
			this.dataGridView3.TabIndex = 13;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(80, 302);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(119, 74);
			this.dataGridView2.TabIndex = 1;
			// 
			// manetableBindingSource1
			// 
			this.manetableBindingSource1.DataMember = "Mane_table";
			this.manetableBindingSource1.DataSource = this.alkasarDataSet;
			// 
			// manetableBindingSource
			// 
			this.manetableBindingSource.DataMember = "Mane_table";
			this.manetableBindingSource.DataSource = this.alkasarDataSet;
			// 
			// mane_tableTableAdapter
			// 
			this.mane_tableTableAdapter.ClearBeforeFill = true;
			// 
			// people_tableTableAdapter
			// 
			this.people_tableTableAdapter.ClearBeforeFill = true;
			// 
			// org_tableTableAdapter
			// 
			this.org_tableTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 504);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Табель";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orgtableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alkasarDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.peopletableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manetableBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.manetableBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxOrg;
		private System.Windows.Forms.ComboBox comboBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel5;
		private AlkasarDataSet alkasarDataSet;
		private System.Windows.Forms.BindingSource manetableBindingSource;
		private AlkasarDataSetTableAdapters.Mane_tableTableAdapter mane_tableTableAdapter;
		private System.Windows.Forms.BindingSource manetableBindingSource1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.BindingSource peopletableBindingSource;
		private AlkasarDataSetTableAdapters.People_tableTableAdapter people_tableTableAdapter;
		private System.Windows.Forms.BindingSource orgtableBindingSource;
		private AlkasarDataSetTableAdapters.Org_tableTableAdapter org_tableTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

