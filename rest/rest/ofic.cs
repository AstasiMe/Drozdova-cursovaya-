using System;
using System.Collections;
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
    public partial class ofic : Form
    {
        public void Li(int a, int p)
        {
            
            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.Test(p, dataGridView1, a);
                     break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.Test(p, dataGridView2, a); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.Test(p, dataGridView3, a); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.Test(p, dataGridView4, a); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.Test(p, dataGridView5, a); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.Test(p, dataGridView6, a); break;
            }
           
        } //ввод заказа по столам
        public void Up(int a)
        {

            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.Update(a, dataGridView1); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.Update(a, dataGridView2); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.Update(a, dataGridView3); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.Update(a, dataGridView4); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.Update(a, dataGridView5); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.Update(a, dataGridView6); break;
            }

        } //обновление по столам
        public void But(int a)
        {

            switch (a)
            {
                case 1:
                    ClassOrder s1 = new ClassOrder();
                    s1.Buton(button3); break;
                case 2:
                    ClassOrder s2 = new ClassOrder();
                    s2.Buton(button16); break;
                case 3:
                    ClassOrder s3 = new ClassOrder();
                    s3.Buton(button15); break;
                case 4:
                    ClassOrder s4 = new ClassOrder();
                    s4.Buton(button14); break;
                case 5:
                    ClassOrder s5 = new ClassOrder();
                    s5.Buton(button4); break;
                case 6:
                    ClassOrder s6 = new ClassOrder();
                    s6.Buton(button5); break;
                case 7:
                    ClassOrder s7 = new ClassOrder();
                    s7.Buton(button10); break;
                case 8:
                    ClassOrder s8 = new ClassOrder();
                    s8.Buton(button7); break;
                case 9:
                    ClassOrder s9 = new ClassOrder();
                    s9.Buton(button8); break;
                case 10:
                    ClassOrder s10 = new ClassOrder();
                    s10.Buton(button6); break;
            }

        } //о

        //  public void Com(int a, string s)
        //{
        //    switch (a)
        //    {
        //        case 1:
        //            int n1 = listBox1.Items.Count;
        //            listBox1.Items.Insert(n1++, " ");
        //            listBox1.Items.Insert(n1++, "Комментарий: " + s); break;
        //        case 2:
        //            int n2 = listBox2.Items.Count;
        //            listBox2.Items.Insert(n2++, " ");
        //            listBox2.Items.Insert(n2++, "Комментарий: " + s); break;
        //        case 3:
        //            int n3 = listBox3.Items.Count;
        //            listBox3.Items.Insert(n3++, " ");
        //            listBox3.Items.Insert(n3++, "Комментарий: " + s); break;
        //        case 4:
        //            int n4 = listBox4.Items.Count;
        //            listBox4.Items.Insert(n4++, " ");
        //            listBox4.Items.Insert(n4++, "Комментарий: " + s); break;
        //        case 5:
        //            int n5 = listBox5.Items.Count;
        //            listBox5.Items.Insert(n5++, " ");
        //            listBox5.Items.Insert(n5++, "Комментарий: " + s); break;
        //        case 6:
        //            int n6 = listBox6.Items.Count;
        //            listBox6.Items.Insert(n6++, " ");
        //            listBox6.Items.Insert(n6++, "Комментарий: " + s); break;
        //    }
        //}//ввод комментария

        public ofic()
        {
            InitializeComponent();
            //Form1 f1 = new Form1();
            //f1.Close();
            
            
            for (int i = 1; i < 11; i++)
                But(i);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ifrm = Application.OpenForms[0];
            //Form1 f1 = new Form1();ifrm.Show();
            //f1.textBox1.Text = "";
            //f1.textBox2.Text = "";
            Application.Restart();
            this.Close();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 14);
        } 
        private void button16_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 11);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 13);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 12);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 15);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 16);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 18);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 20);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 19);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex + 1;
            Li(a, 17);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            DInfo a = new DInfo();
            a.Show();
        } //доп инфо
        private void button11_Click(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex + 1;
            Up(n);
        } //обновить
       

        private void button1_Click(object sender, EventArgs e)
        {
           
        } //пока хз надо или нет "отправить"

        
    }
}
