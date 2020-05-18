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
    public partial class cook : Form
    {
        public cook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditMenu em = new EditMenu();
            em.Show();
        }//редактировать меню

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DInfo a = new DInfo();
            a.Show();
        } //доп инфо

        private void button1_Click(object sender, EventArgs e)
        {
            ClassOrder ord = new ClassOrder();
            ord.ShowOrdersK(dataGridView1);
        }//активные заказы
    }
}
