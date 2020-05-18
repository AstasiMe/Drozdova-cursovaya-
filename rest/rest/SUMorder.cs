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
    public partial class SUMorder : Form
    {
        public SUMorder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClassSUM s = new ClassSUM();
                double a = Convert.ToDouble(textBox2.Text);
                double b = Convert.ToDouble(textBox3.Text);
                double c = Convert.ToDouble(textBox1.Text);
                textBox4.Text = s.SUM(a, b, c).ToString();
            }
            catch
            {
                MessageBox.Show("Заполните поле 'Принято'");
            }
        } //кнопка применить
        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "0";
            MessageBox.Show("Оплата произведена");
        } //кнопка оплатить
        private void button1_Click(object sender, EventArgs e)
        {
            int m = comboBox1.SelectedIndex + 1;
            ClassSUM s2 = new ClassSUM();
            textBox2.Text = s2.Itog(m);
        } //кнопка ok

        private void SUMorder_Load(object sender, EventArgs e)
        {

        }
    }
}
