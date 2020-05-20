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
        public void Drop(int a)
        {
            admin ad = new admin();
            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.Drop(a, ad.dataGridView7); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.Drop(a, ad.dataGridView2); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.Drop(a, ad.dataGridView3); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.Drop(a, ad.dataGridView4); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.Drop(a, ad.dataGridView5); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.Drop(a, ad.dataGridView6); break;
            }

        } //удаление по столам
        public void Dish(int a, TextBox textBox)
        {

            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    ClassSUM sum1 = new ClassSUM();
                    s1.Report(a, Convert.ToDouble(textBox.Text)); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    ClassSUM sum2 = new ClassSUM();
                    s2.Report(a, Convert.ToDouble(textBox.Text)); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    ClassSUM sum3 = new ClassSUM();
                    s3.Report(a, Convert.ToDouble(textBox.Text)); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    ClassSUM sum4 = new ClassSUM();
                    s4.Report(a, Convert.ToDouble(textBox.Text)); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    ClassSUM sum5 = new ClassSUM();
                    s5.Report(a, Convert.ToDouble(textBox.Text)); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    ClassSUM sum6 = new ClassSUM();
                    s6.Report(a, Convert.ToDouble(textBox.Text)); break;
            }

        } //выгрузка в dishes заказа
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 100)
                {
                    ClassSUM s = new ClassSUM();
                    double a = Convert.ToDouble(textBox2.Text);
                    double b = Convert.ToDouble(textBox3.Text);
                    double c = Convert.ToDouble(textBox1.Text);
                    textBox4.Text = s.SUM(a, b, c).ToString();
                }
                else MessageBox.Show("Размер скидки не может быть 100%");
            }
            catch
            {
                MessageBox.Show("Заполните поле 'Принято'");
            }
        } //кнопка применить
        private void button4_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Dish(a, textBox4);
            textBox4.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "0";
            Drop(a);
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Терминал не подключен");
        }
    }
}
