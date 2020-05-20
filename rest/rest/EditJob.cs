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
    public partial class EditJob : Form
    { 
        employee item;
        public EditJob(employee it)
        {
            InitializeComponent();
            item = it;
            ClassManager m = new ClassManager();
            m.Edit(item, comboBox1, textBox1, textBox2, textBox3, maskedTextBox1, textBox5, textBox7);
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    ClassManager m = new ClassManager();
                    m.EditFinal(item, comboBox1, textBox1, textBox2, textBox3, maskedTextBox1, textBox5, textBox7);
                    MessageBox.Show("Изменения сохранены");
                }
                else MessageBox.Show("Поля 'фамилия' и 'имя' не могут быть пустыми");
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
