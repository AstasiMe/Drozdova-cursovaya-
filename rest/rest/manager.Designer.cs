namespace rest
{
    partial class manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиСписокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОВыручкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОНаличииПродуктовНаСкладеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовуюПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restDataSet = new rest.restDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new rest.restDataSetTableAdapters.employeeTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(895, 509);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.документацияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1150, 37);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиСписокСотрудниковToolStripMenuItem,
            this.добавитьНовогоСотрудникаToolStripMenuItem,
            this.удалитьСотрудникаToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // вывестиСписокСотрудниковToolStripMenuItem
            // 
            this.вывестиСписокСотрудниковToolStripMenuItem.Name = "вывестиСписокСотрудниковToolStripMenuItem";
            this.вывестиСписокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(431, 34);
            this.вывестиСписокСотрудниковToolStripMenuItem.Text = "Вывести список сотрудников";
            this.вывестиСписокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.вывестиСписокСотрудниковToolStripMenuItem_Click);
            // 
            // добавитьНовогоСотрудникаToolStripMenuItem
            // 
            this.добавитьНовогоСотрудникаToolStripMenuItem.Name = "добавитьНовогоСотрудникаToolStripMenuItem";
            this.добавитьНовогоСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(431, 34);
            this.добавитьНовогоСотрудникаToolStripMenuItem.Text = "Добавить нового сотрудника";
            this.добавитьНовогоСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоСотрудникаToolStripMenuItem_Click);
            // 
            // удалитьСотрудникаToolStripMenuItem
            // 
            this.удалитьСотрудникаToolStripMenuItem.Name = "удалитьСотрудникаToolStripMenuItem";
            this.удалитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(431, 34);
            this.удалитьСотрудникаToolStripMenuItem.Text = "Удалить сотрудника";
            this.удалитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСотрудникаToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(431, 34);
            this.редактироватьToolStripMenuItem.Text = "Редактировать данные о сотруднике";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // документацияToolStripMenuItem
            // 
            this.документацияToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.документацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетОВыручкеToolStripMenuItem,
            this.отчетОНаличииПродуктовНаСкладеToolStripMenuItem});
            this.документацияToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.документацияToolStripMenuItem.Name = "документацияToolStripMenuItem";
            this.документацияToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.документацияToolStripMenuItem.Text = "Документация";
            // 
            // отчетОВыручкеToolStripMenuItem
            // 
            this.отчетОВыручкеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem,
            this.скачатьToolStripMenuItem});
            this.отчетОВыручкеToolStripMenuItem.Name = "отчетОВыручкеToolStripMenuItem";
            this.отчетОВыручкеToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.отчетОВыручкеToolStripMenuItem.Text = "Отчет о выручке";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // скачатьToolStripMenuItem
            // 
            this.скачатьToolStripMenuItem.Name = "скачатьToolStripMenuItem";
            this.скачатьToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.скачатьToolStripMenuItem.Text = "Скачать";
            this.скачатьToolStripMenuItem.Click += new System.EventHandler(this.скачатьToolStripMenuItem_Click);
            // 
            // отчетОНаличииПродуктовНаСкладеToolStripMenuItem
            // 
            this.отчетОНаличииПродуктовНаСкладеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовуюПоставкуToolStripMenuItem,
            this.просмотрToolStripMenuItem1,
            this.скачатьToolStripMenuItem1});
            this.отчетОНаличииПродуктовНаСкладеToolStripMenuItem.Name = "отчетОНаличииПродуктовНаСкладеToolStripMenuItem";
            this.отчетОНаличииПродуктовНаСкладеToolStripMenuItem.Size = new System.Drawing.Size(360, 34);
            this.отчетОНаличииПродуктовНаСкладеToolStripMenuItem.Text = "Отчет о поставке продуктов";
            // 
            // добавитьНовуюПоставкуToolStripMenuItem
            // 
            this.добавитьНовуюПоставкуToolStripMenuItem.Name = "добавитьНовуюПоставкуToolStripMenuItem";
            this.добавитьНовуюПоставкуToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.добавитьНовуюПоставкуToolStripMenuItem.Text = "Добавить новую поставку";
            this.добавитьНовуюПоставкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовуюПоставкуToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem1
            // 
            this.просмотрToolStripMenuItem1.Name = "просмотрToolStripMenuItem1";
            this.просмотрToolStripMenuItem1.Size = new System.Drawing.Size(340, 34);
            this.просмотрToolStripMenuItem1.Text = "Просмотр";
            this.просмотрToolStripMenuItem1.Click += new System.EventHandler(this.просмотрToolStripMenuItem1_Click);
            // 
            // скачатьToolStripMenuItem1
            // 
            this.скачатьToolStripMenuItem1.Name = "скачатьToolStripMenuItem1";
            this.скачатьToolStripMenuItem1.Size = new System.Drawing.Size(340, 34);
            this.скачатьToolStripMenuItem1.Text = "Скачать";
            this.скачатьToolStripMenuItem1.Click += new System.EventHandler(this.скачатьToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // restDataSet
            // 
            this.restDataSet.DataSetName = "restDataSet";
            this.restDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.restDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 40);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(95, 29);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(65, 81);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(95, 29);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(22, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(939, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 217);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по дате";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "с:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(22, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сортировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::rest.Properties.Resources.fon11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 621);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REST - УПРАВЛЯЮЩИЙ";
            this.Load += new System.EventHandler(this.manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиСписокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОВыручкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОНаличииПродуктовНаСкладеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовуюПоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скачатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem скачатьToolStripMenuItem1;
        private restDataSet restDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private restDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}