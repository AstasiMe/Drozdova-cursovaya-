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
    public partial class EAT : Form
    {
        public EAT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = ClassReports.NameNew(textBox1.Text.Trim());
                int b = Convert.ToInt32(textBox2.Text.Trim());
                DateTime date = Convert.ToDateTime(maskedTextBox1.Text.Trim());
                string c = comboBox1.Text.Trim();
                double d = Convert.ToDouble(textBox3.Text.Trim());
                if (d > 0)
                {
                    ClassManager m = new ClassManager();
                    m.Stock(a, b, date, c, d);
                    MessageBox.Show("Новая поставка добавлена");
                }
                else MessageBox.Show("Отрицательные значения не погут быть в поле 'сумма'");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенной даты");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EAT_Load(object sender, EventArgs e)
        {

        }
    }
}
