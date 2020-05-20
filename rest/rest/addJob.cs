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
    public partial class addJob : Form
    {
        public addJob()
        {
            InitializeComponent();
        }

        private void addJob_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.restDataSet.position);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ClassReports r = new ClassReports();
            try
            {
                string s = ClassReports.NameNew(textBox1.Text.Trim());
                string n = ClassReports.NameNew(textBox2.Text.Trim());
                string l = ClassReports.NameNew(textBox3.Text.Trim());
                DateTime date = Convert.ToDateTime(maskedTextBox1.Text);
                string log = textBox5.Text.Trim();
                string pass = textBox7.Text.Trim();
                int i = comboBox1.SelectedIndex;
                ClassManager d = new ClassManager();
                d.AddJ(s, n, l, date, i, log, pass);
            }
            catch 
            {
                MessageBox.Show("Проверьте правильность заполняемых данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char I = e.KeyChar;
            if ((I < 'А' || I > 'я') && I != 8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char I = e.KeyChar;
            if ((I < 'А' || I > 'я') && I != 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char I = e.KeyChar;
            if ((I < 'А' || I > 'я') && I != 8)
                e.Handled = true;
        }
    }
}
