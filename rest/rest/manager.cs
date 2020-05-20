using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rest
{
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void вывестиСписокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            ClassManager cm = new ClassManager();
            cm.Conc(dataGridView1);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close();
        }

        private void добавитьНовогоСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addJob aj = new addJob();
            aj.Show();
        }

        private void удалитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropJob d = new DropJob();
            d.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.restDataSet.employee);

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restEntities db = new restEntities();
            List<employee> query = (from j in db.employee
                                    select j).ToList();
            try
            {
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    employee item = query.First(w => w.id_empl.ToString() == dataGridView1.SelectedCells[0]
                    .OwningRow.Cells[0].Value.ToString());

                    EditJob edit = new EditJob(item);
                    edit.Owner = this;
                    edit.Show();
                }
            }
            catch {
                MessageBox.Show("Обновите список сотрудников");

            }
        }

        private void добавитьНовуюПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAT eat = new EAT();
            eat.Show();
        }

        private void просмотрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            groupBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            ClassManager m = new ClassManager();
            m.StockEnter(dataGridView1);
        }

        private void скачатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassManager m = new ClassManager();
            m.DownloadST();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime a = Convert.ToDateTime(maskedTextBox1.Text);
                DateTime b = Convert.ToDateTime(maskedTextBox2.Text);
                ClassManager m = new ClassManager();
                m.Sort1(dataGridView1, a, b);
            }
            catch
            { 
                MessageBox.Show("Неверный формат даты");
            }
        }

        private void скачатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassManager m = new ClassManager();
            m.DownloadMO();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            groupBox1.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            ClassManager m = new ClassManager();
            m.MoneyEnter(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime a = Convert.ToDateTime(maskedTextBox1.Text);
                DateTime b = Convert.ToDateTime(maskedTextBox2.Text);
                ClassManager m = new ClassManager();
                m.Sort2(dataGridView1, a, b);
            }
            catch
            {
                MessageBox.Show("Неверный формат даты");
            }
        }
    }
}
