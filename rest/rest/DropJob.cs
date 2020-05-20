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
    public partial class DropJob : Form
    {
        public DropJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = ClassReports.NameNew(textBox1.Text.Trim());
                string n = ClassReports.NameNew(textBox2.Text.Trim());
                string l = ClassReports.NameNew(textBox3.Text.Trim());
                ClassManager m = new ClassManager();
                m.Drop(s, n, l);
            }
            catch {
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
